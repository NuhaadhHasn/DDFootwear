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

namespace DDFootwearDistributors.Forms
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

        private void manageProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStock manageStock = new ManageStock();
            manageStock.MdiParent = this;
            manageStock.Show();

        }

        private void manageCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCustomer manageCustomer = new ManageCustomer();
            manageCustomer.MdiParent = this;
            manageCustomer.Show();
        }

        private void sellRetailOrWholesaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesAndOrder salesAndOrder = new SalesAndOrder();
            salesAndOrder.MdiParent = this;
            salesAndOrder.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDetails orderDetails = new OrderDetails();
            orderDetails.MdiParent = this;
            orderDetails.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
