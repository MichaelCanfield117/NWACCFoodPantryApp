// UpdateInventoryItemForm.cs

namespace FoodPantryApp
{
    /// <summary>
    /// The update inventory item form.
    /// </summary>
    public partial class UpdateInventoryItemForm : Form
    {
        /// <summary>
        /// The selected item to update.
        /// </summary>
        private InventoryItems selectedItemToUpdate;

        /// <summary>
        /// The log_path for logging.
        /// </summary>
        private string log_path = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateInventoryItemForm"/> class.
        /// </summary>
        /// <param name="selectedItem">
        /// The selected item.
        /// </param>
        /// <param name="logPath">
        /// The log path.
        /// </param>
        public UpdateInventoryItemForm(InventoryItems selectedItem, string logPath)
        {
            InitializeComponent();
            selectedItemToUpdate = selectedItem;
            this.log_path = logPath;
            // Pre-fill the form fields with the details of the item to update
            ItemTypeTextBox2.Text = selectedItemToUpdate.Type;
            ItemNameTextBox2.Text = selectedItemToUpdate.Name;
            ItemQuantityTextBox2.Text = selectedItemToUpdate.Quantity.ToString();
        }

        /// <summary>
        /// The function that handles submitting the updated data and closing the UpdateInventoryForm.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before updating the item
            DialogResult result = MessageBox.Show("Are you sure you want to update this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(ItemTypeTextBox2.Text) ||
                    string.IsNullOrWhiteSpace(ItemNameTextBox2.Text) ||
                    !int.TryParse(ItemQuantityTextBox2.Text, out int quantity))
                {
                    MessageBox.Show("Please enter valid data for item type, name, and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update the item properties
                Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} updated item from {this.selectedItemToUpdate.Type}, {this.selectedItemToUpdate.Name}, {this.selectedItemToUpdate.Quantity}.", this.log_path);
                selectedItemToUpdate.Type = ItemTypeTextBox2.Text;
                selectedItemToUpdate.Name = ItemNameTextBox2.Text;
                selectedItemToUpdate.Quantity = quantity;
                Logger.WriteLog($"{System.Security.Principal.WindowsIdentity.GetCurrent().Name} updated item to {this.selectedItemToUpdate.Type}, {this.selectedItemToUpdate.Name}, {this.selectedItemToUpdate.Quantity}.", this.log_path);

                // Close the form with DialogResult.OK
                DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// The cancel button function that closes the UpdateInventoryForm without submitting data.
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