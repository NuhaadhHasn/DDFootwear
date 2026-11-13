using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DDFootwearClient.Forms
{
    public partial class Order : MaterialForm
    {
        string imagePath;
        string priceWholeSale;
        int stockQuantity;

        // For update Products

        int UpdatedProductId, UpdatedWholeSalePrice, UpdatedRetailPrice, UpdatedCostPrice, UpdatedStock;
        string UpdatedProductName, UpdatedProductDescription, UpdatedProductImg;

        public Order()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }
        public class MyProduct
        {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public int WholeSalePrice { get; set; }
            public int RetailPrice { get; set; }
            public int CostPrice { get; set; }
            public int Stock { get; set; }
            public string ProductImg { get; set; }
        }

        private void txtBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            int price, quantity;

            if (int.TryParse(lblPrice.Text, out price) && int.TryParse(txtBoxQuantity.Text, out quantity))
            {
                int total = price * quantity;
                lblTotal.Text = total.ToString();
            }
        }

        private void txtBoxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MaterialTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                txtBoxProductSearch.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lblProductDetails.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                priceWholeSale = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    lblPrice.Text = priceWholeSale;
                stockQuantity = (int)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
                imagePath = dataGridView1.Rows[e.RowIndex].Cells[9].Value as string;


                // Store to Update Product 
                UpdatedProductId = (int)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
                UpdatedProductName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                UpdatedProductDescription = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                UpdatedWholeSalePrice = (int)dataGridView1.Rows[e.RowIndex].Cells[5].Value;
                UpdatedRetailPrice = (int)dataGridView1.Rows[e.RowIndex].Cells[6].Value;
                UpdatedStock = (int)dataGridView1.Rows[e.RowIndex].Cells[8].Value;
                UpdatedProductImg = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(imagePath)))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {

            try
            {
                string url = "https://localhost:7270/api/Sales";
                HttpClient client = new HttpClient();
                MyOrder myOrder = new MyOrder();
                myOrder.Id = 0;
                myOrder.ProductName = lblProductName.Text;
                myOrder.ProductPrice = Convert.ToInt32(lblPrice.Text);
                myOrder.ProductDescription = lblProductDetails.Text;
                myOrder.Quantity = Convert.ToInt32(txtBoxQuantity.Text);
                myOrder.CustomerName = "Nuhaadh";
                myOrder.CustomerPhone = "0770000000";
                myOrder.TotalPrice = Convert.ToInt32(lblTotal.Text);
                myOrder.ProductImagePath = imagePath;

                string info = (new JavaScriptSerializer()).Serialize(myOrder);

                var content = new StringContent(info, UnicodeEncoding.UTF8, "application/json");
                var respose = client.PostAsync(url, content).Result;
                int UpdatedQuantity = Convert.ToInt32(stockQuantity) - Convert.ToInt32(txtBoxQuantity.Text);
                UpdateProductQuantity(UpdatedQuantity);

                if (respose.IsSuccessStatusCode)
                {
                    MaterialMessageBox.Show("Order Added", "Success");
                    LoadProducts();
                }
                else
                {
                    MaterialMessageBox.Show("Failed to Add Order", "Error!");
                    LoadProducts();
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error!");
            }
        }

        private void UpdateProductQuantity(int newQuantity)
        {
            try
            {
                string url = "https://localhost:7270/api/Product/";
                using (var client = new HttpClient())
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent(UpdatedProductId.ToString()), "productId");
                    content.Add(new StringContent(UpdatedProductName.ToString()), "productName");
                    content.Add(new StringContent(UpdatedProductDescription.ToString()), "productDescription");
                    content.Add(new StringContent(UpdatedWholeSalePrice.ToString()), "wholeSalePrice");
                    content.Add(new StringContent(UpdatedRetailPrice.ToString()), "retailPrice");
                    content.Add(new StringContent(UpdatedCostPrice.ToString()), "costPrice");
                    content.Add(new StringContent(newQuantity.ToString()), "stock");

                    if (!string.IsNullOrEmpty(UpdatedProductImg) && File.Exists(UpdatedProductImg))
                    {
                        var fileName = Path.GetFileName(UpdatedProductImg);


                        using (var fileStream = new FileStream(UpdatedProductImg, FileMode.Open, FileAccess.Read))
                        {
                            var imageBytes = new byte[fileStream.Length];
                            fileStream.Read(imageBytes, 0, imageBytes.Length);
                            var imageContent = new ByteArrayContent(imageBytes);
                            imageContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                            {
                                Name = "productImg",
                                FileName = fileName
                            };
                            content.Add(imageContent);
                        }
                        var response = client.PutAsync(url, content).Result;

                        if (response.IsSuccessStatusCode)
                        {
                            MaterialMessageBox.Show("Product quantity updated", "Success");
                        }
                        else
                        {
                            MaterialMessageBox.Show("Failed to update product quantity", "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error");
            }
        }
        public class MyOrder
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
            public int ProductPrice { get; set; }
            public int Quantity { get; set; }
            public int TotalPrice { get; set; }
            public string CustomerName { get; set; }
            public string CustomerPhone { get; set; }
            public string ProductImagePath { get; set; }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void LoadProducts()
        {
            string url = "https://localhost:7270/api/Product";
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;

            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                readTask.Wait();
                var products = readTask.Result;
                dataGridView1.DataSource = null;

                var productList = (new JavaScriptSerializer()).Deserialize<List<MyProduct>>(products);
                dataGridView1.DataSource = productList;

                dataGridView1.Columns["CostPrice"].Visible = false;

                for (int i = 0; i < productList.Count; i++)
                {
                    dataGridView1.Rows[i].Cells["ProductImg"].Value = LoadProductImage(productList[i].ProductImg);
                }
            }
        }
        private void LoadProduct(int productId)
        {
            string url = "https://localhost:7270/api/Product/" + productId;
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var results = resTask.Result;

            if (results.IsSuccessStatusCode)
            {
                var readTask = results.Content.ReadAsStringAsync();
                readTask.Wait();
                var productJson = readTask.Result;
                var product = (new JavaScriptSerializer()).Deserialize<MyProduct>(productJson);

                if (!string.IsNullOrEmpty(product.ProductImg) && File.Exists(product.ProductImg))
                {
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(imagePath)))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new List<MyProduct> { product };

                dataGridView1.Columns["CostPrice"].Visible = false;
                dataGridView1.Rows[0].Cells["ProductImg"].Value = LoadProductImage(product.ProductImg);
            }
        }

        private Image LoadProductImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                using (MemoryStream memoryStream = new MemoryStream(File.ReadAllBytes(imagePath)))
                {
                    return Image.FromStream(memoryStream);
                }
            }
            else
            {
                return null;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnBuy.Enabled = true;
            int productId = Convert.ToInt32(txtBoxProductSearch.Text);
            string url = "https://localhost:7270/api/Product/" + productId;
            HttpClient client = new HttpClient();
            var resTask = client.GetAsync(url);
            resTask.Wait();
            var result = resTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var readTask = result.Content.ReadAsStringAsync();
                readTask.Wait();
                var products = readTask.Result;
                MyProduct myProduct = (new JavaScriptSerializer()).Deserialize<MyProduct>(products);
                txtBoxProductSearch.Text = myProduct.ProductId.ToString();
                lblProductName.Text = myProduct.ProductName;
                lblPrice.Text = myProduct.WholeSalePrice.ToString();
                lblProductDetails.Text = myProduct.ProductDescription;
                priceWholeSale = myProduct.WholeSalePrice.ToString();

                // Store to Update Product 
                UpdatedProductId = myProduct.ProductId;
                UpdatedProductName = myProduct.ProductName;
                UpdatedProductDescription = myProduct.ProductDescription;
                UpdatedWholeSalePrice = myProduct.WholeSalePrice;
                UpdatedRetailPrice = myProduct.RetailPrice;
                UpdatedCostPrice = myProduct.CostPrice;
                UpdatedStock = myProduct.Stock;
                UpdatedProductImg = myProduct.ProductImg;

                stockQuantity = myProduct.Stock;

                imagePath = myProduct.ProductImg as string;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (MemoryStream ms = new MemoryStream(File.ReadAllBytes(imagePath)))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                }

            }
            LoadProduct(productId);
        }
    }
}
