using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDFootwearClient.Forms
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string userName, password;
            userName = txtUsername.Text;
            password = txtBoxPassword.Text;
            if (userName == "Nuhaadh" && password == "123456")
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MaterialMessageBox.Show("Invalid Username or Passowrd", "Error");
            }
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
    }
}
