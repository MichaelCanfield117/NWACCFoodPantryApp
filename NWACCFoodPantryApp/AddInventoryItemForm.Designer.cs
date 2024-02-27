﻿namespace FoodPantryApp
{
    partial class AddInventoryItemForm
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
            components = new System.ComponentModel.Container();
            ItemNameTextBox = new TextBox();
            ItemQuantityTextBox = new TextBox();
            SubmitButton = new Button();
            CancelFormButton = new Button();
            ItemTypeTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(241, 108);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(264, 31);
            ItemNameTextBox.TabIndex = 1;
            // 
            // ItemQuantityTextBox
            // 
            ItemQuantityTextBox.Location = new Point(529, 108);
            ItemQuantityTextBox.Name = "ItemQuantityTextBox";
            ItemQuantityTextBox.Size = new Size(150, 31);
            ItemQuantityTextBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(209, 168);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(112, 34);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CancelFormButton
            // 
            CancelFormButton.Location = new Point(426, 168);
            CancelFormButton.Name = "CancelFormButton";
            CancelFormButton.Size = new Size(112, 34);
            CancelFormButton.TabIndex = 4;
            CancelFormButton.Text = "Cancel";
            CancelFormButton.UseVisualStyleBackColor = true;
            CancelFormButton.Click += CancelButton_Click;
            // 
            // ItemTypeTextBox
            // 
            ItemTypeTextBox.Location = new Point(60, 108);
            ItemTypeTextBox.Name = "ItemTypeTextBox";
            ItemTypeTextBox.Size = new Size(150, 31);
            ItemTypeTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddInventoryItemForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ItemTypeTextBox);
            Controls.Add(CancelFormButton);
            Controls.Add(SubmitButton);
            Controls.Add(ItemQuantityTextBox);
            Controls.Add(ItemNameTextBox);
            Name = "AddInventoryItemForm";
            Text = "AddInventoryItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemNameTextBox;
        private TextBox ItemQuantityTextBox;
        private Button SubmitButton;
        private Button CancelFormButton;
        private TextBox ItemTypeTextBox;
        private ContextMenuStrip contextMenuStrip1;
    }
}