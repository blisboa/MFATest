﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MFATest
{
    public class BDComun
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=SCLNTB6310766\\INSTANCIA19;Initial Catalog=mfatest;Integrated Security=True");
            Conn.Open();

            return Conn;
        }
    }
}
