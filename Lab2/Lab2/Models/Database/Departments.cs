using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab2.Models.Database
{
    public class Departments
    {
        SqlConnection conn;
        public Departments(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Department a)
        {
            string query = "Insert into Departments values(@name)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", a.Name);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Department> GetAll()
        {
            List<Department> departments = new List<Department>();
            string query = "select * from Departments";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department a = new Department();
                a.Id = reader.GetInt32(reader.GetOrdinal("id"));
                a.Name = reader.GetString(reader.GetOrdinal("Name"));
                departments.Add(a);
            }
            conn.Close();
            return departments;
        }
        public Department Get(int id)
        {
            Department a = null;
            string query = $"select * from Departments Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                a = new Department()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
            }
            conn.Close();
            return a;
        }
        public void Update(Department a)
        {
            string query = $"Update Departments Set Name='{a.Name}' Where Id = {a.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int a)
        {
            string query = $"Delete from Departments Where Id={a}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}