using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab2.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public string Get(string username, string password)
        {
            
            string b = null;

            string query = $"select * from Admins Where Username='{username}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                b = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return b;
        }
    }
}