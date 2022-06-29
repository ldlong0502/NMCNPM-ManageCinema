using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim.DAO;
using QuanLyRapPhim.DTO;
using System.Globalization;
using QuanLyRapPhim.Controls;
using QuanLyRapPhim.Report;

namespace QuanLyRapPhim
{
    public partial class SellerForm : Form
    {
        int SIZE = 30;//Size của ghế
        int GAP = 7;//Khoảng cách giữa các ghế
        

        List<Ticket> listSeat = new List<Ticket>();

        //dùng lưu vết các Ghế đang chọn
        List<Button> listSeatSelected = new List<Button>();

        float displayPrice = 0;//Hiện thị giá vé
        float ticketPrice = 0;//Lưu giá vé gốc
        public float total = 0;//Tổng giá tiền
        float discount = 0;//Tiền được giảm
        public float payment = 0;//Tiền phải trả
        int plusPoint = 0;//Số điểm tích lũy khi mua vé
        int seat = 0;
        int freeTicket = 0;


        Customer customer;//lưu lại khách hàng thành viên

        ShowTimes Times;
        Movie Movie;

        public SellerForm(ShowTimes showTimes, Movie movie)
        {
            InitializeComponent();
            Form_Store.sellerform = this;
            Times= showTimes;
            Movie= movie;
            
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            ticketPrice = Times.TicketPrice;
            btnFood.Enabled = false;
            chkCustomer.ForeColor = Color.White;
            lblInformation.Text = "Dream Cinema | " + Times.CinemaName + " | " + Times.MovieName;
            lblTime.Text = Times.Time.ToShortDateString() + " | "
                + Times.Time.ToShortTimeString() + " - "
                + Times.Time.AddMinutes(Movie.Time).ToShortTimeString();
            if (Movie.Poster != null)
                picFilm.Image = MovieDAO.byteArrayToImage(Movie.Poster);

            
            chkCustomer.Enabled = false;
            

            LoadDataCinema(Times.CinemaName);

            ShowOrHideLablePoint();

            listSeat = TicketDAO.GetListTicketsByShowTimes(Times.ID);

            LoadSeats(listSeat);
            
        }

        private void LoadDataCinema(string cinemaName)
        {
            RoomCinema cinema = RoomCinemaDAO.GetRoomCinemaByName(cinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            flpSeat.Size = new Size((SIZE + 20 + GAP) * Column, (SIZE + GAP) * Row);
        }
        string gia = "45000";
        private void LoadBill()
        {
              CultureInfo culture = new CultureInfo("vi-VN");
            //Đổi culture vùng quốc gia để đổi đơn vị tiền tệ 

            //Thread.CurrentThread.CurrentCulture = culture;
            //dùng thread để chuyển cả luồng đang chạy về vùng quốc gia đó

            gia = displayPrice.ToString("c", culture);
            lblTotal.Text = total.ToString("c", culture);
            lblDiscount.Text = discount.ToString("c", culture);
            lblPayment.Text = payment.ToString("c", culture);

            //Đổi đơn vị tiền tệ
            //gán culture chỗ này thì chỉ có chỗ này sd culture này còn
            //lại sài mặc định
        }

        private void LoadSeats(List<Ticket> list)
        {
            flpSeat.Controls.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                Button btnSeat = new Button() { Width = SIZE + 20, Height = SIZE };
                btnSeat.Text = list[i].SeatName;
                if (list[i].Status == 1)
                    btnSeat.BackColor = Color.Red;
                else
                    btnSeat.BackColor = Color.White;
                btnSeat.Click += BtnSeat_Click;
                flpSeat.Controls.Add(btnSeat);

                btnSeat.Tag = list[i];
            }
        }

