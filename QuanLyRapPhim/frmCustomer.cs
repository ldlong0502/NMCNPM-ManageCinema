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

namespace QuanLyRapPhim
{
    public partial class frmCustomer : Form
    {

        public Customer customer;
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = CustomerDAO.GetCustomerMember(txtSDT.Text);

                if (data.Rows.Count == 0)
                {
                    MessageBox.Show("Số điện thoại không tồn tại!\nVui lòng nhập lại thông tin.");
                    return;
                }
                customer = new Customer(data.Rows[0]);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SDT nhập vào không hợp lệ!!!");
            }

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
