// AddInventoryItemForm.cs

namespace FoodPantryApp
{
    /// <summary>
    /// The add inventory item form.
    /// </summary>
    public partial class AddInventoryItemForm : Form
    {
        /// <summary>
        /// The inventory list.
        /// </summary>
        private InventoryList inventoryList;

        /// <summary>
        /// The log path for logging.
        /// </summary>
        private string logPath = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddInventoryItemForm"/> class.
        /// </summary>
        /// <param name="inventoryList">
        /// The inventory list.
        /// </param>
        /// <param name="logPath">
        /// The log path.
        /// </param>
        public AddInventoryItemForm(InventoryList inventoryList, string logPath)
        {
            InitializeComponent();
            this.inventoryList = inventoryList;
            this.logPath = logPath;
        }

        /// <summary>
        /// The function that adds a new item to the inventory list and closes the AddInventoryItemForm.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
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
                Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} added item {newItem.Type}, {newItem.Name}, {newItem.Quantity} to list.", this.logPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// The cancel button function that closes the AddInventoryForm without submitting any data.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the form without making any changes
            DialogResult = DialogResult.Cancel;
        }
    }
}