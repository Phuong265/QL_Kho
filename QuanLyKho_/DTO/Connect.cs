﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace DTO
{
    public class Connect
    {
        public static SqlConnection GetSqlConnection()
        {
            return DAL.DBConnect.SqlConnect;
        }
        public static void SetConnectString(string connect_string)
        {
            DAL.DBConnect.DirectoryConnect = connect_string;
        }
        public static string GetConnectString()
        {
            return DAL.DBConnect.DirectoryConnect;
        }
        public static bool Open()
        {
            if (DAL.DBConnect.DirectoryConnect == null) return false;
            DAL.DBConnect.Connect();
            if (DAL.DBConnect.SqlConnect == null) return false;
            return true;
        }
        public static void Close()
        {
            if (DAL.DBConnect.SqlConnect != null) DAL.DBConnect.SqlConnect.Close();
        }
    }
}
