using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace DDFootwearDistributors.Forms
{
    public partial class ManageStock : MaterialForm
    {
        private string selectedImagePath;
        public ManageStock()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;


        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://localhost:7270/api/Product";
                using (var client = new HttpClient())
                using (var content = new MultipartFormDataContent())
                {
                    content.Add(new StringContent("0"), "productId");
                    content.Add(new StringContent(txtBoxProductName.Text), "productName");
                    content.Add(new StringContent(txtBoxDescription.Text), "productDescription");
                    content.Add(new StringContent(txtBoxCostPrice.Text), "costPrice");
                    content.Add(new StringContent(txtBoxWholesalePrice.Text), "wholeSalePrice");
                    content.Add(new StringContent(txtBoxRetailPrice.Text), "retailPrice");
                    content.Add(new StringContent(txtBoxQuantity.Text), "stock");

                    if (!string.IsNullOrEmpty(selectedImagePath))
                    {
                        var fileName = Path.GetFileName(selectedImagePath);
                        var imageBytes = File.ReadAllBytes(selectedImagePath);
                        var imageContent = new ByteArrayContent(imageBytes);
                        imageContent.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data")
                        {
                            Name = "productImg",
                            FileName = fileName
                        };

                        content.Add(imageContent);

                    }

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MaterialMessageBox.Show("Product Added", "Success");
                        LoadProducts();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Failed to Add Product", "Error!");
                        LoadProducts();
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error!");
            }
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
                    pictureBox1.Image = Image.FromFile(product.ProductImg);
                }
                else
                {
                    pictureBox1.Image = null;
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = new List<MyProduct> { product };
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

        private void ManageStock_Load(object sender, EventArgs e)
        {
            //LoadProducts();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 0)
            {
                txtBoxProductId.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtBoxProductName.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBoxDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtBoxWholesalePrice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtBoxRetailPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtBoxCostPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtBoxQuantity.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

                string imagePath = dataGridView1.Rows[e.RowIndex].Cells[10].Value as string;

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
            else if (e.ColumnIndex == 1)
            {
                txtBoxProductId.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                int productId = Convert.ToInt32(txtBoxProductId.Text);

                string url = "https://localhost:7270/api/Product?ProductId=" + productId;

                HttpClient client = new HttpClient();
                DialogResult result = MaterialMessageBox.Show("Are You Sure, You Want To Delete?", "Confirm Delete!",
                    MessageBoxButtons.YesNo, FlexibleMaterialForm.ButtonsPosition.Center);

                if (result == DialogResult.Yes)
                {
                    var res = client.DeleteAsync(url).Result;
                    if (res.IsSuccessStatusCode)
                    {
                        LoadProducts();
                    }
                }
            }

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://localhost:7270/api/Product";
                using (var client = new HttpClient())
                using (var content = new MultipartFormDataContent())
                {
                    // Add product details
                    content.Add(new StringContent(txtBoxProductId.Text), "productId");
                    content.Add(new StringContent(txtBoxProductName.Text), "productName");
                    content.Add(new StringContent(txtBoxDescription.Text), "productDescription");
                    content.Add(new StringContent(txtBoxWholesalePrice.Text), "wholeSalePrice");
                    content.Add(new StringContent(txtBoxRetailPrice.Text), "retailPrice");
                    content.Add(new StringContent(txtBoxCostPrice.Text), "costPrice");
                    content.Add(new StringContent(txtBoxQuantity.Text), "stock");

                    // Add the image if selected
                    if (!string.IsNullOrEmpty(selectedImagePath) && File.Exists(selectedImagePath))
                    {
                        var fileName = Path.GetFileName(selectedImagePath);


                        using (var fileStream = new FileStream(selectedImagePath, FileMode.Open, FileAccess.Read))
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


                        var response = await client.PutAsync(url, content);

                        if (response.IsSuccessStatusCode)
                        {
                            MaterialMessageBox.Show("Product Updated", "Success");
                            LoadProducts();
                        }
                        else
                        {
                            MaterialMessageBox.Show("Failed to Update Product", "Error!");
                            var errorContent = await response.Content.ReadAsStringAsync();
                            MaterialMessageBox.Show($"Error updating product: {response.StatusCode} - {errorContent}", "Error");
                            LoadProducts();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(txtBoxProductId.Text);
            LoadProduct(productId);
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
                txtBoxProductName.Text = myProduct.ProductName;
                txtBoxDescription.Text = myProduct.ProductDescription;
                txtBoxWholesalePrice.Text = myProduct.WholeSalePrice.ToString();
                txtBoxRetailPrice.Text = myProduct.RetailPrice.ToString();
                txtBoxCostPrice.Text = myProduct.CostPrice.ToString();
                txtBoxQuantity.Text = myProduct.Stock.ToString();

                string imagePath = myProduct.ProductImg as string;

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
