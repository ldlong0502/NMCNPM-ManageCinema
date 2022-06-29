using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class Genre
    {
        public Genre(string id, string name, string desc = null)
        {
            this.ID = id;
            this.Name = name;
            this.Desc = desc;
        }

        public Genre(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["TenTheLoai"].ToString();
            if (row["MoTa"].ToString() != "")
                this.Desc = row["MoTa"].ToString();
            else
                this.Desc = "";
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public string Desc { get; set; }
    }
}

