namespace FoodPantryApp
{
    public partial class MainForm : Form
    {
        private InventoryList inventoryList;

        public MainForm()
        {
            InitializeComponent();
            inventoryList = new InventoryList();
            RefreshInventoryList();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private void ResetListButton_Click(object sender, EventArgs e)
        {

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
                InventoryDisplayList.Items.Add(item.Name + " -- " + item.Quantity);
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
                    string itemName = selectedItem.Split('-')[0].Trim();

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
                    string itemName = selectedItem.Split('-')[0].Trim();

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