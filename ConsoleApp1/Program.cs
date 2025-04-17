using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();

        }
        public void CreateTable()
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection("Data Source=DESKTOP-74432MI\\SQLEXPRESS;Database=Sample;Integrated Security=True;TrustServerCertificate=True");
                SqlCommand s1 = new SqlCommand("select * from Akshara", conn);
                
                conn.Open();
                SqlDataReader reader = s1.ExecuteReader();
                while (reader.Read())
                {
                    // Adjust this according to your column types
                    Console.WriteLine("ID: " + reader["id"] + ", Name: " + reader["name"]);
                }

                reader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("HelloWorld");
            Console.WriteLine("Akshara ...........................");

        }
    }
}
