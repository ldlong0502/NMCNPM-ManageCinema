using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyRapPhim.Controls;
using QuanLyRapPhim.DTO;

namespace QuanLyRapPhim.Controls
{

    public partial class CardMovie : UserControl
    {
        private string movie_name = "";
        private List<FormatMovie> format = new List<FormatMovie>();
        private Movie movie = new Movie();
        private Image image = Image.FromFile(@"C:\Users\LENOVO\Pictures\ImageMovie\1.jpg");
        
        public string Movie_name { get { return movie_name; } set { movie_name = value; } }
        public List<FormatMovie> Format { get { return format; } set { format = value; } }

        public Image Image
        {
            get { return image; } set { image = value; } 
        }
        public Movie Movie { get { return movie; } set { movie = value; } }
        public CardMovie(string movie_name , List<FormatMovie> listFormat, Image image, Movie movie)
        {
            Movie_name = movie_name;
            format = listFormat;
            Image = image;
            Movie = movie;
            InitializeComponent();
            btnMovie_name.Text = Movie_name + "\n";
            foreach (FormatMovie format in listFormat)
            {
                btnMovie_name.Text += format.ScreenTypeName + ' ';
            }
            ptrMovie.Image = Image;
        }

        private void btnMovie_name_Click(object sender, EventArgs e)
        {
            MovieShow moviePopUp = new MovieShow(movie,format,image);
            moviePopUp.ShowDialog();
        }
    }
}

