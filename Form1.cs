// Form1.cs

using System.Drawing.Printing;

namespace FoodPantryApp
{
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        /// <summary>
        /// The log path variable for logging.
        /// </summary>
        public string logPath = String.Empty;

        /// <summary>
        /// The list count variable for use in print preview and printing.
        /// </summary>
        private int listCount;

        /// <summary>
        /// The list position variable for use in print preview and printing.
        /// </summary>
        private int listPosition = 0;

        /// <summary>
        /// The page counter variable for use in print preview and printing.
        /// </summary>
        private int pageCounter = 0;

        /// <summary>
        /// The ypos variable for use in print preview and printing.
        /// </summary>
        private float ypos = 1;

        /// <summary>
        /// The preview dlg variable for use in print preview and printing.
        /// </summary>
        private PrintPreviewDialog previewDlg = null;

        /// <summary>
        /// The inventory list that stores the data read from file or saved to.
        /// </summary>
        private InventoryList inventoryList;

        /// <summary>
        /// The filter list that stores the filtered data from the inventory list.
        /// </summary>
        private List<string> FilterList = new List<string>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            this.InitializeComponent();
            this.inventoryList = new InventoryList();
            this.FillFilterList();
            this.RefreshInventoryList();
            this.UpdateListButton.Enabled = false;
        }

        /// <summary>
        /// The function that adds the filter options for the filter list functions.
        /// </summary>
        private void FillFilterList()
        {
            this.FilterList.Add("Type");
            this.FilterList.Add("Name");
            this.FilterList.Add("Quantity");
            foreach (var item in this.FilterList)
            {
                this.FilterComboBox.Items.Add(item);
            }
            this.FilterComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// The filter button_ click that filters the inventory list and displays the filtered list.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filterInput = this.FilterTextBox.Text.ToLower();
            var filterCheck = this.FilterCheckBoxCheck();
            if (this.inventoryList.Count > 0)
            {
                var items = this.inventoryList.GetAllItems();
                this.InventoryDisplayList.Items.Clear();
                foreach (var item in items)
                {
                    if (filterCheck == 0)
                    {

                        if (item.Type.ToLower().Contains(filterInput))
                        {
                            InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
                        }
                    }
                    else if (filterCheck == 1)
                    {
                        if (item.Name.ToLower().Contains(filterInput))
                        {
                            InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
                        }
                    }
                    else if (filterCheck == 2)
                    {
                        var value = int.TryParse(filterInput, out int result);
                        if (value)
                        {
                            if (item.Quantity == result)
                            {
                                InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The filter check box check function that returns the position of the filter select box.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        private int FilterCheckBoxCheck()
        {
            var filterNum = this.FilterComboBox.SelectedIndex;
            return filterNum;
        }

        /// <summary>
        /// The functions that resets the displayed list and clears the filter list.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void ResetListButton_Click(object sender, EventArgs e)
        {
            this.FilterTextBox.Text = string.Empty;
            this.RefreshInventoryList();
        }

        /// <summary>
        /// The function that handles opening a file and filling the inventory list with the data from the file.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*";
                openFileDialog.Title = "Select a CSV File";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);
                        string directoryPath = Path.GetDirectoryName(openFileDialog.FileName);
                        this.logPath = $"{directoryPath}/inventory_log_{DateTime.Today.Month}_{DateTime.Today.Day}_{DateTime.Today.Year}.log";
                        foreach (string line in lines)
                        {
                            string[] fields = line.Split(',');
                            if (fields.Length >= 3)
                            {
                                string type = fields[0].Trim();
                                string name = fields[1].Trim();
                                if (int.TryParse(fields[2].Trim(), out int quantity))
                                {
                                    inventoryList.AddItem(type, name, quantity);
                                }
                                else
                                {
                                    MessageBox.Show($"Invalid quantity for item '{name}'. Skipping this item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show($"Invalid format in line: {line}. Skipping this line.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }

                        RefreshInventoryList();
                        this.UpdateListButton.Enabled = true;
                        this.PreviewButton.Enabled = true;
                        this.PrintButton.Enabled = true;
                        MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} opened local file {openFileDialog.FileName}.", logPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// The function that runs the save file function when clicked.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            this.SaveFileFunction();
        }

        /// <summary>
        /// The save file function.
        /// </summary>
        private void SaveFileFunction()
        {
            try
            {
                using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
                {
                    saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                    saveFileDialog1.Title = "Save Inventory CSV File";
                    saveFileDialog1.DefaultExt = "csv";
                    saveFileDialog1.Filter = "CSV Files|*.csv";
                    saveFileDialog1.RestoreDirectory = true;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK || saveFileDialog1.FileName != "") ;
                    {
                        using (var writer = new StreamWriter(saveFileDialog1.FileName))
                        {
                            var allitems = this.inventoryList.GetAllItems();
                            foreach (var item in allitems)
                            {
                                writer.WriteLine($"{item.Type},{item.Name},{item.Quantity}");
                            }
                        }
                    }
                    string directoryPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                    this.logPath = $"{directoryPath}/inventory_log_{DateTime.Today.Month}_{DateTime.Today.Day}_{DateTime.Today.Year}.log";
                    Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} saved local file {saveFileDialog1.FileName}.", logPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The function that handles adding an inventory item to the list.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            // Show the AddInventoryItemForm and pass the inventoryList instance
            using (AddInventoryItemForm addItemForm = new AddInventoryItemForm(inventoryList, this.logPath))
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshInventoryList();
                }
            }
        }

        /// <summary>
        /// The function that handles refreshing the display list with the data from the inventory list.
        /// </summary>
        private void RefreshInventoryList()
        {
            // Clear existing items in the list box
            InventoryDisplayList.Items.Clear();

            // Retrieve all items from the inventoryList
            var allItems = inventoryList.GetAllItems();

            var sortedItems = allItems.OrderBy(x => x.Type).ThenBy(x => x.Name);

            // Add each item to the list box
            foreach (var item in sortedItems)
            {
                InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
            }
        }

        /// <summary>
        /// The function that updates an item.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void UpdateInventoryButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list box
            if (InventoryDisplayList.SelectedItem != null)
            {
                // Retrieve the selected item from the list box
                string? selectedItem = InventoryDisplayList.SelectedItem?.ToString();

                // Check if selectedItem is not null
                if (selectedItem != null)
                {
                    // Extract the item name from the selected item string
                    string itemName = selectedItem.Split('-')[1].Trim();

                    // Find the item in the inventory list
                    InventoryItems? selectedItemToUpdate = inventoryList.GetItemByName(itemName);

                    // Check if selectedItemToUpdate is not null
                    if (selectedItemToUpdate != null)
                    {
                        // Create an instance of the update form
                        using (UpdateInventoryItemForm updateForm = new UpdateInventoryItemForm(selectedItemToUpdate, this.logPath))
                        {
                            // Show the update form as a dialog
                            if (updateForm.ShowDialog() == DialogResult.OK)
                            {
                                RefreshInventoryList();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the inventory list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The function that removes an inventory item from the inventory list.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void RemoveInventoryButton_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the list box
            if (InventoryDisplayList.SelectedItem != null)
            {
                // Retrieve the selected item from the list box
                string? selectedItem = InventoryDisplayList.SelectedItem?.ToString();

                // Check if selectedItem is not null
                if (selectedItem != null)
                {
                    // Extract the item name from the selected item string
                    string itemName = selectedItem.Split('-')[1].Trim(); // Changed index from 0 to 1

                    // Find the item in the inventory list
                    InventoryItems? itemToRemove = inventoryList.GetItemByName(itemName);

                    // Check if itemToRemove is not null
                    if (itemToRemove != null)
                    {
                        // Ask for confirmation before removing the item
                        DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // If the user confirms the removal
                        if (result == DialogResult.Yes)
                        {
                            Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} Removed item {itemToRemove.Type}, {itemToRemove.Name}, {itemToRemove.Quantity}", this.logPath);
                            // Remove the item from the inventory list
                            inventoryList.RemoveItem(itemToRemove);
                            RefreshInventoryList();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item not found in the inventory list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The function that handles either printing or previewing a page of the data.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            this.ypos = 100;
            this.pageCounter = 0;
            this.listCount = this.InventoryDisplayList.Items.Count;
            e.Graphics.DrawString("Type - Name and Description -- Quantity", new Font("Times New Roman", 20, FontStyle.Bold), Brushes.Black, 100, this.ypos);
            this.ypos += 35;
            while (this.listPosition < this.listCount && this.pageCounter < 35)
            {
                e.Graphics.DrawString(this.InventoryDisplayList.Items[this.listPosition].ToString(), new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, 100, this.ypos);
                this.pageCounter++;
                this.listPosition++;
                this.ypos += 25;

            }
            e.HasMorePages = this.listPosition < this.listCount;
        }

        /// <summary>
        /// The button that prints the data.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void PrintButton_Click_1(object sender, EventArgs e)
        {
            this.listPosition = 0;
            this.previewDlg = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            pd.Print();
            Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} printed file on {DateTime.Now}", logPath);
        }

        /// <summary>
        /// The button that previews the data to be printed.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void printPreviewButton_click(object sender, EventArgs e)
        {
            this.listPosition = 0;
            this.previewDlg = new PrintPreviewDialog();
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            this.previewDlg.Document = pd;
            this.previewDlg.ShowDialog();
        }

        /// <summary>
        /// Clears the inventory list and saves a new file.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void NewFileButton_Click(object sender, EventArgs e)
        {
            this.inventoryList.Clear();
            this.RefreshInventoryList();
            this.UpdateListButton.Enabled = true;
            this.PrintButton.Enabled = true;
            this.PreviewButton.Enabled = true;
            this.SaveFileFunction();
        }
    }
}