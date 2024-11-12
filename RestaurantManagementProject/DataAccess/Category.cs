﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess
{
    public class Category
    {
        // ID của bảng, tự tăng trong CSDL 
        public int ID { get; set; }
        // Tên của loại thức ăn 
        public string Name { get; set; }
        // Kiểu: 0 là đố uống; 1 là thức ăn... 
        public int Type { get; set; }
    }

    //Lớp quản lý Category: DA = DataAccess
}


