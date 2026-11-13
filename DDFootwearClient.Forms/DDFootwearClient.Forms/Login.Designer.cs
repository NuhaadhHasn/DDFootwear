namespace DDFootwearClient.Forms
{
    partial class Login
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
            this.txtBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.chkBoxShowPassword = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
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
            this.txtBoxPassword.Location = new System.Drawing.Point(15, 129);
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
            this.txtBoxPassword.TabIndex = 6;
            this.txtBoxPassword.TabStop = false;
            this.txtBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPassword.TrailingIcon = null;
            this.txtBoxPassword.UseSystemPasswordChar = false;
            this.txtBoxPassword.UseTallSize = false;
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.HideSelection = true;
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = null;
            this.txtUsername.Location = new System.Drawing.Point(15, 78);
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PrefixSuffixText = null;
            this.txtUsername.ReadOnly = false;
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(234, 36);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TabStop = false;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TrailingIcon = null;
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.UseTallSize = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSize = false;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(15, 228);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(234, 38);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(15, 218);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(234, 1);
            this.materialDivider1.TabIndex = 9;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // chkBoxShowPassword
            // 
            this.chkBoxShowPassword.AutoSize = true;
            this.chkBoxShowPassword.Depth = 0;
            this.chkBoxShowPassword.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkBoxShowPassword.Location = new System.Drawing.Point(15, 176);
            this.chkBoxShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.chkBoxShowPassword.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBoxShowPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBoxShowPassword.Name = "chkBoxShowPassword";
            this.chkBoxShowPassword.ReadOnly = false;
            this.chkBoxShowPassword.Ripple = true;
            this.chkBoxShowPassword.Size = new System.Drawing.Size(149, 37);
            this.chkBoxShowPassword.TabIndex = 7;
            this.chkBoxShowPassword.Text = "Show Password";
            this.chkBoxShowPassword.UseVisualStyleBackColor = true;
            this.chkBoxShowPassword.CheckedChanged += new System.EventHandler(this.chkBoxShowPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 282);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.chkBoxShowPassword);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox2 txtUsername;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialCheckbox chkBoxShowPassword;
    }
}