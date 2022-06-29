using QuanLyRapPhim.DAO;
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
    public partial class GenreUC : UserControl
    {
        BindingSource genreList = new BindingSource();
        public GenreUC()
        {
            InitializeComponent();
            LoadGenre();
        }
        private void LoadGenre()
        {
            dgVGenre.DataSource = genreList;
            LoadGenreList();
            AddGenreBinding();
        }
        private void LoadGenreList()
        {
            genreList.DataSource = GenreDAO.GetGenre();
        }
        private void AddGenreBinding()
        {
            txtGenreID.DataBindings.Add("Text", dgVGenre.DataSource, "Mã thể loại", true, DataSourceUpdateMode.Never);
            txtGenreName.DataBindings.Add("Text", dgVGenre.DataSource, "Tên thể loại", true, DataSourceUpdateMode.Never);
            txtGenreDescripe.DataBindings.Add("Text", dgVGenre.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            string GenreName = txtGenreName.Text;
            string GenreDesc = txtGenreDescripe.Text;
            InsertGenre(GenreID, GenreName, GenreDesc);
            LoadGenreList();
        }

        private void InsertGenre(string genreID, string genreName, string genreDesc)
        {
            try
            {
                if (GenreDAO.InsertGenre(genreID, genreName, genreDesc))
                {
                    MessageBox.Show("Thêm thể loại thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thể loại thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadGenreList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            string GenreName = txtGenreName.Text;
            string GenreDesc = txtGenreDescripe.Text;
            UpdateGenre(GenreID, GenreName, GenreDesc);
            LoadGenreList();
        }

        private void UpdateGenre(string id, string name, string desc)
        {
            try
            {
                if (GenreDAO.UpdateGenre(id, name, desc))
                {
                    MessageBox.Show("Sửa thể loại thành công");
                }
                else
                {
                    MessageBox.Show("Sửa thể loại thất bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            DeleteGenre(GenreID);
            LoadGenreList();
        }

        private void DeleteGenre(string id)
        {
            try
            {
                if (GenreDAO.DeleteGenre(id))
                {
                    MessageBox.Show("Xóa thể loại thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thể loại thất bại");
                }

            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
