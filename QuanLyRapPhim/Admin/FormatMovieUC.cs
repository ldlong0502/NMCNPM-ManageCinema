using QuanLyRapPhim.DAO;
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

namespace QuanLyRapPhim.Admin
{
    public partial class FormatMovieUC : UserControl
    {
        BindingSource formatList = new BindingSource();
        public FormatMovieUC()
        {
            InitializeComponent();
            LoadFormatMovie();
        }

        private void LoadFormatMovie()
        {
            dtgvFormatMovie.DataSource = formatList;
            LoadFormatMovieList();
            LoadMovieIDIntoCombobox(cbxMovieID);
            LoadScreenIDIntoCombobox(cbxScreenID);
            AddFormatBinding();
        }

        private void AddFormatBinding()
        {
            txtFormatID.DataBindings.Add("Text", dtgvFormatMovie.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }

        private void LoadScreenIDIntoCombobox(ComboBox cbx)
        {
            cbx.DataSource = TypeScreenDAO.GetListTypeScreen();
            cbx.DisplayMember = "ID";
            cbx.ValueMember = "ID";
        }

        private void LoadMovieIDIntoCombobox(ComboBox cbx)
        {
            cbx.DataSource = MovieDAO.GetListMovie();
            cbx.DisplayMember = "ID";
            cbx.ValueMember = "ID";
        }

        private void LoadFormatMovieList()
        {
            formatList.DataSource = FormatMovieDAO.GetListFormatMovie();
        }

        private void cbxMovieID_SelectedValueChanged(object sender, EventArgs e)
        {
            Movie movieSelected = cbxMovieID.SelectedItem as Movie;
            txtMovieName.Text = movieSelected.Name;
        }

        private void cbxScreenID_SelectedValueChanged(object sender, EventArgs e)
        {
            TypeScreen screenTypeSelected = cbxScreenID.SelectedItem as TypeScreen;
            txtScreenName.Text = screenTypeSelected.Name;
        }

        private void txtFormatID_TextChanged(object sender, EventArgs e)
        {
            string movieID = (string)dtgvFormatMovie.SelectedCells[0].OwningRow.Cells["Mã phim"].Value;
            Movie movieSelecting = MovieDAO.GetMovieByID(movieID);
            //This is the Movie that we're currently selecting in dtgv

            if (movieSelecting == null)
                return;

            //cboFormat_MovieID.SelectedItem = movieSelecting;

            int indexMovie = -1;
            int iMovie = 0;
            foreach (Movie item in cbxMovieID.Items)
            {
                if (item.Name == movieSelecting.Name)
                {
                    indexMovie = iMovie;
                    break;
                }
                iMovie++;
            }
            cbxMovieID.SelectedIndex = indexMovie;


            string screenName = (string)dtgvFormatMovie.SelectedCells[0].OwningRow.Cells["Tên MH"].Value;
            TypeScreen screenTypeSelecting = TypeScreenDAO.GetTypeScreenByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            if (screenTypeSelecting == null)
                return;

            //cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

            int indexScreen = -1;
            int iScreen = 0;
            foreach (TypeScreen item in cbxScreenID.Items)
            {
                if (item.Name == screenTypeSelecting.Name)
                {
                    indexScreen = iScreen;
                    break;
                }
                iScreen++;
            }
            cbxScreenID.SelectedIndex = indexScreen;
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadFormatMovieList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            string movieID = cbxMovieID.SelectedValue.ToString();
            string screenID = cbxScreenID.SelectedValue.ToString();
            InsertFormat(formatID, movieID, screenID);
            LoadFormatMovieList();
        }

        private void InsertFormat(string formatID, string movieID, string screenID)
        {
            try
            {
                if (FormatMovieDAO.InsertFormatMovie(formatID, movieID, screenID))
                {
                    MessageBox.Show("Thêm định dạng thành công");
                }
                else
                {
                    MessageBox.Show("Thêm định dạng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            string movieID = cbxMovieID.SelectedValue.ToString();
            string screenID = cbxScreenID.SelectedValue.ToString();
            UpdateFormat(formatID, movieID, screenID);
            LoadFormatMovieList();
        }

        private void UpdateFormat(string formatID, string movieID, string screenID)
        {
           try 
            {
                if (FormatMovieDAO.UpdateFormatMovie(formatID, movieID, screenID))
                {
                    MessageBox.Show("Sửa định dạng thành công");
                }
                else
                {
                    MessageBox.Show("Sửa định dạng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            DeleteFormat(formatID);
            LoadFormatMovieList();
        }

        private void DeleteFormat(string formatID)
        {
            try
            {
                if (FormatMovieDAO.DeleteFormatMovie(formatID))
                {
                    MessageBox.Show("Xóa định dạng thành công");
                }
                else
                {
                    MessageBox.Show("Xóa định dạng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
