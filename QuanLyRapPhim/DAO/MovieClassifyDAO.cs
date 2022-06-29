using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class MovieClassifyDAO
    {
        public static List<Genre> GetListGenreByMovieID(string id)
        {
            List<Genre> genreList = new List<Genre>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListGenreByMovie @idPhim", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                Genre genre = new Genre(item);
                genreList.Add(genre);
            }
            return genreList;
        }
        public static List<String> GetListMovieIdByGenreId(string id)
        {
            List<String> listMovieID = new List<String>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListMovieIdByGenreId @idGenre", new object[] { id });
            foreach (DataRow item in data.Rows)
            {
                String Movieid = item["idPhim"].ToString();
                listMovieID.Add(Movieid);
            }
            return listMovieID;
        }


        public static void InsertMovie_Genre(string movieID, List<Genre> genreList)
        {
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.Instance.ExecuteNonQuery(command);
            }
        }

        public static void UpdateMovie_Genre(string movieID, List<Genre> genreList)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + movieID + "'");
            foreach (Genre item in genreList)
            {
                string command = string.Format("INSERT dbo.PhanLoaiPhim (idPhim, idTheLoai) VALUES  ('{0}','{1}')", movieID, item.ID);
                DataProvider.Instance.ExecuteNonQuery(command);
            }
        }

        public static void DeleteMovie_GenreByMovieID(string movieID)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + movieID + "'");
        }
    }
}
