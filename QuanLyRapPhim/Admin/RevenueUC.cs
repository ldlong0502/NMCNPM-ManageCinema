using QuanLyRapPhim.DAO;
using QuanLyRapPhim.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Admin
{
    public partial class RevenueUC : UserControl
    {
        public RevenueUC()
        {
            InitializeComponent();
            LoadRevenue();
        }

        private void LoadRevenue()
        {
            LoadMovieIntoCombobox(cbxSelectMovie);
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadAllRevenue(cbxSelectMovie.SelectedValue.ToString(), dtpFromDate.Value, dtpToDate.Value);
        }

        private void LoadAllRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dtgvRevenue.DataSource = RevenueDAO.GetRevenue(idMovie, fromDate, toDate);
            txtAllRenevue.Text = GetSumRevenue().ToString("c", culture);
        }

        private decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
            }
            return sum;
        }

        private void LoadDateTimePickerRevenue()
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void LoadMovieIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = MovieDAO.GetListMovie();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "ID";
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            LoadAllRevenue(cbxSelectMovie.SelectedValue.ToString(), dtpFromDate.Value, dtpToDate.Value);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DoanhThuCreator doanhThu = new DoanhThuCreator(cbxSelectMovie.SelectedValue.ToString(), dtpFromDate.Value, dtpToDate.Value);
            doanhThu.ShowReport();
        }
    }
}
