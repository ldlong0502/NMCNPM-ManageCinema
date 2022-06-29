﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyRapPhim.DTO
{
    public class TypeScreen
    {
        public TypeScreen(string iD, string name)
        {
            this.ID = iD;
            this.Name = name;
        }

        public TypeScreen(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["TenMH"].ToString();
        }

        public string ID { get; set; }

        public string Name { get; set; }
    }
}
