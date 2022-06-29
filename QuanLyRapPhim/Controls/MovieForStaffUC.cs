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

namespace QuanLyRapPhim.Controls
{
    public partial class MovieForStaffUC : UserControl
    {
        List<Movie> listMovie = MovieDAO.GetListMovie();
        public MovieForStaffUC()
        {
            InitializeComponent();
            LoadMovieForm();
            LoadGenreIntoCheckedList(clbGenre);
        }

        private void LoadMovieForm()
        {
            flowLayoutMovie.Controls.Clear();
            for (int i = 0; i < listMovie.Count; i++)
            {

                Image image = MovieDAO.byteArrayToImage(listMovie[i].Poster);
                List<FormatMovie> formats = FormatMovieDAO.GetListFormatMovieByMovie(listMovie[i].ID);
                CardMovie cardMovie = new CardMovie(listMovie[i].Name, formats, image, listMovie[i]);
                cardMovie.Margin = new Padding(20, 40, 0, 0);
                flowLayoutMovie.Controls.Add(cardMovie);
            }
        }

        private void ptrSearch_Click(object sender, EventArgs e)
        {
            SearchMovie();
        }
        private void LoadGenreIntoCheckedList(CheckedListBox clb)
        {
            List<Genre> genreList = GenreDAO.GetListGenre();
            clb.DataSource = genreList;
            clb.DisplayMember = "Name";
        }

        private void clbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchMovie();
            
        }

        private void SearchMovie()
        {
            if (txtSearchByMovieName.Text.Length == 0)
            {
                if (clbGenre.CheckedItems.Count == 0)
                {
                    listMovie = MovieDAO.GetListMovie();
                    LoadMovieForm();
                    return;
                }
                listMovie.Clear();
                for (int i = 0; i < clbGenre.CheckedItems.Count; i++)
                {
                    Genre item = (Genre)clbGenre.CheckedItems[i];
                    List<String> list = MovieClassifyDAO.GetListMovieIdByGenreId(item.ID);
                    foreach (String s in list)
                    {
                        Movie movie = MovieDAO.GetMovieByID(s);
                        if (!listMovie.Contains(movie))
                        {
                            listMovie.Add(movie);
                        }
                    }
                }
                LoadMovieForm();
            }
            else
            {
                listMovie = MovieDAO.GetListMovieByName(txtSearchByMovieName.Text);
                if (clbGenre.CheckedItems.Count == 0)
                {
                    LoadMovieForm();
                }
                else
                {
                    List<Movie> movies = new List<Movie>();
                    for (int i = 0; i < clbGenre.CheckedItems.Count; i++)
                    {
                        Genre item = (Genre)clbGenre.CheckedItems[i];
                        List<String> list = MovieClassifyDAO.GetListMovieIdByGenreId(item.ID);
                        foreach (String s in list)
                        {
                            Movie movie = MovieDAO.GetMovieByID(s);
                            if (checkItemInList(movies,movie) && checkItemInList(listMovie, movie))
                            {
                                movies.Add(movie);
                            }
                        }
                    }
                    listMovie.Clear();
                    listMovie = movies;
                    LoadMovieForm();
                }
            }

        }
        bool checkItemInList(List<Movie> list, Movie movie)
        {
            foreach (Movie item in list)
            {
                if(item.ID == movie.ID)
                    return true;
            }
            return false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clbGenre.Items.Count; i++)
            {
                clbGenre.SetItemChecked(i, false);
            }
            txtSearchByMovieName.Text = "";
            SearchMovie();

        }

    }
}
