namespace FoodPantryApp
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
            pictureBox1 = new PictureBox();
            AmountLabel = new Label();
            TypeLabel = new Label();
            FoodLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Location = new Point(196, 222);
            ItemNameTextBox.Margin = new Padding(2);
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(212, 27);
            ItemNameTextBox.TabIndex = 1;
            // 
            // ItemQuantityTextBox
            // 
            ItemQuantityTextBox.Location = new Point(424, 222);
            ItemQuantityTextBox.Margin = new Padding(2);
            ItemQuantityTextBox.Name = "ItemQuantityTextBox";
            ItemQuantityTextBox.Size = new Size(121, 27);
            ItemQuantityTextBox.TabIndex = 2;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(158, 281);
            SubmitButton.Margin = new Padding(2);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(140, 57);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // CancelFormButton
            // 
            CancelFormButton.Location = new Point(302, 281);
            CancelFormButton.Margin = new Padding(2);
            CancelFormButton.Name = "CancelFormButton";
            CancelFormButton.Size = new Size(140, 57);
            CancelFormButton.TabIndex = 4;
            CancelFormButton.Text = "Cancel";
            CancelFormButton.UseVisualStyleBackColor = true;
            CancelFormButton.Click += CancelButton_Click;
            // 
            // ItemTypeTextBox
            // 
            ItemTypeTextBox.Location = new Point(60, 222);
            ItemTypeTextBox.Margin = new Padding(2);
            ItemTypeTextBox.Name = "ItemTypeTextBox";
            ItemTypeTextBox.Size = new Size(121, 27);
            ItemTypeTextBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Secondary_NWACC_Food_Pantry_Black_;
            pictureBox1.Location = new Point(-9, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 13F);
            AmountLabel.Location = new Point(439, 190);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(90, 30);
            AmountLabel.TabIndex = 11;
            AmountLabel.Text = "Amount";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 13F);
            TypeLabel.Location = new Point(210, 190);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(189, 30);
            TypeLabel.TabIndex = 10;
            TypeLabel.Text = "Name/Description";
            // 
            // FoodLabel
            // 
            FoodLabel.AutoSize = true;
            FoodLabel.Font = new Font("Segoe UI", 13F);
            FoodLabel.Location = new Point(70, 190);
            FoodLabel.Name = "FoodLabel";
            FoodLabel.Size = new Size(102, 30);
            FoodLabel.TabIndex = 9;
            FoodLabel.Text = "Category";
            // 
            // AddInventoryItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(pictureBox1);
            Controls.Add(AmountLabel);
            Controls.Add(TypeLabel);
            Controls.Add(FoodLabel);
            Controls.Add(ItemTypeTextBox);
            Controls.Add(CancelFormButton);
            Controls.Add(SubmitButton);
            Controls.Add(ItemQuantityTextBox);
            Controls.Add(ItemNameTextBox);
            Margin = new Padding(2);
            Name = "AddInventoryItemForm";
            Text = "AddInventoryItemForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label AmountLabel;
        private Label TypeLabel;
        private Label FoodLabel;
    }
}