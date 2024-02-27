﻿// UpdateInventoryItemForm.cs

namespace FoodPantryApp
{
    public partial class UpdateInventoryItemForm : Form
    {
        private InventoryItems selectedItemToUpdate;
        public UpdateInventoryItemForm(InventoryItems selectedItem)
        {
            InitializeComponent();
            selectedItemToUpdate = selectedItem;

            // Pre-fill the form fields with the details of the item to update
            ItemNameTextBox2.Text = selectedItemToUpdate.Name;
            ItemQuantityTextBox2.Text = selectedItemToUpdate.Quantity.ToString();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(ItemNameTextBox2.Text) || !int.TryParse(ItemQuantityTextBox2.Text, out int quantity))
            {
                MessageBox.Show("Please enter valid data for item name and quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the item properties
            selectedItemToUpdate.Name = ItemNameTextBox2.Text;
            selectedItemToUpdate.Quantity = quantity;

            // Close the form with DialogResult.OK
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the form without making any changes
            DialogResult = DialogResult.Cancel;
        }
    }
}