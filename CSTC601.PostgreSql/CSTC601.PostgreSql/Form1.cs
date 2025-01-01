using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace CSTC601.PostgreSql
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        string connectionString = "Server=localhost;port=5432;Database=CustomerDb;user Id=postgres;Password=9082";

        void GetAllCustomers()
        {
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers order by CustomerId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            GetAllCustomers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "insert into Customers (CustomerName, CustomerSurname, CustomerCity) values (@customerName, @customerSurname, @customerCity)";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.ExecuteNonQuery();
            MessageBox.Show("Ekleme işlemi başarılı.");
            connection.Close();
            GetAllCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Delete From Customers where CustomerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Silme işlemi başarılı.");
            connection.Close();
            GetAllCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            string customerSurname = txtCustomerSurname.Text;
            string customerCity = txtCustomerCity.Text;
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Update Customers Set CustomerName = @customerName, CustomerSurname = @customerSurname, CustomerCity = @customerCity where CustomerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerName", customerName);
            command.Parameters.AddWithValue("@customerSurname", customerSurname);
            command.Parameters.AddWithValue("@customerCity", customerCity);
            command.Parameters.AddWithValue("@customerId", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarılı.");
            connection.Close();
            GetAllCustomers();
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCustomerId.Text);
            var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "Select * From Customers where CustomerId = @customerId";
            var command = new NpgsqlCommand(query, connection);
            var adapter = new NpgsqlDataAdapter(command);
            command.Parameters.AddWithValue("@customerId", id);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }
    }
}
