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
            StatusLabel = new Label();
            StatusDisplay = new Label();
            InventoryDisplayList = new ListBox();
            FilterTextBox = new TextBox();
            FilterButton = new Button();
            TitlePictureBox = new PictureBox();
            FoodTypeCheckBox = new CheckBox();
            FoodCategoryCheckBox = new CheckBox();
            AddInventoryItem = new Button();
            UpdateInventoryButton = new Button();
            RemoveInventoryButton = new Button();
            ResetListButton = new Button();
            UpdateListButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).BeginInit();
            SuspendLayout();
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 14F);
            StatusLabel.Location = new Point(238, 992);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(97, 38);
            StatusLabel.TabIndex = 0;
            StatusLabel.Text = "Status:";
            // 
            // StatusDisplay
            // 
            StatusDisplay.AutoSize = true;
            StatusDisplay.Font = new Font("Segoe UI", 14F);
            StatusDisplay.Location = new Point(349, 992);
            StatusDisplay.Margin = new Padding(4, 0, 4, 0);
            StatusDisplay.Name = "StatusDisplay";
            StatusDisplay.Size = new Size(133, 38);
            StatusDisplay.TabIndex = 1;
            StatusDisplay.Text = "Loading...";
            // 
            // InventoryDisplayList
            // 
            InventoryDisplayList.Font = new Font("Segoe UI", 12F);
            InventoryDisplayList.FormattingEnabled = true;
            InventoryDisplayList.ItemHeight = 32;
            InventoryDisplayList.Location = new Point(15, 249);
            InventoryDisplayList.Margin = new Padding(4, 4, 4, 4);
            InventoryDisplayList.Name = "InventoryDisplayList";
            InventoryDisplayList.Size = new Size(623, 708);
            InventoryDisplayList.TabIndex = 2;
            // 
            // FilterTextBox
            // 
            FilterTextBox.Font = new Font("Segoe UI", 12F);
            FilterTextBox.Location = new Point(160, 195);
            FilterTextBox.Margin = new Padding(4, 4, 4, 4);
            FilterTextBox.Name = "FilterTextBox";
            FilterTextBox.Size = new Size(455, 39);
            FilterTextBox.TabIndex = 3;
            // 
            // FilterButton
            // 
            FilterButton.Font = new Font("Segoe UI", 12F);
            FilterButton.Location = new Point(15, 190);
            FilterButton.Margin = new Padding(4, 4, 4, 4);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(138, 52);
            FilterButton.TabIndex = 6;
            FilterButton.Text = "Filter List";
            FilterButton.UseVisualStyleBackColor = true;
            FilterButton.Click += FilterButton_Click;
            // 
            // TitlePictureBox
            // 
            TitlePictureBox.Image = Properties.Resources.Primary_Food_Pantry_Color;
            TitlePictureBox.Location = new Point(-4, 0);
            TitlePictureBox.Margin = new Padding(4, 4, 4, 4);
            TitlePictureBox.Name = "TitlePictureBox";
            TitlePictureBox.Size = new Size(1092, 182);
            TitlePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TitlePictureBox.TabIndex = 7;
            TitlePictureBox.TabStop = false;
            // 
            // FoodTypeCheckBox
            // 
            FoodTypeCheckBox.AutoSize = true;
            FoodTypeCheckBox.Location = new Point(624, 202);
            FoodTypeCheckBox.Margin = new Padding(4, 4, 4, 4);
            FoodTypeCheckBox.Name = "FoodTypeCheckBox";
            FoodTypeCheckBox.Size = new Size(122, 29);
            FoodTypeCheckBox.TabIndex = 8;
            FoodTypeCheckBox.Text = "Food Type";
            FoodTypeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FoodCategoryCheckBox
            // 
            FoodCategoryCheckBox.AutoSize = true;
            FoodCategoryCheckBox.Location = new Point(758, 202);
            FoodCategoryCheckBox.Margin = new Padding(4, 4, 4, 4);
            FoodCategoryCheckBox.Name = "FoodCategoryCheckBox";
            FoodCategoryCheckBox.Size = new Size(157, 29);
            FoodCategoryCheckBox.TabIndex = 9;
            FoodCategoryCheckBox.Text = "Food Category";
            FoodCategoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddInventoryItem
            // 
            AddInventoryItem.Font = new Font("Segoe UI", 16F);
            AddInventoryItem.Location = new Point(646, 501);
            AddInventoryItem.Margin = new Padding(4, 4, 4, 4);
            AddInventoryItem.Name = "AddInventoryItem";
            AddInventoryItem.Size = new Size(405, 156);
            AddInventoryItem.TabIndex = 10;
            AddInventoryItem.Text = "Add Inventory Item";
            AddInventoryItem.UseVisualStyleBackColor = true;
            AddInventoryItem.Click += AddInventoryButton_Click;
            // 
            // UpdateInventoryButton
            // 
            UpdateInventoryButton.Font = new Font("Segoe UI", 16F);
            UpdateInventoryButton.Location = new Point(646, 338);
            UpdateInventoryButton.Margin = new Padding(4, 4, 4, 4);
            UpdateInventoryButton.Name = "UpdateInventoryButton";
            UpdateInventoryButton.Size = new Size(405, 156);
            UpdateInventoryButton.TabIndex = 11;
            UpdateInventoryButton.Text = "Update Inventory Item";
            UpdateInventoryButton.UseVisualStyleBackColor = true;
            UpdateInventoryButton.Click += UpdateInventoryButton_Click;
            // 
            // RemoveInventoryButton
            // 
            RemoveInventoryButton.Font = new Font("Segoe UI", 16F);
            RemoveInventoryButton.Location = new Point(646, 665);
            RemoveInventoryButton.Margin = new Padding(4, 4, 4, 4);
            RemoveInventoryButton.Name = "RemoveInventoryButton";
            RemoveInventoryButton.Size = new Size(405, 156);
            RemoveInventoryButton.TabIndex = 12;
            RemoveInventoryButton.Text = "Remove Inventory Item";
            RemoveInventoryButton.UseVisualStyleBackColor = true;
            RemoveInventoryButton.Click += RemoveInventoryButton_Click;
            // 
            // ResetListButton
            // 
            ResetListButton.Location = new Point(646, 245);
            ResetListButton.Margin = new Padding(4, 4, 4, 4);
            ResetListButton.Name = "ResetListButton";
            ResetListButton.Size = new Size(295, 85);
            ResetListButton.TabIndex = 13;
            ResetListButton.Text = "Reset List";
            ResetListButton.UseVisualStyleBackColor = true;
            ResetListButton.Click += ResetListButton_Click;
            // 
            // UpdateListButton
            // 
            UpdateListButton.Font = new Font("Segoe UI", 14F);
            UpdateListButton.Location = new Point(646, 829);
            UpdateListButton.Margin = new Padding(4, 4, 4, 4);
            UpdateListButton.Name = "UpdateListButton";
            UpdateListButton.Size = new Size(405, 156);
            UpdateListButton.TabIndex = 14;
            UpdateListButton.Text = "Update Inventory List";
            UpdateListButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 1050);
            Controls.Add(UpdateListButton);
            Controls.Add(ResetListButton);
            Controls.Add(RemoveInventoryButton);
            Controls.Add(UpdateInventoryButton);
            Controls.Add(AddInventoryItem);
            Controls.Add(FoodCategoryCheckBox);
            Controls.Add(FoodTypeCheckBox);
            Controls.Add(TitlePictureBox);
            Controls.Add(FilterButton);
            Controls.Add(FilterTextBox);
            Controls.Add(InventoryDisplayList);
            Controls.Add(StatusDisplay);
            Controls.Add(StatusLabel);
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainForm";
            Text = "Food Pantry Inventory";
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StatusLabel;
        private Label StatusDisplay;
        private ListBox InventoryDisplayList;
        private TextBox FilterTextBox;

        public PictureBox TitlePitctureBox { get; private set; }

        private Button FilterButton;
        private PictureBox TitlePictureBox;
        private CheckBox FoodTypeCheckBox;
        private CheckBox FoodCategoryCheckBox;
        private Button AddInventoryItem;
        private Button UpdateInventoryButton;
        private Button RemoveInventoryButton;
        private Button ResetListButton;
        private Button UpdateListButton;
    }
}
