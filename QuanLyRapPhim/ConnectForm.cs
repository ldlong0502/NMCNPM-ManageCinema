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

namespace QuanLyRapPhim
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
            if (Properties.Settings.Default.DataSource != string.Empty && Properties.Settings.Default.InitialCatalog != string.Empty)
            {
                txtServerName.Text = Properties.Settings.Default.DataSource;
                txtDatabaseName.Text = Properties.Settings.Default.InitialCatalog;
                username = Properties.Settings.Default.UserID;
                password = Properties.Settings.Default.pwd;
            }

        }

        public static string DataSource;
        public static string InitialCatalog;
        public static string UserID;
        public static string pwd;
        public static string connectionSTR;

        string password = "";
        string username = "";
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnExit.Enabled = false;
            if (password != "")
            {
                connectionSTR = "Data Source=" + txtServerName.Text
                    + ";Initial Catalog=" + txtDatabaseName.Text
                    + ";User ID=" + username
                    + ";pwd=" + password;
            }
            else
            {
                connectionSTR = "Data Source=" + txtServerName.Text
                    + ";Initial Catalog=" + txtDatabaseName.Text
                    + ";Integrated Security=True";
            }

            Properties.Settings.Default.DataSource = txtServerName.Text;
            Properties.Settings.Default.InitialCatalog = txtDatabaseName.Text;
            Properties.Settings.Default.UserID = username;
            Properties.Settings.Default.pwd = password;
            Properties.Settings.Default.connectionSTR = connectionSTR;
            Properties.Settings.Default.Save();


            bool result = DataProvider.TestConnectionSQL(connectionSTR);
            if (result)
            {
                MessageBox.Show("KẾT NỐI THÀNH CÔNG", "THÔNG BÁO");
                this.Close();
            }
            else
                MessageBox.Show("KẾT NỐI THẤT BẠI", "THÔNG BÁO");
            btnConnect.Enabled = true;
            btnExit.Enabled = true;
        }
    }
}
