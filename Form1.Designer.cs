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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            PreviewButton = new Button();
            TypeLabel = new Label();
            NameDescriptionLabel = new Label();
            QuantityLabel = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            PrintButton = new Button();
            printDialog1 = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)TitlePictureBox).BeginInit();
            SuspendLayout();
            // 
            // InventoryDisplayList
            // 
            InventoryDisplayList.Font = new Font("Segoe UI", 12F);
            InventoryDisplayList.FormattingEnabled = true;
            InventoryDisplayList.ItemHeight = 28;
            InventoryDisplayList.Location = new Point(12, 227);
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
            AddInventoryItem.Location = new Point(517, 401);
            AddInventoryItem.Name = "AddInventoryItem";
            AddInventoryItem.Size = new Size(324, 97);
            AddInventoryItem.TabIndex = 10;
            AddInventoryItem.Text = "Add Inventory Item";
            AddInventoryItem.UseVisualStyleBackColor = true;
            AddInventoryItem.Click += AddInventoryButton_Click;
            // 
            // UpdateInventoryButton
            // 
            UpdateInventoryButton.Font = new Font("Segoe UI", 16F);
            UpdateInventoryButton.Location = new Point(517, 306);
            UpdateInventoryButton.Name = "UpdateInventoryButton";
            UpdateInventoryButton.Size = new Size(324, 89);
            UpdateInventoryButton.TabIndex = 11;
            UpdateInventoryButton.Text = "Update Inventory Item";
            UpdateInventoryButton.UseVisualStyleBackColor = true;
            UpdateInventoryButton.Click += UpdateInventoryButton_Click;
            // 
            // RemoveInventoryButton
            // 
            RemoveInventoryButton.Font = new Font("Segoe UI", 16F);
            RemoveInventoryButton.Location = new Point(517, 504);
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
            UpdateListButton.Location = new Point(517, 635);
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
            OpenFileButton.Size = new Size(324, 102);
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
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // PreviewButton
            // 
            PreviewButton.Enabled = false;
            PreviewButton.Font = new Font("Segoe UI", 14F);
            PreviewButton.Location = new Point(517, 743);
            PreviewButton.Name = "PreviewButton";
            PreviewButton.Size = new Size(149, 104);
            PreviewButton.TabIndex = 20;
            PreviewButton.Text = "Print Preview";
            PreviewButton.UseVisualStyleBackColor = true;
            PreviewButton.Click += printPreviewButton_click;
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Font = new Font("Segoe UI", 12F);
            TypeLabel.Location = new Point(12, 196);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(53, 28);
            TypeLabel.TabIndex = 17;
            TypeLabel.Text = "Type";
            // 
            // NameDescriptionLabel
            // 
            NameDescriptionLabel.AutoSize = true;
            NameDescriptionLabel.Font = new Font("Segoe UI", 12F);
            NameDescriptionLabel.Location = new Point(88, 196);
            NameDescriptionLabel.Name = "NameDescriptionLabel";
            NameDescriptionLabel.Size = new Size(207, 28);
            NameDescriptionLabel.TabIndex = 18;
            NameDescriptionLabel.Text = "Name and Description";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 12F);
            QuantityLabel.Location = new Point(315, 196);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(88, 28);
            QuantityLabel.TabIndex = 19;
            QuantityLabel.Text = "Quantity";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // PrintButton
            // 
            PrintButton.Enabled = false;
            PrintButton.Font = new Font("Segoe UI", 15F);
            PrintButton.Location = new Point(672, 743);
            PrintButton.Name = "PrintButton";
            PrintButton.Size = new Size(169, 104);
            PrintButton.TabIndex = 21;
            PrintButton.Text = "Print";
            PrintButton.UseVisualStyleBackColor = true;
            PrintButton.Click += PrintButton_Click_1;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 853);
            Controls.Add(PrintButton);
            Controls.Add(PreviewButton);
            Controls.Add(QuantityLabel);
            Controls.Add(NameDescriptionLabel);
            Controls.Add(TypeLabel);
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
            StartPosition = FormStartPosition.CenterScreen;
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button PreviewButton;
        private Label TypeLabel;
        private Label NameDescriptionLabel;
        private Label QuantityLabel;
        private PrintPreviewDialog printPreviewDialog1;
        private Button PrintButton;
        private PrintDialog printDialog1;
    }
}
