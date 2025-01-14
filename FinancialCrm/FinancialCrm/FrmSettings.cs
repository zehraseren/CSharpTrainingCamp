using System;
using System.Linq;
using FinancialCrm.Models;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            int id = 1;

            var user = db.Users.FirstOrDefault(u => u.UserId == id);

            if (user != null)
            {
                txtUsername.Text = user.UserName;
                txtPassword.Text = user.Password;
                txtName.Text = user.Name;
                txtSurname.Text = user.Surname;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                txtCity.Text = user.City;
                txtCountry.Text = user.Country;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int id = 1;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string city = txtCity.Text;
            string country = txtCountry.Text;

            var updatedUser = db.Users.Find(id);

            updatedUser.UserName = username;
            updatedUser.Password = password;
            updatedUser.Name = name;
            updatedUser.Surname = surname;
            updatedUser.Email = email;
            updatedUser.Phone = phone;
            updatedUser.City = city;
            updatedUser.Country = country;

            db.SaveChanges();

            MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
