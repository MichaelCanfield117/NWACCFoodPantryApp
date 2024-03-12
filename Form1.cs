// Form1.cs

using System.Windows.Forms;

namespace FoodPantryApp
{
    public partial class MainForm : Form
    {
        private InventoryList inventoryList;

        private List<string> FilterList = new List<string>();

        public MainForm()
        {
            this.InitializeComponent();
            this.inventoryList = new InventoryList();
            this.FillFilterList();
            this.RefreshInventoryList();
            this.UpdateListButton.Enabled = false;
            Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} started application. ");
        }

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

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filterInput = this.FilterTextBox.Text;
            var filterCheck = this.FilterCheckBoxCheck();
            if (this.inventoryList.Count > 0)
            {
                var items = this.inventoryList.GetAllItems();
                this.InventoryDisplayList.Items.Clear();
                foreach (var item in items)
                {
                    if (filterCheck == 0)
                    {
                        if (item.Type.Contains(filterInput))
                        {
                            InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
                        }
                    }
                    else if (filterCheck == 1)
                    {
                        if (item.Name.Contains(filterInput))
                        {
                            InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
                        }
                    }
                    else if (filterCheck == 2)
                    {
                        var value = int.TryParse(filterInput, out int result);
                        if (value)
                        {
                            if (item.Quantity <= result)
                            {
                                InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
                            }
                        }
                    }
                }
            }
        }

        private int FilterCheckBoxCheck()
        {
            var filterNum = this.FilterComboBox.SelectedIndex;
            return filterNum;
        }

        private void ResetListButton_Click(object sender, EventArgs e)
        {
            this.FilterTextBox.Text = string.Empty;
            this.RefreshInventoryList();
        }

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
                        MessageBox.Show("File loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} opened local file {openFileDialog.FileName}.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
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
                    Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} saved local file {saveFileDialog1.FileName}.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddInventoryButton_Click(object sender, EventArgs e)
        {
            // Show the AddInventoryItemForm and pass the inventoryList instance
            using (AddInventoryItemForm addItemForm = new AddInventoryItemForm(inventoryList))
            {
                if (addItemForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshInventoryList();
                }
            }
        }

        private void RefreshInventoryList()
        {
            // Clear existing items in the list box
            InventoryDisplayList.Items.Clear();

            // Retrieve all items from the inventoryList
            var allItems = inventoryList.GetAllItems();

            // Add each item to the list box
            foreach (var item in allItems)
            {
                InventoryDisplayList.Items.Add($"{item.Type} - {item.Name} -- {item.Quantity}");
            }
        }

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
                        using (UpdateInventoryItemForm updateForm = new UpdateInventoryItemForm(selectedItemToUpdate))
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
                            Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} Removed item {itemToRemove.Type}, {itemToRemove.Name}, {itemToRemove.Quantity}");
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
    }
}