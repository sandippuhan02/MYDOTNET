using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandClassDemo
{
    public  class Program
    {
        public static string query = "select * from Student";
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
        public static void Main(string[] args)
        {
            Connection();
            Console.ReadLine();
        }

        public static void Connection()
        {
            SqlConnection con = null;
            SqlCommand command = null;
            SqlDataReader reader = null;
            //ConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            try
            {
                con= new SqlConnection(ConnectionString);
                if( con != null )
                {
                Console.WriteLine("Connection established");
                }
                command = new SqlCommand(query, con);
                con.Open();
                reader = command.ExecuteReader();
                if( reader != null)
                {
                    Console.WriteLine("Query Excuted and fetched result ");
                }
                while( reader.Read() )
                {
                    Console.WriteLine("RollNo :" + reader[0] + " " + "Name :" + reader["Name"] + " " + "Dept :" + reader["Dept"]);
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if( con != null )
                {
                    con.Close();
                }
            }
        }
    }
}
