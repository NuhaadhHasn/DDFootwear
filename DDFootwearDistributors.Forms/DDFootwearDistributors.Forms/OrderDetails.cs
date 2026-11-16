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
    public partial class OrderDetails : MaterialForm
    {
        public OrderDetails()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dDFootwearDataSet2.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dDFootwearDataSet2.Sales);

        }
    }
}
