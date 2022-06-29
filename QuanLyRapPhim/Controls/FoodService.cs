using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyRapPhim.Controls
{
    public partial class FoodService : Form
    {
        ShowTimes Times;
        Movie Movie;
        int money1;
        int money2;
        public FoodService(ShowTimes showTimes, Movie movie)
        {
            InitializeComponent();
            Times = showTimes;
            Movie = movie;
            LoadFoodService();

        }

        private void LoadFoodService()
        {
            lblMovieName.Text = Movie.Name;
            lblDate.Text = Times.Time.ToShortDateString();
            lblHour.Text = Times.Time.ToShortTimeString();
        }

        private void combo1_ValueChanged(object sender, EventArgs e)
        {
            int combo1 = (int)this.combo1.Value;
            if (combo1 <= 0) return;
            money1 = combo1 * 80000;
            lblMoney.Text = (money1 + money2).ToString() + " đ";
        }

        private void combo2_ValueChanged(object sender, EventArgs e)
        {
            int combo2 = (int)this.combo2.Value;
            if (combo2 <= 0) return;
            money2 = combo2 * 100000;
            lblMoney.Text = (money1 + money2).ToString() + " đ";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            Form_Store.sellerform.payment += (money1 + money2);
            Form_Store.sellerform.total += (money1 + money2);

            if((int)this.combo1.Value <= 0 && (int)this.combo2.Value <= 0)
            {
                Form_Store.combofood = "Không";
            }
            else if((int)this.combo1.Value <= 0)
            {
                Form_Store.combofood = "Combo2: " + (int)this.combo2.Value;
            }
            else if ((int)this.combo2.Value <= 0)
            {
                Form_Store.combofood = "Combo1: " + (int)this.combo1.Value;
            }
            else
            {
                Form_Store.combofood = "Combo1: " + (int)this.combo1.Value + "\nCombo2: " + (int)this.combo2.Value;
            }
            this.Close();
            Form_Store.sellerform.Show();
        }
    }
}
