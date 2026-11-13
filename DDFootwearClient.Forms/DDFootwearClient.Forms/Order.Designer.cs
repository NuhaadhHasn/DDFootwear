namespace DDFootwearClient.Forms
{
    partial class Order
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.btnBuy = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.ProductImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtBoxQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            this.lblProductDetails = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductName = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtBoxProductSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.AutoSize = false;
            this.btnBuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuy.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuy.Depth = 0;
            this.btnBuy.Enabled = false;
            this.btnBuy.HighEmphasis = true;
            this.btnBuy.Icon = null;
            this.btnBuy.Location = new System.Drawing.Point(205, 225);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuy.Size = new System.Drawing.Size(158, 36);
            this.btnBuy.TabIndex = 42;
            this.btnBuy.Text = "Buy";
            this.btnBuy.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuy.UseAccentColor = false;
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(6, 271);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(788, 1);
            this.materialDivider2.TabIndex = 41;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // ProductImg
            // 
            this.ProductImg.HeaderText = "ProductImg";
            this.ProductImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ProductImg.Name = "ProductImg";
            this.ProductImg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.ProductImg});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(739, 298);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dataGridView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 289);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(767, 326);
            this.materialCard2.TabIndex = 40;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.AnimateReadOnly = false;
            this.txtBoxQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxQuantity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxQuantity.Depth = 0;
            this.txtBoxQuantity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxQuantity.HideSelection = true;
            this.txtBoxQuantity.Hint = "Quantity";
            this.txtBoxQuantity.LeadingIcon = null;
            this.txtBoxQuantity.Location = new System.Drawing.Point(201, 180);
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
            this.txtBoxQuantity.TabIndex = 36;
            this.txtBoxQuantity.TabStop = false;
            this.txtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxQuantity.TrailingIcon = null;
            this.txtBoxQuantity.UseSystemPasswordChar = false;
            this.txtBoxQuantity.UseTallSize = false;
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxQuantity_KeyPress);
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductDetails.Depth = 0;
            this.lblProductDetails.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductDetails.Location = new System.Drawing.Point(441, 128);
            this.lblProductDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblProductDetails.Size = new System.Drawing.Size(343, 88);
            this.lblProductDetails.TabIndex = 35;
            this.lblProductDetails.Text = "Product Details";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTotal.HighEmphasis = true;
            this.lblTotal.Location = new System.Drawing.Point(650, 232);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 29);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "Total Price";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.Location = new System.Drawing.Point(201, 158);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 19);
            this.lblPrice.TabIndex = 33;
            this.lblPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Depth = 0;
            this.lblProductName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductName.Location = new System.Drawing.Point(202, 128);
            this.lblProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 19);
            this.lblProductName.TabIndex = 32;
            this.lblProductName.Text = "Product Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 128);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(167, 126);
            this.materialCard1.TabIndex = 31;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 120);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(788, 1);
            this.materialDivider1.TabIndex = 30;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtBoxProductSearch
            // 
            this.txtBoxProductSearch.AnimateReadOnly = false;
            this.txtBoxProductSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxProductSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxProductSearch.Depth = 0;
            this.txtBoxProductSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxProductSearch.HideSelection = true;
            this.txtBoxProductSearch.Hint = "Enter Product Id";
            this.txtBoxProductSearch.LeadingIcon = null;
            this.txtBoxProductSearch.Location = new System.Drawing.Point(185, 75);
            this.txtBoxProductSearch.MaxLength = 32767;
            this.txtBoxProductSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxProductSearch.Name = "txtBoxProductSearch";
            this.txtBoxProductSearch.PasswordChar = '\0';
            this.txtBoxProductSearch.PrefixSuffixText = null;
            this.txtBoxProductSearch.ReadOnly = false;
            this.txtBoxProductSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxProductSearch.SelectedText = "";
            this.txtBoxProductSearch.SelectionLength = 0;
            this.txtBoxProductSearch.SelectionStart = 0;
            this.txtBoxProductSearch.ShortcutsEnabled = true;
            this.txtBoxProductSearch.Size = new System.Drawing.Size(234, 36);
            this.txtBoxProductSearch.TabIndex = 26;
            this.txtBoxProductSearch.TabStop = false;
            this.txtBoxProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxProductSearch.TrailingIcon = null;
            this.txtBoxProductSearch.UseSystemPasswordChar = false;
            this.txtBoxProductSearch.UseTallSize = false;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(426, 75);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(158, 36);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(370, 222);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(248, 43);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Search using Id once to enable button";
            // 
            // Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtBoxProductSearch);
            this.Controls.Add(this.btnSearch);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnBuy;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.DataGridViewImageColumn ProductImg;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxQuantity;
        private MaterialSkin.Controls.MaterialLabel lblProductDetails;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel lblPrice;
        private MaterialSkin.Controls.MaterialLabel lblProductName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxProductSearch;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}