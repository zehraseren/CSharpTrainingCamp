using System;
using Dapper;
using System.Windows.Forms;
using System.Data.SqlClient;
using CSTC501.UsingDapper.Dtos;

namespace CSTC501.UsingDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=Zehra;initial catalog=DbCamp501;integrated security=true;");

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "select * from Product";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "insert into Product (ProductName, ProductStock, ProductPrice, ProductCategory) values (@productName, @productStock, @productPrice, @productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productcategory", txtProductCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Ekleme işlemi başarılı", "Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "delete from Product where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Silme işlem başarılı", "Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "update Product Set ProductName=@productName, ProductStock=@productStock, ProductPrice=@productPrice, ProductCategory=@productCategory where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productName", txtProductName.Text);
            parameters.Add("@productStock", txtProductStock.Text);
            parameters.Add("@productPrice", txtProductPrice.Text);
            parameters.Add("@productCategory", txtProductCategory.Text);
            parameters.Add("@productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncelleme işlemi başarılı", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "select count(*) from Product";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lblTotalProductCount.Text = productTotalCount.ToString();

            string query2 = "select ProductName from Product where ProductPrice = (select max(ProductPrice) from Product)";
            var maxPriceProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProductName.Text = maxPriceProductName.ToString();

            string query3 = "select count(distinct(ProductCategory)) from Product ";
            var distinctCategoryCount = await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctCategoryCount.Text = distinctCategoryCount.ToString();
        }
    }
}
