using System;
using System.Linq;
using FinancialCrm.Models;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankProcesses : Form
    {
        private int currentYear;
        private int currentMonth;
        private DateTime startDate;
        private DateTime endDate;

        public FrmBankProcesses()
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

        void BankProsessList()
        {
            var values = db.BankProcesses
                .Select(bp => new
                {
                    ID = bp.BankProcessId,
                    Açıklama = bp.Description,
                    Tarih = bp.ProcessDate,
                    İşlemTürü = bp.ProcessType,
                    Miktar = bp.Amount,
                    Banka = bp.Banks.BankTitle,
                }).ToList();

            dataGridView1.DataSource = values;
        }

        void UpdateBalance()
        {
            var totalBalance = db.BankProcesses
             .Where(x => x.ProcessDate >= startDate && x.ProcessDate <= endDate)
             .Sum(x => x.Amount);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";
        }

        void HighestIncome()
        {
            var highestIncome = db.BankProcesses
              .Where(x => x.ProcessDate >= startDate && x.ProcessDate <= endDate)
              .OrderByDescending(x => x.Amount)
              .FirstOrDefault();

            lblHighestIncome.Text = highestIncome.Amount.ToString() + " ₺";
            lblHighestIncomeDesc.Text = highestIncome.Description;
        }

        void LastIncomeAmount()
        {
            var lastIncomeAmount = db.BankProcesses
             .OrderByDescending(x => x.BankProcessId)
             .Take(1)
             .Select(y => new { y.Amount, y.Description }).FirstOrDefault();
            lblLastIncomeAmount.Text = lastIncomeAmount.Amount.ToString() + " ₺";
            lblLastIncomeDesc.Text = lastIncomeAmount.Description;
        }

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            HighestIncome();
            LastIncomeAmount();
            UpdateBalance();
            BankProsessList();

            #region Bankalar

            var bankNames = db.Banks
                .Select(b => new { b.BankId, b.BankTitle }).ToList();
            cmbBankProcessBank.DataSource = bankNames;
            cmbBankProcessBank.DisplayMember = "BankTitle";
            cmbBankProcessBank.ValueMember = "BankId";

            #endregion
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            HighestIncome();
            LastIncomeAmount();
            UpdateBalance();
            BankProsessList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string description = txtBankProcessDesc.Text;
            DateTime date = DateTime.Now;
            int bankName = int.Parse(cmbBankProcessBank.SelectedValue.ToString());
            string type = txtProcessType.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);

            BankProcesses bp = new BankProcesses();
            bp.Description = description;
            bp.ProcessDate = date;
            bp.BankId = bankName;
            bp.ProcessType = type;
            bp.Amount = amount;
            db.BankProcesses.Add(bp);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sisteme eklendi.", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HighestIncome();
            LastIncomeAmount();
            UpdateBalance();
            BankProsessList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("İşlem başarılı bir şekilde sistemden silindi.", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HighestIncome();
            LastIncomeAmount();
            UpdateBalance();
            BankProsessList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string description = txtBankProcessDesc.Text;
            DateTime date = DateTime.Now;
            int bankName = int.Parse(cmbBankProcessBank.SelectedValue.ToString());
            string type = txtProcessType.Text;
            decimal amount = decimal.Parse(txtBankProcessAmount.Text);
            int id = int.Parse(txtBankProcessId.Text);

            var updatedValue = db.BankProcesses.Find(id);
            updatedValue.Description = description;
            updatedValue.ProcessDate = date;
            updatedValue.BankId = bankName;
            updatedValue.ProcessType = type;
            updatedValue.Amount = amount;
            db.SaveChanges();

            MessageBox.Show("Ödeme başarılı bir şekilde sistemde güncellendi.", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HighestIncome();
            LastIncomeAmount();
            UpdateBalance();
            BankProsessList();
        }

        #region Yan Panel Butonları

        private void btnBanksFrm_Click(object sender, EventArgs e)
        {
            FrmBanks banks = new FrmBanks();
            banks.Show();
            this.Hide();
        }

        private void btnBankProcessFrm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses bankProcesses = new FrmBankProcesses();
            bankProcesses.Show();
            this.Hide();
        }

        private void btnBillsFrm_Click(object sender, EventArgs e)
        {
            FrmBilling bills = new FrmBilling();
            bills.Show();
            this.Hide();
        }

        private void btnSpendingsFrm_Click(object sender, EventArgs e)
        {
            FrmSpendings spendings = new FrmSpendings();
            spendings.Show();
            this.Hide();
        }

        private void btnDashboardFrm_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnSettingsFrm_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        #endregion
    }
}
