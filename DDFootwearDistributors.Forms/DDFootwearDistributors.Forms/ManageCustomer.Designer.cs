namespace DDFootwearDistributors.Forms
{
    partial class ManageCustomer
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
            this.txtBoxCustomerId = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearch = new MaterialSkin.Controls.MaterialButton();
            this.btnUpdate = new MaterialSkin.Controls.MaterialButton();
            this.btnAdd = new MaterialSkin.Controls.MaterialButton();
            this.txtBoxAddress = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxEmail = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxName = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtBoxMobile = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxCustomerId
            // 
            this.txtBoxCustomerId.AnimateReadOnly = false;
            this.txtBoxCustomerId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxCustomerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxCustomerId.Depth = 0;
            this.txtBoxCustomerId.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxCustomerId.HideSelection = true;
            this.txtBoxCustomerId.Hint = "Customer Id";
            this.txtBoxCustomerId.LeadingIcon = null;
            this.txtBoxCustomerId.Location = new System.Drawing.Point(202, 84);
            this.txtBoxCustomerId.MaxLength = 32767;
            this.txtBoxCustomerId.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxCustomerId.Name = "txtBoxCustomerId";
            this.txtBoxCustomerId.PasswordChar = '\0';
            this.txtBoxCustomerId.PrefixSuffixText = null;
            this.txtBoxCustomerId.ReadOnly = false;
            this.txtBoxCustomerId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxCustomerId.SelectedText = "";
            this.txtBoxCustomerId.SelectionLength = 0;
            this.txtBoxCustomerId.SelectionStart = 0;
            this.txtBoxCustomerId.ShortcutsEnabled = true;
            this.txtBoxCustomerId.Size = new System.Drawing.Size(234, 36);
            this.txtBoxCustomerId.TabIndex = 13;
            this.txtBoxCustomerId.TabStop = false;
            this.txtBoxCustomerId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxCustomerId.TrailingIcon = null;
            this.txtBoxCustomerId.UseSystemPasswordChar = false;
            this.txtBoxCustomerId.UseTallSize = false;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dataGridView1);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(21, 320);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(784, 246);
            this.materialCard2.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(14, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // btnSearch
            // 
            this.btnSearch.AutoSize = false;
            this.btnSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSearch.Depth = 0;
            this.btnSearch.HighEmphasis = true;
            this.btnSearch.Icon = null;
            this.btnSearch.Location = new System.Drawing.Point(443, 84);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSearch.Size = new System.Drawing.Size(158, 36);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSearch.UseAccentColor = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AutoSize = false;
            this.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUpdate.Depth = 0;
            this.btnUpdate.HighEmphasis = true;
            this.btnUpdate.Icon = null;
            this.btnUpdate.Location = new System.Drawing.Point(406, 265);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUpdate.Size = new System.Drawing.Size(158, 36);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUpdate.UseAccentColor = false;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = false;
            this.btnAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAdd.Depth = 0;
            this.btnAdd.HighEmphasis = true;
            this.btnAdd.Icon = null;
            this.btnAdd.Location = new System.Drawing.Point(240, 264);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAdd.Size = new System.Drawing.Size(158, 36);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAdd.UseAccentColor = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.AnimateReadOnly = false;
            this.txtBoxAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxAddress.Depth = 0;
            this.txtBoxAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxAddress.HideSelection = true;
            this.txtBoxAddress.Hint = "Address";
            this.txtBoxAddress.LeadingIcon = null;
            this.txtBoxAddress.Location = new System.Drawing.Point(166, 220);
            this.txtBoxAddress.MaxLength = 32767;
            this.txtBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.PasswordChar = '\0';
            this.txtBoxAddress.PrefixSuffixText = null;
            this.txtBoxAddress.ReadOnly = false;
            this.txtBoxAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxAddress.SelectedText = "";
            this.txtBoxAddress.SelectionLength = 0;
            this.txtBoxAddress.SelectionStart = 0;
            this.txtBoxAddress.ShortcutsEnabled = true;
            this.txtBoxAddress.Size = new System.Drawing.Size(473, 36);
            this.txtBoxAddress.TabIndex = 20;
            this.txtBoxAddress.TabStop = false;
            this.txtBoxAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxAddress.TrailingIcon = null;
            this.txtBoxAddress.UseSystemPasswordChar = false;
            this.txtBoxAddress.UseTallSize = false;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.AnimateReadOnly = false;
            this.txtBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxPassword.Depth = 0;
            this.txtBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxPassword.HideSelection = true;
            this.txtBoxPassword.Hint = "Password";
            this.txtBoxPassword.LeadingIcon = null;
            this.txtBoxPassword.Location = new System.Drawing.Point(166, 178);
            this.txtBoxPassword.MaxLength = 32767;
            this.txtBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '\0';
            this.txtBoxPassword.PrefixSuffixText = null;
            this.txtBoxPassword.ReadOnly = false;
            this.txtBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.SelectionLength = 0;
            this.txtBoxPassword.SelectionStart = 0;
            this.txtBoxPassword.ShortcutsEnabled = true;
            this.txtBoxPassword.Size = new System.Drawing.Size(234, 36);
            this.txtBoxPassword.TabIndex = 17;
            this.txtBoxPassword.TabStop = false;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPassword.TrailingIcon = null;
            this.txtBoxPassword.UseSystemPasswordChar = false;
            this.txtBoxPassword.UseTallSize = false;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.AnimateReadOnly = false;
            this.txtBoxEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxEmail.Depth = 0;
            this.txtBoxEmail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxEmail.HideSelection = true;
            this.txtBoxEmail.Hint = "Email";
            this.txtBoxEmail.LeadingIcon = null;
            this.txtBoxEmail.Location = new System.Drawing.Point(405, 136);
            this.txtBoxEmail.MaxLength = 32767;
            this.txtBoxEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.PasswordChar = '\0';
            this.txtBoxEmail.PrefixSuffixText = null;
            this.txtBoxEmail.ReadOnly = false;
            this.txtBoxEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxEmail.SelectedText = "";
            this.txtBoxEmail.SelectionLength = 0;
            this.txtBoxEmail.SelectionStart = 0;
            this.txtBoxEmail.ShortcutsEnabled = true;
            this.txtBoxEmail.Size = new System.Drawing.Size(234, 36);
            this.txtBoxEmail.TabIndex = 16;
            this.txtBoxEmail.TabStop = false;
            this.txtBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxEmail.TrailingIcon = null;
            this.txtBoxEmail.UseSystemPasswordChar = false;
            this.txtBoxEmail.UseTallSize = false;
            // 
            // txtBoxName
            // 
            this.txtBoxName.AnimateReadOnly = false;
            this.txtBoxName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxName.Depth = 0;
            this.txtBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxName.HideSelection = true;
            this.txtBoxName.Hint = "Name";
            this.txtBoxName.LeadingIcon = null;
            this.txtBoxName.Location = new System.Drawing.Point(165, 136);
            this.txtBoxName.MaxLength = 32767;
            this.txtBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.PasswordChar = '\0';
            this.txtBoxName.PrefixSuffixText = null;
            this.txtBoxName.ReadOnly = false;
            this.txtBoxName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxName.SelectedText = "";
            this.txtBoxName.SelectionLength = 0;
            this.txtBoxName.SelectionStart = 0;
            this.txtBoxName.ShortcutsEnabled = true;
            this.txtBoxName.Size = new System.Drawing.Size(234, 36);
            this.txtBoxName.TabIndex = 15;
            this.txtBoxName.TabStop = false;
            this.txtBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxName.TrailingIcon = null;
            this.txtBoxName.UseSystemPasswordChar = false;
            this.txtBoxName.UseTallSize = false;
            // 
            // txtBoxMobile
            // 
            this.txtBoxMobile.AnimateReadOnly = false;
            this.txtBoxMobile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtBoxMobile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBoxMobile.Depth = 0;
            this.txtBoxMobile.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBoxMobile.HideSelection = true;
            this.txtBoxMobile.Hint = "Mobile Number";
            this.txtBoxMobile.LeadingIcon = null;
            this.txtBoxMobile.Location = new System.Drawing.Point(406, 178);
            this.txtBoxMobile.MaxLength = 32767;
            this.txtBoxMobile.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBoxMobile.Name = "txtBoxMobile";
            this.txtBoxMobile.PasswordChar = '\0';
            this.txtBoxMobile.PrefixSuffixText = null;
            this.txtBoxMobile.ReadOnly = false;
            this.txtBoxMobile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBoxMobile.SelectedText = "";
            this.txtBoxMobile.SelectionLength = 0;
            this.txtBoxMobile.SelectionStart = 0;
            this.txtBoxMobile.ShortcutsEnabled = true;
            this.txtBoxMobile.Size = new System.Drawing.Size(234, 36);
            this.txtBoxMobile.TabIndex = 19;
            this.txtBoxMobile.TabStop = false;
            this.txtBoxMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxMobile.TrailingIcon = null;
            this.txtBoxMobile.UseSystemPasswordChar = false;
            this.txtBoxMobile.UseTallSize = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(20, 129);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(784, 1);
            this.materialDivider1.TabIndex = 26;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(18, 310);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(784, 1);
            this.materialDivider2.TabIndex = 27;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // ManageCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(821, 594);
            this.Controls.Add(this.materialDivider2);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.txtBoxCustomerId);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.txtBoxMobile);
            this.Name = "ManageCustomer";
            this.Text = "Manage Customer";
            this.Load += new System.EventHandler(this.ManageCustomer_Load);
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtBoxCustomerId;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnUpdate;
        private MaterialSkin.Controls.MaterialButton btnAdd;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxAddress;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxName;
        private MaterialSkin.Controls.MaterialTextBox2 txtBoxMobile;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}