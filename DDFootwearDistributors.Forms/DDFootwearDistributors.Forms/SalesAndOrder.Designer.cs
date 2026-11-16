namespace DDFootwearDistributors.Forms
{
    partial class SalesAndOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesAndOrder));
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxProductSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.btnCart = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblProductName = new MaterialSkin.Controls.MaterialLabel();
            this.lblPrice = new MaterialSkin.Controls.MaterialLabel();
            this.lblProductDetails = new MaterialSkin.Controls.MaterialLabel();
            this.txtBoxQuantity = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxCustomer = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxCustomerPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbBoxCustomer = new MaterialSkin.Controls.MaterialComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dDFootwearDataSet1 = new DDFootwearDistributors.Forms.DDFootwearDataSet1();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductImg = new System.Windows.Forms.DataGridViewImageColumn();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.btnSell = new MaterialSkin.Controls.MaterialButton();
            this.customersTableAdapter = new DDFootwearDistributors.Forms.DDFootwearDataSet1TableAdapters.CustomersTableAdapter();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDFootwearDataSet1)).BeginInit();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(426, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(158, 36);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtBoxProductSearch.Location = new System.Drawing.Point(185, 77);
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
            this.txtBoxProductSearch.TabIndex = 11;
            this.txtBoxProductSearch.TabStop = false;
            this.txtBoxProductSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxProductSearch.TrailingIcon = null;
            this.txtBoxProductSearch.UseSystemPasswordChar = false;
            this.txtBoxProductSearch.UseTallSize = false;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(52, 78);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(89, 37);
            this.materialSwitch1.TabIndex = 13;
            this.materialSwitch1.Text = "Sale";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // btnCart
            // 
            this.btnCart.AnimateShowHideButton = true;
            this.btnCart.Depth = 0;
            this.btnCart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCart.Icon = global::DDFootwearDistributors.Forms.Properties.Resources.shopping_cart;
            this.btnCart.Location = new System.Drawing.Point(697, 73);
            this.btnCart.Mini = true;
            this.btnCart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(40, 40);
            this.btnCart.TabIndex = 14;
            this.btnCart.Text = "materialFloatingActionButton1";
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Visible = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(6, 122);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(788, 1);
            this.materialDivider1.TabIndex = 15;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 130);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(167, 126);
            this.materialCard1.TabIndex = 16;
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
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Depth = 0;
            this.lblProductName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductName.Location = new System.Drawing.Point(202, 130);
            this.lblProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(102, 19);
            this.lblProductName.TabIndex = 17;
            this.lblProductName.Text = "Product Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Depth = 0;
            this.lblPrice.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPrice.Location = new System.Drawing.Point(201, 160);
            this.lblPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(95, 19);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.Text = "Product Price";
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProductDetails.Depth = 0;
            this.lblProductDetails.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblProductDetails.Location = new System.Drawing.Point(441, 130);
            this.lblProductDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.lblProductDetails.Size = new System.Drawing.Size(343, 88);
            this.lblProductDetails.TabIndex = 19;
            this.lblProductDetails.Text = "Product Details";
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
            this.txtBoxQuantity.Location = new System.Drawing.Point(201, 182);
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
            this.txtBoxQuantity.TabIndex = 20;
            this.txtBoxQuantity.TabStop = false;
            this.txtBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxQuantity.TrailingIcon = null;
            this.txtBoxQuantity.UseSystemPasswordChar = false;
            this.txtBoxQuantity.UseTallSize = false;
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxQuantity_KeyPress);
            this.txtBoxQuantity.TextChanged += new System.EventHandler(this.txtBoxQuantity_TextChanged);
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.AnimateReadOnly = false;
            this.txtBoxCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxCustomer.Depth = 0;
            this.txtBoxCustomer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxCustomer.HideSelection = true;
            this.txtBoxCustomer.Hint = "Customer Name";
            this.txtBoxCustomer.LeadingIcon = null;
            this.txtBoxCustomer.Location = new System.Drawing.Point(201, 224);
            this.txtBoxCustomer.MaxLength = 32767;
            this.txtBoxCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.PasswordChar = '\0';
            this.txtBoxCustomer.PrefixSuffixText = null;
            this.txtBoxCustomer.ReadOnly = false;
            this.txtBoxCustomer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCustomer.SelectedText = "";
            this.txtBoxCustomer.SelectionLength = 0;
            this.txtBoxCustomer.SelectionStart = 0;
            this.txtBoxCustomer.ShortcutsEnabled = true;
            this.txtBoxCustomer.Size = new System.Drawing.Size(234, 36);
            this.txtBoxCustomer.TabIndex = 21;
            this.txtBoxCustomer.TabStop = false;
            this.txtBoxCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxCustomer.TrailingIcon = null;
            this.txtBoxCustomer.UseSystemPasswordChar = false;
            this.txtBoxCustomer.UseTallSize = false;
            // 
            // txtBoxCustomerPhone
            // 
            this.txtBoxCustomerPhone.AnimateReadOnly = false;
            this.txtBoxCustomerPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxCustomerPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxCustomerPhone.Depth = 0;
            this.txtBoxCustomerPhone.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxCustomerPhone.HideSelection = true;
            this.txtBoxCustomerPhone.Hint = "Customer Phone Number";
            this.txtBoxCustomerPhone.LeadingIcon = null;
            this.txtBoxCustomerPhone.Location = new System.Drawing.Point(441, 224);
            this.txtBoxCustomerPhone.MaxLength = 32767;
            this.txtBoxCustomerPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxCustomerPhone.Name = "txtBoxCustomerPhone";
            this.txtBoxCustomerPhone.PasswordChar = '\0';
            this.txtBoxCustomerPhone.PrefixSuffixText = null;
            this.txtBoxCustomerPhone.ReadOnly = false;
            this.txtBoxCustomerPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCustomerPhone.SelectedText = "";
            this.txtBoxCustomerPhone.SelectionLength = 0;
            this.txtBoxCustomerPhone.SelectionStart = 0;
            this.txtBoxCustomerPhone.ShortcutsEnabled = true;
            this.txtBoxCustomerPhone.Size = new System.Drawing.Size(234, 36);
            this.txtBoxCustomerPhone.TabIndex = 21;
            this.txtBoxCustomerPhone.TabStop = false;
            this.txtBoxCustomerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxCustomerPhone.TrailingIcon = null;
            this.txtBoxCustomerPhone.UseSystemPasswordChar = false;
            this.txtBoxCustomerPhone.UseTallSize = false;
            // 
            // cmbBoxCustomer
            // 
            this.cmbBoxCustomer.AutoResize = false;
            this.cmbBoxCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBoxCustomer.DataSource = this.customersBindingSource;
            this.cmbBoxCustomer.Depth = 0;
            this.cmbBoxCustomer.DisplayMember = "CustomerName";
            this.cmbBoxCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBoxCustomer.DropDownHeight = 118;
            this.cmbBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCustomer.DropDownWidth = 121;
            this.cmbBoxCustomer.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBoxCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBoxCustomer.FormattingEnabled = true;
            this.cmbBoxCustomer.Hint = "Customer Name";
            this.cmbBoxCustomer.IntegralHeight = false;
            this.cmbBoxCustomer.ItemHeight = 29;
            this.cmbBoxCustomer.Location = new System.Drawing.Point(533, 225);
            this.cmbBoxCustomer.MaxDropDownItems = 4;
            this.cmbBoxCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBoxCustomer.Name = "cmbBoxCustomer";
            this.cmbBoxCustomer.Size = new System.Drawing.Size(234, 35);
            this.cmbBoxCustomer.StartIndex = 0;
            this.cmbBoxCustomer.TabIndex = 22;
            this.cmbBoxCustomer.UseTallSize = false;
            this.cmbBoxCustomer.ValueMember = "CustomerId";
            this.cmbBoxCustomer.Visible = false;
            this.cmbBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCustomer_SelectedIndexChanged);
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.dDFootwearDataSet1;
            // 
            // dDFootwearDataSet1
            // 
            this.dDFootwearDataSet1.DataSetName = "DDFootwearDataSet1";
            this.dDFootwearDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dataGridView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(17, 339);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(767, 278);
            this.materialCard2.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.View,
            this.ProductImg});
            this.dataGridView1.Location = new System.Drawing.Point(18, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.Size = new System.Drawing.Size(732, 243);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // View
            // 
            this.View.HeaderText = "View";
            this.View.Name = "View";
            this.View.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.View.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProductImg
            // 
            this.ProductImg.HeaderText = "ProductImg";
            this.ProductImg.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.ProductImg.Name = "ProductImg";
            this.ProductImg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(6, 321);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(788, 1);
            this.materialDivider2.TabIndex = 24;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // btnSell
            // 
            this.btnSell.AutoSize = false;
            this.btnSell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSell.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSell.Depth = 0;
            this.btnSell.HighEmphasis = true;
            this.btnSell.Icon = null;
            this.btnSell.Location = new System.Drawing.Point(354, 269);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSell.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSell.Name = "btnSell";
            this.btnSell.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSell.Size = new System.Drawing.Size(158, 36);
            this.btnSell.TabIndex = 25;
            this.btnSell.Text = "Sell";
            this.btnSell.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSell.UseAccentColor = false;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lblTotal.HighEmphasis = true;
            this.lblTotal.Location = new System.Drawing.Point(650, 276);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(117, 29);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "Total Price";
            // 
            // SalesAndOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.cmbBoxCustomer);
            this.Controls.Add(this.txtBoxCustomerPhone);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.txtBoxQuantity);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.materialSwitch1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtBoxProductSearch);
            this.Name = "SalesAndOrder";
            this.Text = "Sales And Order";
            this.Load += new System.EventHandler(this.SalesAndOrder_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDFootwearDataSet1)).EndInit();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxProductSearch;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnCart;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel lblProductName;
        private MaterialSkin.Controls.MaterialLabel lblPrice;
        private MaterialSkin.Controls.MaterialLabel lblProductDetails;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxQuantity;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxCustomer;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxCustomerPhone;
        private MaterialSkin.Controls.MaterialComboBox cmbBoxCustomer;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton btnSell;
        private System.Windows.Forms.DataGridViewButtonColumn View;
        private System.Windows.Forms.DataGridViewImageColumn ProductImg;
        private DDFootwearDataSet1 dDFootwearDataSet1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private DDFootwearDataSet1TableAdapters.CustomersTableAdapter customersTableAdapter;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
    }
}