        private void BtnSeat_Click(object sender, EventArgs e)
        {
           
            Button btnSeat = sender as Button;
            if (btnSeat.BackColor == Color.White)
            {
             

                btnSeat.BackColor = Color.Yellow;
                Ticket ticket = btnSeat.Tag as Ticket;

                ticket.Price = ticketPrice;
                displayPrice = ticket.Price;
                total += ticketPrice;
                payment = total - discount;
                ticket.Type = 1;

                listSeatSelected.Add(btnSeat);
                seat++;
                plusPoint++;
                lblPlusPoint.Text = plusPoint + "";
            }
            else if (btnSeat.BackColor == Color.Yellow)
            {
                btnSeat.BackColor = Color.White;
                Ticket ticket = btnSeat.Tag as Ticket;

                total -= ticket.Price;
                payment = total - discount;
                ticket.Price = 0;
                displayPrice = ticket.Price;
                ticket.Type = 0;

                listSeatSelected.Remove(btnSeat);
                plusPoint--;
                lblPlusPoint.Text = plusPoint + "";
            }
            else if (btnSeat.BackColor == Color.Red)
            {
                MessageBox.Show("Ghế số [" + btnSeat.Text + "] đã có người mua");
            }
            LoadBill();
            if (listSeatSelected.Count > 0)
            {
                chkCustomer.Enabled = true;
            }
            else
            {
                chkCustomer.Enabled = false;
            }
            if (listSeatSelected.Count > 0)
            {
                btnFood.Enabled = true;
            }
            else { btnFood.Enabled = false; }
        }
        private void ShowOrHideLablePoint()
        {
            if (chkCustomer.Checked == true)
            {
                pnCustomer.Visible = true;
            }
            else
            {
                pnCustomer.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int point = freeTicket * 20;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn hủy tất cả những vé đã chọn ko",
               "Hủy Mua Vé", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point + point))
            {
                freeTicket = 0;
            }
            foreach (Button btn in listSeatSelected)
            {
                btn.BackColor = Color.White;
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }
        private void RestoreDefault()
        {
            listSeatSelected.Clear();

            chkCustomer.Checked = false;
            chkCustomer.Enabled = false;

            ShowOrHideLablePoint();

            total = 0;
            displayPrice = 0;
            discount = 0;
            payment = 0;
            plusPoint = 0;
            seat = 0;
            freeTicket = 0;
            Form_Store.combofood = "";
            Form_Store.sellerform = null;
            LoadBill();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (listSeatSelected.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn vé trước khi thanh toán");
                return;
            }
            string message = "Bạn có chắc chắn mua những vé: \n";
            foreach (Button btn in listSeatSelected)
            {
                message += "[" + btn.Text + "] ";
            }
            message += "\nKhông";
            DialogResult result = MessageBox.Show(message, "Hỏi Mua",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                int ret = 0;
                if (chkCustomer.Checked == true)
                {
                    for (int i = 0; i < listSeatSelected.Count; i++)
                    {
                        if (i == listSeatSelected.Count - 1)
                        {
                            Ticket ticket = listSeatSelected[i].Tag as Ticket;
                            ticket.Price += payment;
                            ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, ticket.Price + payment);
                        }
                        else
                        {
                            Ticket ticket = listSeatSelected[i].Tag as Ticket;
                            ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, 0);
                        }

                    }
                    customer.Point += plusPoint;
                    CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point);
                }
                else
                {
                    for (int i = 0; i< listSeatSelected.Count; i++)
                    {
                        if(i == listSeatSelected.Count - 1)
                        {
                            Ticket ticket = listSeatSelected[i].Tag as Ticket;
                            ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, payment);
                        }
                        else
                        {
                            Ticket ticket = listSeatSelected[i].Tag as Ticket;
                            ret += TicketDAO.BuyTicket(ticket.ID, ticket.Type, 0);
                        }
                    }
                }
                if (ret == listSeatSelected.Count)
                {
                    MessageBox.Show("Bạn đã mua vé thành công");
                    freeTicket = 0;
                    string pos = "";
                    foreach(Button btn in listSeatSelected) { 
                        pos += btn.Text + " ";
                    }
                    TicketBillCreator  ticketBillCreator = new TicketBillCreator(
                        Movie.Name,Times.Time, Times.CinemaName, pos, Form_Store.combofood, lblPayment.Text
                   );
                    ticketBillCreator.ShowReport();
                }
            }
            RestoreDefault();
            this.OnLoad(new EventArgs());
        }

        private void chkCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCustomer.Checked == true)
            {
                frmCustomer frm = new frmCustomer();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    customer = frm.customer;
                    lblCustomerName.Text = customer.Name;
                    lblPoint.Text = customer.Point + "";
                    ShowOrHideLablePoint();
                }
                else
                {
                    chkCustomer.Checked = false;
                }
            }
            else
            {
                ShowOrHideLablePoint();
                customer = null;
            }
        }

        private void pnCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPoint_Click(object sender, EventArgs e)
        {

        }

        private void btnFreeTicket_Click(object sender, EventArgs e)
        {

            int freeTickets = (int)numericFreeTickets.Value;
            if (freeTickets <= 0) return;
            
            if (freeTickets > seat)
            {
                MessageBox.Show("BẠN CHỈ ĐỔI ĐƯỢC TỐT ĐA [" + listSeatSelected.Count + "] VÉ", "THÔNG BÁO");
                return;
            }
            int pointFreeTicket = freeTickets * 20;
            if (customer.Point < pointFreeTicket)
            {
                MessageBox.Show("BẠN KHÔNG ĐỦ ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ", "THÔNG BÁO");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("BẠN CÓ MUỐN DÙNG ĐIỂM TÍCH LŨY ĐỂ ĐỔI [" + freeTickets + "] VÉ MIỄN PHÍ KHÔNG",
                                        "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customer.Point -= pointFreeTicket;
                    plusPoint -= freeTickets;

                    if (CustomerDAO.UpdatePointCustomer(customer.ID, customer.Point))
                    {
                        MessageBox.Show("BẠN ĐÃ DỔI ĐƯỢC [" + freeTickets + "] VÉ MIỄN PHÍ THÀNH CÔNG", "THÔNG BÁO");
                        freeTicket += freeTickets;
                    }
                    lblPoint.Text = "" + customer.Point;
                    lblPlusPoint.Text = "" + plusPoint;

                    for (int i = 0; i < listSeatSelected.Count && freeTickets > 0; i++)
                    {
                        Ticket ticket = listSeatSelected[i].Tag as Ticket;
                        if (ticket.Price != 0)
                        {
                            discount += ticket.Price;
                            ticket.Price = 0;
                            freeTickets--;
                        }
                        seat--;
                    }

                    payment = total - discount;
                    LoadBill();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodService food = new FoodService(Times, Movie);
            food.ShowDialog();
            LoadBill();
        }
    }
}
