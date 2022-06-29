using DevExpress.XtraReports.UI;
using QuanLyRapPhim.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.Preview;
namespace QuanLyRapPhim.Report
{
    public class DoanhThuCreator
    {
        public DoanhThuDS DS = new DoanhThuDS();
        public DoanhThuReport RP = new DoanhThuReport();
        string movieID;
        DateTime FromDate;
        DateTime ToDate;
        DateTime SetDate;
        float doanhthu;
        public DoanhThuCreator (string idMovie, DateTime fromDate, DateTime toDate)
        {
            this.movieID = idMovie;
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.SetDate = DateTime.Now;
            doanhthu = 0;
        }

        public bool NhapDuLieuVaoDataSet()
        {
            int stt = 0;
            DataTable dataTable = RevenueDAO.GetRevenue(movieID, FromDate, ToDate);
            foreach (DataRow row in dataTable.Rows)
            {
                stt++;
                string Tenphim = row["Tên phim"].ToString();
                DateTime Ngaychieu = (DateTime)row["Ngày chiếu"];
                string Giochieu = row["Giờ chiếu"].ToString();
                int sove = (int)row["Số vé đã bán"];
                float tien = float.Parse(row["Tiền vé"].ToString());
                doanhthu += tien;
                DS.DoanhThu_dataset.Rows.Add(new object[] {
                    stt, Tenphim, formatDateTime(Ngaychieu), Giochieu, sove, tien.ToString() + " đ"
                });
            }
            return true;
        }
        public void ShowReport()
        {
            RP.DataSource = DS;
            RP.DataMember = DS.DoanhThu_dataset.TableName;
            NhapDuLieuVaoDataSet();

            RP.lblTimeReport.Text = formatDateTime(SetDate);
            RP.lblAllMoney.Text = doanhthu.ToString() + " đ";
            RP.lblFrom.Text = formatDateTime(FromDate);
            RP.lblTo.Text = formatDateTime(ToDate);

            ReportPrintTool reportPrint = new ReportPrintTool(RP);
            reportPrint.ShowPreview();                   
        }
        string formatDateTime(DateTime dt)
        {
            return String.Format("{0:dd/MM/yyyy}", dt);
        }
    }
}
