using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.Report
{
    public class TicketBillCreator
    {
        public TicketBill RP = new TicketBill();
        string movieName;
        DateTime setDate;
        DateTime ShowTimes;
        string room;
        string pos;
        string combofood;
        string money;
        public TicketBillCreator(string movieName, DateTime showTimes, string room, string pos, string combofood, string money)
        {
            this.movieName = movieName;
            this.setDate = DateTime.Now;
            ShowTimes = showTimes;
            this.room = room;
            this.pos = pos;
            this.combofood = combofood;
            this.money = money;
        }
        public void ShowReport()
        {

            RP.lblMovieName.Text = movieName;
            RP.lblSetDate.Text = formatDateTime(setDate);
            RP.lblShowTimes.Text = formatDateTime(ShowTimes);
            RP.lblRoom.Text = room;
            RP.lblPosition.Text = pos;
            RP.lblFood.Text = combofood;
            RP.lblAllMoney.Text = money;
            ReportPrintTool reportPrint = new ReportPrintTool(RP);
            reportPrint.ShowPreview();
        }
        string formatDateTime(DateTime dt)
        {
            return String.Format("{0:dd/MM/yyyy HH:mm:ss tt}", dt);
        }
    }
}
