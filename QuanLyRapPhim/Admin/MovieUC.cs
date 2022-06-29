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
    public partial class MovieUC : UserControl
    {
        BindingSource movieList = new BindingSource();
        public MovieUC()
        {
            InitializeComponent();
            LoadMovie();
        }

        private void LoadMovie()
        {
            dgVMovie.DataSource = movieList;
            LoadMovieList();
            AddMovieBinding();
        }

        private void AddMovieBinding()
        {
            txtMovieID.DataBindings.Add("Text", dgVMovie.DataSource, "Mã phim", true, DataSourceUpdateMode.Never);
            txtMovieName.DataBindings.Add("Text", dgVMovie.DataSource, "Tên phim", true, DataSourceUpdateMode.Never);
            txtDescripe.DataBindings.Add("Text", dgVMovie.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
            txtMovieLength.DataBindings.Add("Text", dgVMovie.DataSource, "Thời lượng", true, DataSourceUpdateMode.Never);
            dtpDayStart.DataBindings.Add("Value", dgVMovie.DataSource, "Ngày khởi chiếu", true, DataSourceUpdateMode.Never);
            dtpDayEnd.DataBindings.Add("Value", dgVMovie.DataSource, "Ngày kết thúc", true, DataSourceUpdateMode.Never);
            txtNation.DataBindings.Add("Text", dgVMovie.DataSource, "Nước sản xuất", true, DataSourceUpdateMode.Never);
            txtDirector.DataBindings.Add("Text", dgVMovie.DataSource, "Đạo diễn", true, DataSourceUpdateMode.Never);
            txtActor.DataBindings.Add("Text", dgVMovie.DataSource, "Diễn viên", true, DataSourceUpdateMode.Never);
            txtYear.DataBindings.Add("Text", dgVMovie.DataSource, "Năm sản xuất", true, DataSourceUpdateMode.Never);
            LoadGenreIntoCheckedList(clbGenre);
        }

        private void LoadGenreIntoCheckedList(CheckedListBox clb)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            clb.DataSource = genreList;
            clb.DisplayMember = "Name";
        }

        private void LoadMovieList()
        {
            movieList.DataSource = MovieDAO.GetMovie();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSee_Click(object sender, EventArgs e)
        {
            LoadMovieList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            string movieName = txtMovieName.Text;
            string movieDesc = txtDescripe.Text;
            float movieLength = float.Parse(txtMovieLength.Text);
            DateTime startDate = dtpDayStart.Value;
            DateTime endDate = dtpDayEnd.Value;
            string nation = txtNation.Text;
            string director = txtDirector.Text;
            string actor = txtActor.Text;
            int year = int.Parse(txtYear.Text);
            if (picFilm.Image == null)
            {
                MessageBox.Show("Mời bạn thêm hình ảnh cho phim trước");
                return;
            }
            InsertMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, nation, director,actor, year, MovieDAO.imageToByteArray(picFilm.Image));
            InsertMovie_Genre(movieID, clbGenre);
            LoadMovieList();
        }
        private void txtMovieID_TextChanged(object sender, EventArgs e)
        //Use to binding the CheckedListBox Genre of Movie and picture of Movie
        {
            picFilm.Image = null;
            for (int i = 0; i < clbGenre.Items.Count; i++)
            {
                clbGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }

            List<Genre> listGenreOfMovie = MovieClassifyDAO.GetListGenreByMovieID(txtMovieID.Text);
            for (int i = 0; i < clbGenre.Items.Count; i++)
            {
                Genre genre = (Genre)clbGenre.Items[i];
                foreach (Genre item in listGenreOfMovie)
                {
                    if (genre.ID == item.ID)
                    {
                        clbGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            Movie movie = MovieDAO.GetMovieByID(txtMovieID.Text);

            if (movie == null)
                return;

            if (movie.Poster != null)
                picFilm.Image = MovieDAO.byteArrayToImage(movie.Poster);
        }
        private void InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string nation, string director,string actor, int year, byte[] image)
        {
            try {
                if (MovieDAO.InsertMovie(id, name, desc, length, startDate, endDate, nation, director, actor, year, image))
                {
                    MessageBox.Show("Thêm phim thành công");
                }
                else
                {
                    MessageBox.Show("Thêm phim thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void InsertMovie_Genre(string movieID, CheckedListBox clb)
        //Insert into table 'PhanLoaiPhim'
        {
            List<Genre> checkedGenreList = new List<Genre>();
            foreach (Genre checkedItem in clb.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieClassifyDAO.InsertMovie_Genre(movieID, checkedGenreList);
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    picFilm.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            DeleteMovie(movieID);
            LoadMovieList();
        }

        private void DeleteMovie(string id)
        {
            try
            {
                if (MovieDAO.DeleteMovie(id))
                {
                    MessageBox.Show("Xóa phim thành công");
                }
                else
                {
                    MessageBox.Show("Xóa phim thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()); 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            string movieName = txtMovieName.Text;
            string movieDesc = txtDescripe.Text;
            float movieLength = float.Parse(txtMovieLength.Text);
            DateTime startDate = dtpDayStart.Value;
            DateTime endDate = dtpDayEnd.Value;
            string nation = txtNation.Text;
            string director = txtDirector.Text;
            string actor = txtActor.Text;
            int year = int.Parse(txtYear.Text);
            if (picFilm.Image == null)
            {
                MessageBox.Show("Mời bạn thêm hình ảnh cho phim trước");
                return;
            }
            UpdateMovie(movieID, movieName, movieDesc, movieLength, startDate, endDate, nation, director, actor, year, MovieDAO.imageToByteArray(picFilm.Image));
            UpdateMovie_Genre(movieID, clbGenre);
            LoadMovieList();
        }

        private void UpdateMovie_Genre(string movieID, CheckedListBox clbGenre)
        {
            try
            {
                List<Genre> checkedGenreList = new List<Genre>();
                foreach (Genre checkedItem in clbGenre.CheckedItems)
                {
                    checkedGenreList.Add(checkedItem);
                }
                MovieClassifyDAO.UpdateMovie_Genre(movieID, checkedGenreList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }

        private void UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string nation, string director, string actor, int year, byte[] image)
        {
            try
            {
                if (MovieDAO.UpdateMovie(id, name, desc, length, startDate, endDate, nation, director, actor, year, image))
                {
                    MessageBox.Show("Sửa phim thành công");
                }
                else
                {
                    MessageBox.Show("Sửa phim thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "error");
            }
        }
    }
}
