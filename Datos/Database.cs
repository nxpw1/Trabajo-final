﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Database
    {
        private SqlConnection conn;
        public SqlConnection ConectaDB()
        {
            try
            {
                string cadenaconexion = "Data Source=DESKTOP-6TCFH1F; Initial Catalog=dbLibreria; Integrated Security=true";
                conn = new SqlConnection(cadenaconexion);
                conn.Open();
                return conn;
            }
            catch (SqlException e)
            {
                return null;
            }
        }
        public void DesconectaDB()
        {
            conn.Close();
        }
    }
}
