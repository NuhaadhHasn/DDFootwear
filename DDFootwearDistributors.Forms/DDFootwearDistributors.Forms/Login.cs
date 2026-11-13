using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace DDFootwearDistributors.Forms
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent(); 
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
           //skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green900, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void chkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxShowPassword.Checked)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

            txtBoxPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName, password;
            userName = txtUsername.Text;
            password = txtBoxPassword.Text;
            if (userName == "admin" && password == "admin")
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            } else
            {
                MaterialMessageBox.Show("Invalid Username or Passowrd", "Error");
            }
        }
    }
}
