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
    public partial class HomePage : MaterialForm
    {
        public HomePage()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void orderProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.MdiParent = this;
            order.Show();
        }

        private void manageYourOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.MdiParent = this;
            orderDetails.Show();
        }
    }
}
