﻿using QuanLyRapPhim.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DAO
{
    public class MovieDAO
    {
        //ảnh -> byte[]
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        //byte[] -> ảnh
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static List<Movie> GetListMovieByDate(DateTime date)
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Phim where @Date <= NgayKetThuc", new object[] { date });
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }

        public static List<Movie> GetListMovieByName(String movieName)
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetListMovieByName @tenPhim ", new object[] { movieName });
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }
        public static List<Movie> GetListMovie()
        {
            List<Movie> listMovie = new List<Movie>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Phim");
            foreach (DataRow row in data.Rows)
            {
                Movie movie = new Movie(row);
                listMovie.Add(movie);
            }
            return listMovie;
        }

        public static DataTable GetMovie()
        {
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetMovie");
        }

        public static bool InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string nation, string director,string actor,int year, byte[] image)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_InsertMovie @id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @nuocSanXuat , @daoDien , @dienVien , @namSanXuat , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, nation, director, actor, year, image });
            return result > 0;
        }

        public static bool UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string nation, string director,string actor, int year, byte[] image)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC USP_UpdateMovie @id , @tenPhim , @moTa , @thoiLuong , @ngayKhoiChieu , @ngayKetThuc , @sanXuat , @daoDien , @dienVien , @namSX , @apPhich ", new object[] { id, name, desc, length, startDate, endDate, nation, director, actor, year, image });
            return result > 0;
        }

        public static bool DeleteMovie(string id)
        {
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.PhanLoaiPhim WHERE idPhim = '" + id + "'");
            DataProvider.Instance.ExecuteNonQuery("DELETE dbo.DinhDangPhim WHERE idPhim = '" + id + "'");

            MovieClassifyDAO.DeleteMovie_GenreByMovieID(id);
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.Phim WHERE id = '" + id + "'");
            return result > 0;
        }

        public static Movie GetMovieByID(string id)
        {
            Movie movie = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Phim WHERE id = '" + id + "'");
            foreach (DataRow item in data.Rows)
            {
                movie = new Movie(item);
                return movie;
            }
            return movie;
        }
    }
}
