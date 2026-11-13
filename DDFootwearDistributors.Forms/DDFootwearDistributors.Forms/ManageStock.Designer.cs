namespace DDFootwearDistributors.Forms
{
    partial class ManageStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageStock));
            this.txtBoxProductId = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxProductName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxDescription = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtBoxRetailPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxWholesalePrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxCostPrice = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxProductId
            // 
            this.txtBoxProductId.AnimateReadOnly = false;
            this.txtBoxProductId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxProductId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxProductId.Depth = 0;
            this.txtBoxProductId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProductId.HideSelection = true;
            this.txtBoxProductId.Hint = "Product Id";
            this.txtBoxProductId.LeadingIcon = null;
            this.txtBoxProductId.Location = new System.Drawing.Point(177, 78);
            this.txtBoxProductId.MaxLength = 32767;
            this.txtBoxProductId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProductId.Name = "txtBoxProductId";
            this.txtBoxProductId.PasswordChar = '\0';
            this.txtBoxProductId.PrefixSuffixText = null;
            this.txtBoxProductId.ReadOnly = false;
            this.txtBoxProductId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxProductId.SelectedText = "";
            this.txtBoxProductId.SelectionLength = 0;
            this.txtBoxProductId.SelectionStart = 0;
            this.txtBoxProductId.ShortcutsEnabled = true;
            this.txtBoxProductId.Size = new System.Drawing.Size(234, 36);
            this.txtBoxProductId.TabIndex = 1;
            this.txtBoxProductId.TabStop = false;
            this.txtBoxProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxProductId.TrailingIcon = null;
            this.txtBoxProductId.UseSystemPasswordChar = false;
            this.txtBoxProductId.UseTallSize = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 131);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(234, 168);
            this.materialCard1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.AnimateReadOnly = false;
            this.txtBoxProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxProductName.Depth = 0;
            this.txtBoxProductName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProductName.HideSelection = true;
            this.txtBoxProductName.Hint = "Product Name";
            this.txtBoxProductName.LeadingIcon = null;
            this.txtBoxProductName.Location = new System.Drawing.Point(268, 131);
            this.txtBoxProductName.MaxLength = 32767;
            this.txtBoxProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.PasswordChar = '\0';
            this.txtBoxProductName.PrefixSuffixText = null;
            this.txtBoxProductName.ReadOnly = false;
            this.txtBoxProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxProductName.SelectedText = "";
            this.txtBoxProductName.SelectionLength = 0;
            this.txtBoxProductName.SelectionStart = 0;
            this.txtBoxProductName.ShortcutsEnabled = true;
            this.txtBoxProductName.Size = new System.Drawing.Size(474, 36);
            this.txtBoxProductName.TabIndex = 2;
            this.txtBoxProductName.TabStop = false;
            this.txtBoxProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxProductName.TrailingIcon = null;
            this.txtBoxProductName.UseSystemPasswordChar = false;
            this.txtBoxProductName.UseTallSize = false;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.AnimateReadOnly = false;
            this.txtBoxDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxDescription.Depth = 0;
            this.txtBoxDescription.HideSelection = true;
            this.txtBoxDescription.Hint = "Description";
            this.txtBoxDescription.Location = new System.Drawing.Point(508, 173);
            this.txtBoxDescription.MaxLength = 32767;
            this.txtBoxDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.PasswordChar = '\0';
            this.txtBoxDescription.ReadOnly = false;
            this.txtBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBoxDescription.SelectedText = "";
            this.txtBoxDescription.SelectionLength = 0;
            this.txtBoxDescription.SelectionStart = 0;
            this.txtBoxDescription.ShortcutsEnabled = true;
            this.txtBoxDescription.Size = new System.Drawing.Size(234, 80);
            this.txtBoxDescription.TabIndex = 5;
            this.txtBoxDescription.TabStop = false;
            this.txtBoxDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxDescription.UseSystemPasswordChar = false;
            // 
            // txtBoxRetailPrice
            // 
            this.txtBoxRetailPrice.AnimateReadOnly = false;
            this.txtBoxRetailPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxRetailPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxRetailPrice.Depth = 0;
            this.txtBoxRetailPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxRetailPrice.HideSelection = true;
            this.txtBoxRetailPrice.Hint = "Retail Price";
            this.txtBoxRetailPrice.LeadingIcon = null;
            this.txtBoxRetailPrice.Location = new System.Drawing.Point(268, 259);
            this.txtBoxRetailPrice.MaxLength = 32767;
            this.txtBoxRetailPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxRetailPrice.Name = "txtBoxRetailPrice";
            this.txtBoxRetailPrice.PasswordChar = '\0';
            this.txtBoxRetailPrice.PrefixSuffixText = null;
            this.txtBoxRetailPrice.ReadOnly = false;
            this.txtBoxRetailPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxRetailPrice.SelectedText = "";
            this.txtBoxRetailPrice.SelectionLength = 0;
            this.txtBoxRetailPrice.SelectionStart = 0;
            this.txtBoxRetailPrice.ShortcutsEnabled = true;
            this.txtBoxRetailPrice.Size = new System.Drawing.Size(234, 36);
            this.txtBoxRetailPrice.TabIndex = 6;
            this.txtBoxRetailPrice.TabStop = false;
            this.txtBoxRetailPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxRetailPrice.TrailingIcon = null;
            this.txtBoxRetailPrice.UseSystemPasswordChar = false;
            this.txtBoxRetailPrice.UseTallSize = false;
            // 
            // txtBoxWholesalePrice
            // 
            this.txtBoxWholesalePrice.AnimateReadOnly = false;
            this.txtBoxWholesalePrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxWholesalePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxWholesalePrice.Depth = 0;
            this.txtBoxWholesalePrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxWholesalePrice.HideSelection = true;
            this.txtBoxWholesalePrice.Hint = "Wholesale Price";
            this.txtBoxWholesalePrice.LeadingIcon = null;
            this.txtBoxWholesalePrice.Location = new System.Drawing.Point(508, 259);
            this.txtBoxWholesalePrice.MaxLength = 32767;
            this.txtBoxWholesalePrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxWholesalePrice.Name = "txtBoxWholesalePrice";
            this.txtBoxWholesalePrice.PasswordChar = '\0';
            this.txtBoxWholesalePrice.PrefixSuffixText = null;
            this.txtBoxWholesalePrice.ReadOnly = false;
            this.txtBoxWholesalePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxWholesalePrice.SelectedText = "";
            this.txtBoxWholesalePrice.SelectionLength = 0;
            this.txtBoxWholesalePrice.SelectionStart = 0;
            this.txtBoxWholesalePrice.ShortcutsEnabled = true;
            this.txtBoxWholesalePrice.Size = new System.Drawing.Size(234, 36);
            this.txtBoxWholesalePrice.TabIndex = 7;
            this.txtBoxWholesalePrice.TabStop = false;
            this.txtBoxWholesalePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxWholesalePrice.TrailingIcon = null;
            this.txtBoxWholesalePrice.UseSystemPasswordChar = false;
            this.txtBoxWholesalePrice.UseTallSize = false;
            // 
            // txtBoxCostPrice
            // 
            this.txtBoxCostPrice.AnimateReadOnly = false;
            this.txtBoxCostPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxCostPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxCostPrice.Depth = 0;
            this.txtBoxCostPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxCostPrice.HideSelection = true;
            this.txtBoxCostPrice.Hint = "Cost Price";
            this.txtBoxCostPrice.LeadingIcon = null;
            this.txtBoxCostPrice.Location = new System.Drawing.Point(268, 173);
            this.txtBoxCostPrice.MaxLength = 32767;
            this.txtBoxCostPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxCostPrice.Name = "txtBoxCostPrice";
            this.txtBoxCostPrice.PasswordChar = '\0';
            this.txtBoxCostPrice.PrefixSuffixText = null;
            this.txtBoxCostPrice.ReadOnly = false;
            this.txtBoxCostPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCostPrice.SelectedText = "";
            this.txtBoxCostPrice.SelectionLength = 0;
            this.txtBoxCostPrice.SelectionStart = 0;
            this.txtBoxCostPrice.ShortcutsEnabled = true;
            this.txtBoxCostPrice.Size = new System.Drawing.Size(234, 36);
            this.txtBoxCostPrice.TabIndex = 3;
            this.txtBoxCostPrice.TabStop = false;
            this.txtBoxCostPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxCostPrice.TrailingIcon = null;
            this.txtBoxCostPrice.UseSystemPasswordChar = false;
            this.txtBoxCostPrice.UseTallSize = false;
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.AnimateReadOnly = false;
            this.txtBoxQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxQuantity.Depth = 0;
            this.txtBoxQuantity.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxQuantity.HideSelection = true;
            this.txtBoxQuantity.Hint = "Quantity";
            this.txtBoxQuantity.LeadingIcon = null;
            this.txtBoxQuantity.Location = new System.Drawing.Point(268, 215);
            this.txtBoxQuantity.MaxLength = 32767;
            this.txtBoxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.PasswordChar = '\0';
            this.txtBoxQuantity.PrefixSuffixText = null;
            this.txtBoxQuantity.ReadOnly = false;
            this.txtBoxQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxQuantity.SelectedText = "";
            this.txtBoxQuantity.SelectionLength = 0;
            this.txtBoxQuantity.SelectionStart = 0;
            this.txtBoxQuantity.ShortcutsEnabled = true;
            this.txtBoxQuantity.Size = new System.Drawing.Size(234, 36);
            this.txtBoxQuantity.TabIndex = 4;
            this.txtBoxQuantity.TabStop = false;
            this.txtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxQuantity.TrailingIcon = null;
            this.txtBoxQuantity.UseSystemPasswordChar = false;
            this.txtBoxQuantity.UseTallSize = false;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(216, 304);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(158, 36);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(382, 305);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(158, 36);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(418, 78);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(158, 36);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dataGridView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 361);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(725, 278);
            this.materialCard2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete,
            this.ProductImg});
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(693, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(17, 122);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(725, 1);
            this.materialDivider1.TabIndex = 13;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(17, 351);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(725, 1);
            this.materialDivider2.TabIndex = 14;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            // 
            // ProductImg
            // 
            this.ProductImg.HeaderText = "ProductImg";
            this.ProductImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ProductImg.Name = "ProductImg";
            this.ProductImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ManageStock
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(759, 651);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.txtBoxWholesalePrice);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.txtBoxCostPrice);
            this.Controls.Add(this.txtBoxProductName);
            this.Controls.Add(this.txtBoxRetailPrice);
            this.Controls.Add(this.txtBoxProductId);
            this.MaximizeBox = false;
            this.Name = "ManageStock";
            this.Text = "Manage Stock";
            this.Load += new System.EventHandler(this.ManageStock_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtBoxProductId;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxProductName;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtBoxDescription;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxRetailPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxWholesalePrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxCostPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxQuantity;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn ProductImg;
    }
}