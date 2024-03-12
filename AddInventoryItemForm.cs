// AddInventoryItemForm.cs

namespace FoodPantryApp
{
    public partial class AddInventoryItemForm : Form
    {
        private InventoryList inventoryList;

        public AddInventoryItemForm(InventoryList inventoryList)
        {
            InitializeComponent();
            this.inventoryList = inventoryList;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(ItemNameTextBox.Text))
            {
                MessageBox.Show("Please enter an item name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(ItemTypeTextBox.Text))
            {
                MessageBox.Show("Please enter an item type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(ItemQuantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new InventoryItems object with the input values
            InventoryItems newItem = new InventoryItems(ItemTypeTextBox.Text, ItemNameTextBox.Text, quantity);

            try
            {
                // Add the new item to the inventory list
                inventoryList.AddItem(newItem.Type, newItem.Name, newItem.Quantity);
                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the form with DialogResult.OK
                DialogResult = DialogResult.OK;
                Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} added item {newItem.Type}, {newItem.Name}, {newItem.Quantity} to list.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the form without making any changes
            DialogResult = DialogResult.Cancel;
        }
    }
}