namespace FoodPantryApp
{
    partial class UpdateInventoryItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ItemNameTextBox2 = new TextBox();
            SubmitButton2 = new Button();
            CancelButton2 = new Button();
            ItemQuantityTextBox2 = new TextBox();
            ItemTypeTextBox2 = new TextBox();
            SuspendLayout();
            // 
            // ItemNameTextBox2
            // 
            ItemNameTextBox2.Location = new Point(244, 108);
            ItemNameTextBox2.Name = "ItemNameTextBox2";
            ItemNameTextBox2.Size = new Size(258, 31);
            ItemNameTextBox2.TabIndex = 1;
            // 
            // SubmitButton2
            // 
            SubmitButton2.Location = new Point(211, 173);
            SubmitButton2.Name = "SubmitButton2";
            SubmitButton2.Size = new Size(112, 34);
            SubmitButton2.TabIndex = 3;
            SubmitButton2.Text = "Submit";
            SubmitButton2.UseVisualStyleBackColor = true;
            SubmitButton2.Click += SubmitButton_Click;
            // 
            // CancelButton2
            // 
            CancelButton2.Location = new Point(434, 173);
            CancelButton2.Name = "CancelButton2";
            CancelButton2.Size = new Size(112, 34);
            CancelButton2.TabIndex = 4;
            CancelButton2.Text = "Cancel";
            CancelButton2.UseVisualStyleBackColor = true;
            CancelButton2.Click += CancelButton_Click;
            // 
            // ItemQuantityTextBox2
            // 
            ItemQuantityTextBox2.Location = new Point(530, 108);
            ItemQuantityTextBox2.Name = "ItemQuantityTextBox2";
            ItemQuantityTextBox2.Size = new Size(146, 31);
            ItemQuantityTextBox2.TabIndex = 2;
            // 
            // ItemTypeTextBox2
            // 
            ItemTypeTextBox2.Location = new Point(67, 108);
            ItemTypeTextBox2.Name = "ItemTypeTextBox2";
            ItemTypeTextBox2.Size = new Size(150, 31);
            ItemTypeTextBox2.TabIndex = 0;
            // 
            // UpdateInventoryItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ItemTypeTextBox2);
            Controls.Add(ItemQuantityTextBox2);
            Controls.Add(CancelButton2);
            Controls.Add(SubmitButton2);
            Controls.Add(ItemNameTextBox2);
            Name = "UpdateInventoryItemForm";
            Text = "UpdateInventoryItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemNameTextBox2;
        private Button SubmitButton2;
        private Button CancelButton2;
        private TextBox ItemQuantityTextBox2;
        private TextBox ItemTypeTextBox2;
    }
}