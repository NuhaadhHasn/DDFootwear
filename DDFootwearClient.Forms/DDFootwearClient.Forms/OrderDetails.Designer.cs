namespace DDFootwearClient.Forms
{
    partial class OrderDetails
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productImagePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dDFootwearDataSet = new DDFootwearClient.Forms.DDFootwearDataSet();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filterByCustomerNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.filterByCustomerNameToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.salesTableAdapter = new DDFootwearClient.Forms.DDFootwearDataSetTableAdapters.SalesTableAdapter();
            this.salesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dDFootwearDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDFootwearDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.filterByCustomerNameToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDFootwearDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dataGridView1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 119);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(933, 424);
            this.materialCard1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productDescriptionDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerPhoneDataGridViewTextBoxColumn,
            this.productImagePathDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(905, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productDescriptionDataGridViewTextBoxColumn
            // 
            this.productDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription";
            this.productDescriptionDataGridViewTextBoxColumn.Name = "productDescriptionDataGridViewTextBoxColumn";
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerPhoneDataGridViewTextBoxColumn
            // 
            this.customerPhoneDataGridViewTextBoxColumn.DataPropertyName = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.HeaderText = "CustomerPhone";
            this.customerPhoneDataGridViewTextBoxColumn.Name = "customerPhoneDataGridViewTextBoxColumn";
            // 
            // productImagePathDataGridViewTextBoxColumn
            // 
            this.productImagePathDataGridViewTextBoxColumn.DataPropertyName = "ProductImagePath";
            this.productImagePathDataGridViewTextBoxColumn.HeaderText = "ProductImagePath";
            this.productImagePathDataGridViewTextBoxColumn.Name = "productImagePathDataGridViewTextBoxColumn";
            // 
            // salesBindingSource1
            // 
            this.salesBindingSource1.DataMember = "Sales";
            this.salesBindingSource1.DataSource = this.dDFootwearDataSet;
            // 
            // dDFootwearDataSet
            // 
            this.dDFootwearDataSet.DataSetName = "DDFootwearDataSet";
            this.dDFootwearDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            // 
            // filterByCustomerNameToolStrip
            // 
            this.filterByCustomerNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterByCustomerNameToolStripButton});
            this.filterByCustomerNameToolStrip.Location = new System.Drawing.Point(3, 64);
            this.filterByCustomerNameToolStrip.Name = "filterByCustomerNameToolStrip";
            this.filterByCustomerNameToolStrip.Size = new System.Drawing.Size(958, 25);
            this.filterByCustomerNameToolStrip.TabIndex = 2;
            this.filterByCustomerNameToolStrip.Text = "filterByCustomerNameToolStrip";
            // 
            // filterByCustomerNameToolStripButton
            // 
            this.filterByCustomerNameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.filterByCustomerNameToolStripButton.Name = "filterByCustomerNameToolStripButton";
            this.filterByCustomerNameToolStripButton.Size = new System.Drawing.Size(134, 22);
            this.filterByCustomerNameToolStripButton.Text = "FilterByCustomerName";
            this.filterByCustomerNameToolStripButton.Visible = false;
            this.filterByCustomerNameToolStripButton.Click += new System.EventHandler(this.filterByCustomerNameToolStripButton_Click);
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // salesBindingSource2
            // 
            this.salesBindingSource2.DataMember = "Sales";
            this.salesBindingSource2.DataSource = this.dDFootwearDataSet;
            // 
            // dDFootwearDataSetBindingSource
            // 
            this.dDFootwearDataSetBindingSource.DataSource = this.dDFootwearDataSet;
            this.dDFootwearDataSetBindingSource.Position = 0;
            // 
            // OrderDetails
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(964, 587);
            this.Controls.Add(this.filterByCustomerNameToolStrip);
            this.Controls.Add(this.materialCard1);
            this.Name = "OrderDetails";
            this.Text = "OrderDetails";
            this.Load += new System.EventHandler(this.OrderDetails_Load);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDFootwearDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.filterByCustomerNameToolStrip.ResumeLayout(false);
            this.filterByCustomerNameToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dDFootwearDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private DDFootwearDataSet dDFootwearDataSet;
        private System.Windows.Forms.BindingSource salesBindingSource1;
        private DDFootwearDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.ToolStrip filterByCustomerNameToolStrip;
        private System.Windows.Forms.ToolStripButton filterByCustomerNameToolStripButton;
        private System.Windows.Forms.BindingSource salesBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productImagePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dDFootwearDataSetBindingSource;
    }
}