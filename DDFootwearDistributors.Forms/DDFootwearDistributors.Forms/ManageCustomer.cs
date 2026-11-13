using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using static System.Net.WebRequestMethods;

namespace DDFootwearDistributors.Forms
{
    public partial class ManageCustomer : MaterialForm
    {
        public ManageCustomer()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            // skinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://localhost:7270/api/Customer";
                HttpClient client = new HttpClient();
                MyCustomer myCustomer = new MyCustomer();
                myCustomer.CustomerId = 0;
                myCustomer.CustomerName = txtBoxName.Text;
                myCustomer.Email = txtBoxEmail.Text;
                myCustomer.Password = txtBoxPassword.Text;
                myCustomer.Phone = txtBoxMobile.Text;
                myCustomer.Address = txtBoxAddress.Text;

                string info = (new JavaScriptSerializer()).Serialize(myCustomer);

                var content = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
                var respose = client.PostAsync(url, content).Result;

                if (respose.IsSuccessStatusCode)
                {
                    MaterialMessageBox.Show("Customer Added", "Success");
                    LoadCustomers();
                }
                else
                {
                    MaterialMessageBox.Show("Failed to Add Customer", "Error!");
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error!");
            }

        }

        private void LoadCustomers()
        {
            string url = "https://localhost:7270/api/Customer";
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;

            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                readTask.Wait();
                var customers = readTask.Result;
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = (new JavaScriptSerializer()).Deserialize<List<MyCustomer>>(customers);

            }
        }

        private void LoadCustomer()
        {
            int customerId = Convert.ToInt32(txtBoxCustomerId.Text);
            string url = "https://localhost:7270/api/Customer/" + customerId;
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;

            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                readTask.Wait();
                var customers = readTask.Result;
                dataGridView1.DataSource = null;
                MyCustomer customer = (new JavaScriptSerializer()).Deserialize<MyCustomer>(customers);
                dataGridView1.DataSource = new List<MyCustomer> { customer };
            }
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                txtBoxCustomerId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBoxName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBoxPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBoxMobile.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtBoxAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                LoadCustomers();
            }
            else if (e.ColumnIndex == 1)
            {
                txtBoxCustomerId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                int customerId = Convert.ToInt32(txtBoxCustomerId.Text);

                string url = "https://localhost:7270/api/Customer?CustomerId=" + customerId;

                HttpClient client = new HttpClient();
                DialogResult result = MaterialMessageBox.Show("Are You Sure, You Want To Delete?", "Confirm Delete!",
                    MessageBoxButtons.YesNo, FlexibleMaterialForm.ButtonsPosition.Center);

                if (result == DialogResult.Yes)
                {
                    var res = client.DeleteAsync(url).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        LoadCustomers();
                    }
                }
            }
        }

        public class MyCustomer
        {
            public int CustomerId { get; set; }
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                string url = "https://localhost:7270/api/Customer";
                HttpClient client = new HttpClient();
                MyCustomer myCustomer = new MyCustomer();
                myCustomer.CustomerId = Convert.ToInt32(txtBoxCustomerId.Text);
                myCustomer.CustomerName = txtBoxName.Text;
                myCustomer.Email = txtBoxEmail.Text;
                myCustomer.Password = txtBoxPassword.Text;
                myCustomer.Phone = txtBoxMobile.Text;
                myCustomer.Address = txtBoxAddress.Text;

                string info = (new JavaScriptSerializer()).Serialize(myCustomer);

                var content = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
                var respose = client.PutAsync(url, content).Result;

                if (respose.IsSuccessStatusCode)
                {
                    MaterialMessageBox.Show("Customer Updated", "Success");
                    LoadCustomers();
                }
                else
                {
                    MaterialMessageBox.Show("Failed to Update Customer", "Error!");
                    LoadCustomers();
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(txtBoxCustomerId.Text);
            string url = "https://localhost:7270/api/Customer/" + customerId;

            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();
                var customers = readTask.Result;
                MyCustomer myCustomer = (new JavaScriptSerializer()).Deserialize<MyCustomer>(customers);
                txtBoxName.Text = myCustomer.CustomerName;
                txtBoxEmail.Text = myCustomer.Email;
                txtBoxPassword.Text = myCustomer.Password;
                txtBoxMobile.Text = myCustomer.Phone;
                txtBoxAddress.Text = myCustomer.Address;

            }
            LoadCustomer();
        }
    }
}
