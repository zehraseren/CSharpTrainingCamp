using System;
using FinancialCrm.Models;
using System.Windows.Forms;
using FinancialCrm.Manager;
using FinancialCrm.Services;

namespace FinancialCrm
{
    public partial class FrmLogin : Form
    {
        private UserService _userService;
        public FrmLogin()
        {
            InitializeComponent();
            _userService = new UserService(new FinancialCrmDbEntities()); ;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (_userService.ValidateUser(username, password))
            {
                UserManager.IsLoggedIn = true;
                UserManager.Username = username;

                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();

                MessageBox.Show("Giriş Başarılı!", "Giriş Paneli", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!", "Giriş Paneli", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
