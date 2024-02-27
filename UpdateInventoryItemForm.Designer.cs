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
            FoodLabel = new Label();
            TypeLabel = new Label();
            AmountLabel = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ItemNameTextBox2
            // 
            ItemNameTextBox2.Location = new Point(204, 189);
            ItemNameTextBox2.Margin = new Padding(2, 2, 2, 2);
            ItemNameTextBox2.Name = "ItemNameTextBox2";
            ItemNameTextBox2.Size = new Size(207, 27);
            ItemNameTextBox2.TabIndex = 1;
            // 
            // SubmitButton2
            // 
            SubmitButton2.Location = new Point(131, 246);
            SubmitButton2.Margin = new Padding(2, 2, 2, 2);
            SubmitButton2.Name = "SubmitButton2";
            SubmitButton2.Size = new Size(156, 58);
            SubmitButton2.TabIndex = 3;
            SubmitButton2.Text = "Submit";
            SubmitButton2.UseVisualStyleBackColor = true;
            SubmitButton2.Click += SubmitButton_Click;
            // 
            // CancelButton2
            // 
            CancelButton2.Location = new Point(321, 246);
            CancelButton2.Margin = new Padding(2, 2, 2, 2);
            CancelButton2.Name = "CancelButton2";
            CancelButton2.Size = new Size(156, 58);
            CancelButton2.TabIndex = 4;
            CancelButton2.Text = "Cancel";
            CancelButton2.UseVisualStyleBackColor = true;
            CancelButton2.Click += CancelButton_Click;
            // 
            // ItemQuantityTextBox2
            // 
            ItemQuantityTextBox2.Location = new Point(437, 189);
            ItemQuantityTextBox2.Margin = new Padding(2, 2, 2, 2);
            ItemQuantityTextBox2.Name = "ItemQuantityTextBox2";
            ItemQuantityTextBox2.Size = new Size(118, 27);
            ItemQuantityTextBox2.TabIndex = 2;
            // 
            // ItemTypeTextBox2
            // 
            ItemTypeTextBox2.Location = new Point(45, 189);
            ItemTypeTextBox2.Margin = new Padding(2, 2, 2, 2);
            ItemTypeTextBox2.Name = "ItemTypeTextBox2";
            ItemTypeTextBox2.Size = new Size(121, 27);
            ItemTypeTextBox2.TabIndex = 0;
            // 
            // FoodLabel
            // 
            FoodLabel.AutoSize = true;
            FoodLabel.Font = new Font("Segoe UI", 13F);
            FoodLabel.Location = new Point(73, 157);
            FoodLabel.Name = "FoodLabel";
            FoodLabel.Size = new Size(63, 30);
            FoodLabel.TabIndex = 5;
            FoodLabel.Text = "Food";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 13F);
            TypeLabel.Location = new Point(252, 157);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(116, 30);
            TypeLabel.TabIndex = 6;
            TypeLabel.Text = "Food Type";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 13F);
            AmountLabel.Location = new Point(437, 157);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(90, 30);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "Amount";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Secondary_NWACC_Food_Pantry_Black_;
            pictureBox1.Location = new Point(-8, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(659, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // UpdateInventoryItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(pictureBox1);
            Controls.Add(AmountLabel);
            Controls.Add(TypeLabel);
            Controls.Add(FoodLabel);
            Controls.Add(ItemTypeTextBox2);
            Controls.Add(ItemQuantityTextBox2);
            Controls.Add(CancelButton2);
            Controls.Add(SubmitButton2);
            Controls.Add(ItemNameTextBox2);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UpdateInventoryItemForm";
            Text = "UpdateInventoryItemForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemNameTextBox2;
        private Button SubmitButton2;
        private Button CancelButton2;
        private TextBox ItemQuantityTextBox2;
        private TextBox ItemTypeTextBox2;
        private Label FoodLabel;
        private Label TypeLabel;
        private Label AmountLabel;
        private PictureBox pictureBox1;
    }
}