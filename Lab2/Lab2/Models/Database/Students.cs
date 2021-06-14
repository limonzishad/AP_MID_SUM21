using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Lab2.Models.Database
{
    public class Students
    {
        SqlConnection conn;
        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student a)
        {
            string query = "Insert into Students values(@name, @dob, @credit, @cgpa, @deptid)";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@name", a.Name);
            cmd.Parameters.AddWithValue("@dob", a.Dob.ToString());
            cmd.Parameters.AddWithValue("@credit", a.Credit);
            cmd.Parameters.AddWithValue("@cgpa", a.CGPA);
            cmd.Parameters.AddWithValue("@deptid", a.Deptid);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Student a = new Student();

                a.Id = reader.GetInt32(reader.GetOrdinal("id"));
                a.Name = reader.GetString(reader.GetOrdinal("name"));
                a.Dob = reader.GetString(reader.GetOrdinal("dob"));
                a.Credit = reader.GetInt32(reader.GetOrdinal("credit"));
                a.CGPA = reader.GetDouble(reader.GetOrdinal("cgpa"));
                a.Deptid = reader.GetInt32(reader.GetOrdinal("dept_id"));
                students.Add(a);
            }
            conn.Close();
            return students;
        }
        public Student Get(int id)
        {
            Student a = null;
            string query = $"select * from Students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                a = new Student()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                    Dob = reader.GetString(reader.GetOrdinal("dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("cgpa")),
                    Deptid = reader.GetInt32(reader.GetOrdinal("dept_id")),
                };
            }
            conn.Close();
            return a;
        }
        public void Update(Student a)
        {
            float cgpaa = Convert.ToSingle(a.CGPA);
            string query = $"Update Students Set Name='{a.Name}', Dob='{a.Dob}' ,Credit={a.Credit}, Cgpa={a.CGPA}, Deptid={a.Deptid} Where Id={a.Id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void Delete(int a)
        {
            string query = $"Delete from Students Where Id={a}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}