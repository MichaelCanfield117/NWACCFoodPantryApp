namespace FoodPantryApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InventoryDisplayList = new ListBox();
            FilterTextBox = new TextBox();
            FilterButton = new Button();
            TitlePictureBox = new PictureBox();
            AddInventoryItem = new Button();
            UpdateInventoryButton = new Button();
            RemoveInventoryButton = new Button();
            ResetListButton = new Button();
            UpdateListButton = new Button();
            OpenFileButton = new Button();
            FilterComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).BeginInit();
            SuspendLayout();
            // 
            // InventoryDisplayList
            // 
            InventoryDisplayList.Font = new Font("Segoe UI", 12F);
            InventoryDisplayList.FormattingEnabled = true;
            InventoryDisplayList.ItemHeight = 28;
            InventoryDisplayList.Location = new Point(12, 199);
            InventoryDisplayList.Name = "InventoryDisplayList";
            InventoryDisplayList.Size = new Size(499, 620);
            InventoryDisplayList.TabIndex = 2;
            // 
            // FilterTextBox
            // 
            FilterTextBox.Font = new Font("Segoe UI", 12F);
            FilterTextBox.Location = new Point(128, 156);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(365, 34);
            FilterTextBox.TabIndex = 3;
            // 
            // FilterButton
            // 
            FilterButton.Font = new Font("Segoe UI", 12F);
            FilterButton.Location = new Point(12, 152);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(110, 42);
            FilterButton.TabIndex = 6;
            FilterButton.Text = "Filter List";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // TitlePictureBox
            // 
            TitlePictureBox.Image = Properties.Resources.Primary_Food_Pantry_Color;
            TitlePictureBox.Location = new Point(-3, 0);
            TitlePictureBox.Name = "TitlePictureBox";
            TitlePictureBox.Size = new Size(874, 146);
            TitlePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TitlePictureBox.TabIndex = 7;
            TitlePictureBox.TabStop = false;
            // 
            // AddInventoryItem
            // 
            AddInventoryItem.Font = new Font("Segoe UI", 16F);
            AddInventoryItem.Location = new Point(517, 447);
            AddInventoryItem.Name = "AddInventoryItem";
            AddInventoryItem.Size = new Size(324, 125);
            AddInventoryItem.TabIndex = 10;
            AddInventoryItem.Text = "Add Inventory Item";
            AddInventoryItem.UseVisualStyleBackColor = true;
            AddInventoryItem.Click += AddInventoryButton_Click;
            // 
            // UpdateInventoryButton
            // 
            UpdateInventoryButton.Font = new Font("Segoe UI", 16F);
            UpdateInventoryButton.Location = new Point(517, 316);
            UpdateInventoryButton.Name = "UpdateInventoryButton";
            UpdateInventoryButton.Size = new Size(324, 125);
            UpdateInventoryButton.TabIndex = 11;
            UpdateInventoryButton.Text = "Update Inventory Item";
            UpdateInventoryButton.UseVisualStyleBackColor = true;
            UpdateInventoryButton.Click += UpdateInventoryButton_Click;
            // 
            // RemoveInventoryButton
            // 
            RemoveInventoryButton.Font = new Font("Segoe UI", 16F);
            RemoveInventoryButton.Location = new Point(517, 578);
            RemoveInventoryButton.Name = "RemoveInventoryButton";
            RemoveInventoryButton.Size = new Size(324, 125);
            RemoveInventoryButton.TabIndex = 12;
            RemoveInventoryButton.Text = "Remove Inventory Item";
            RemoveInventoryButton.UseVisualStyleBackColor = true;
            RemoveInventoryButton.Click += RemoveInventoryButton_Click;
            // 
            // ResetListButton
            // 
            ResetListButton.Location = new Point(672, 151);
            ResetListButton.Name = "ResetListButton";
            ResetListButton.Size = new Size(169, 43);
            ResetListButton.TabIndex = 13;
            ResetListButton.Text = "Reset List";
            ResetListButton.UseVisualStyleBackColor = true;
            ResetListButton.Click += ResetListButton_Click;
            // 
            // UpdateListButton
            // 
            UpdateListButton.Font = new Font("Segoe UI", 14F);
            UpdateListButton.Location = new Point(517, 709);
            UpdateListButton.Name = "UpdateListButton";
            UpdateListButton.Size = new Size(324, 102);
            UpdateListButton.TabIndex = 14;
            UpdateListButton.Text = "Save File";
            UpdateListButton.UseVisualStyleBackColor = true;
            UpdateListButton.Click += SaveFileButton_Click;
            // 
            // OpenFileButton
            // 
            OpenFileButton.Font = new Font("Segoe UI", 14F);
            OpenFileButton.Location = new Point(517, 199);
            OpenFileButton.Margin = new Padding(2);
            OpenFileButton.Name = "OpenFileButton";
            OpenFileButton.Size = new Size(324, 112);
            OpenFileButton.TabIndex = 15;
            OpenFileButton.Text = "Open File";
            OpenFileButton.UseVisualStyleBackColor = true;
            OpenFileButton.Click += OpenFileButton_Click;
            // 
            // FilterComboBox
            // 
            FilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(499, 160);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(167, 28);
            FilterComboBox.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 840);
            Controls.Add(FilterComboBox);
            Controls.Add(OpenFileButton);
            Controls.Add(UpdateListButton);
            Controls.Add(ResetListButton);
            Controls.Add(RemoveInventoryButton);
            Controls.Add(UpdateInventoryButton);
            Controls.Add(AddInventoryItem);
            Controls.Add(TitlePictureBox);
            Controls.Add(FilterButton);
            Controls.Add(FilterTextBox);
            Controls.Add(InventoryDisplayList);
            Name = "MainForm";
            Text = "Food Pantry Inventory";
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox InventoryDisplayList;
        private TextBox FilterTextBox;

        public PictureBox TitlePitctureBox { get; private set; }

        private Button FilterButton;
        private PictureBox TitlePictureBox;
        private Button AddInventoryItem;
        private Button UpdateInventoryButton;
        private Button RemoveInventoryButton;
        private Button ResetListButton;
        private Button UpdateListButton;
        private Button OpenFileButton;
        private ComboBox FilterComboBox;
    }
}
