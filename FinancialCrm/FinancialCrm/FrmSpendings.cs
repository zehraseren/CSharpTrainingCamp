using System;
using System.Linq;
using FinancialCrm.Models;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmSpendings : Form
    {
        private int currentYear;
        private int currentMonth;
        private DateTime startDate;
        private DateTime endDate;

        public FrmSpendings()
        {
            InitializeComponent();
            InitializeDates();
        }

        private void InitializeDates()
        {
            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;

            startDate = new DateTime(currentYear, currentMonth, 1);
            endDate = startDate.AddMonths(1).AddDays(-1);
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        void SpendingList()
        {
            var values = db.Spendings
                .Select(s => new
                {
                    ID = s.SpendingId,
                    Başlık = s.SpendingTitle,
                    Miktar = s.SpendingAmount,
                    Tarih = s.SpendingDate,
                    Kategori = s.Categories.CategoryName,
                })
                .ToList();
            dataGridView1.DataSource = values;
        }

        void UpdateBalance()
        {
            var totalBalance = db.Spendings
             .Where(x => x.SpendingDate >= startDate && x.SpendingDate <= endDate)
             .Sum(x => x.SpendingAmount);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";
        }

        void HighestSpend()
        {
            var highestIncome = db.Spendings
            .Where(x => x.SpendingDate >= startDate && x.SpendingDate <= endDate)
            .OrderByDescending(x => x.SpendingAmount)
            .FirstOrDefault();

            lblHighestSpending.Text = highestIncome.SpendingAmount.ToString() + " ₺";
            lblHighestSpendDesc.Text = highestIncome.SpendingTitle;
        }

        void LastSpendAmount()
        {
            var lastSpendAmount = db.Spendings
            .OrderByDescending(x => x.SpendingId)
            .Take(1)
            .Select(y => new { y.SpendingAmount, y.SpendingTitle }).FirstOrDefault();
            lblLastSpendAmount.Text = lastSpendAmount.SpendingAmount.ToString() + " ₺";
            lblLastSpendDesc.Text = lastSpendAmount.SpendingTitle;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            HighestSpend();
            LastSpendAmount();
            UpdateBalance();
            SpendingList();

            #region Kategoriler

            var categoryName = db.Categories
               .Select(c => new { c.CategoryId, c.CategoryName }).ToList();
            cmbSpendingCategory.DataSource = categoryName;
            cmbSpendingCategory.DisplayMember = "CategoryName";
            cmbSpendingCategory.ValueMember = "CategoryId";

            #endregion
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            HighestSpend();
            LastSpendAmount();
            UpdateBalance();
            SpendingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Now;
            int categoryName = int.Parse(cmbSpendingCategory.SelectedValue.ToString());

            Spendings s = new Spendings();
            s.SpendingTitle = title;
            s.SpendingAmount = amount;
            s.SpendingDate = date;
            s.CategoryId = categoryName;
            db.Spendings.Add(s);
            db.SaveChanges();
            MessageBox.Show("Gider başarılı bir şekilde sisteme eklendi.", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HighestSpend();
            LastSpendAmount();
            UpdateBalance();
            SpendingList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Gider başarılı bir şekilde sistemden silindi.", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HighestSpend();
            LastSpendAmount();
            UpdateBalance();
            SpendingList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Now;
            int categoryName = int.Parse(cmbSpendingCategory.SelectedValue.ToString());
            int id = int.Parse(txtSpendingId.Text);

            var updatedValue = db.Spendings.Find(id);
            updatedValue.SpendingTitle = title;
            updatedValue.SpendingAmount = amount;
            updatedValue.SpendingDate = date;
            updatedValue.CategoryId = categoryName;
            db.SaveChanges();

            MessageBox.Show("Gider başarılı bir şekilde sistemde güncellendi.", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HighestSpend();
            LastSpendAmount();
            UpdateBalance();
            SpendingList();
        }

        #region Yan Panel Butonları

        private void btnBankProcessFrm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses bankProcesses = new FrmBankProcesses();
            bankProcesses.Show();
            this.Close();
        }

        private void btnBillsFrm_Click(object sender, EventArgs e)
        {
            FrmBilling bills = new FrmBilling();
            bills.Show();
            this.Close();
        }

        private void btnSpendingsFrm_Click(object sender, EventArgs e)
        {
            FrmSpendings spendings = new FrmSpendings();
            spendings.Show();
            this.Close();
        }

        private void btnDashboardFrm_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnSettingsFrm_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }

        #endregion
    }
}
