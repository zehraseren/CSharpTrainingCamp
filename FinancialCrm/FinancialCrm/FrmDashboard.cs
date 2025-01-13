using System;
using System.Linq;
using FinancialCrm.Models;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastIncomingAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastIncomingAmount.Text = lastIncomingAmount.ToString() + " ₺";

            #region Chart1

            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();

            chart1.Series.Clear();
            var banks = chart1.Series.Add("Bankalar");
            banks.ChartType = SeriesChartType.Column;
            foreach (var item in bankData)
            {
                banks.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            #endregion

            #region Chart2

            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            chart2.Series.Clear();
            var bills = chart2.Series.Add("Faturalar");
            bills.ChartType = SeriesChartType.Doughnut;
            foreach (var item in billData)
            {
                bills.Points.AddXY(item.BillTitle, item.BillAmount);
            }

            #endregion
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 4 == 1)
            {
                var electric = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = electric.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                var gas = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = gas.ToString() + " ₺";
            }

            if (count % 4 == 3)
            {
                var water = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = water.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = internet.ToString() + " ₺";
            }
        }
    }
}
