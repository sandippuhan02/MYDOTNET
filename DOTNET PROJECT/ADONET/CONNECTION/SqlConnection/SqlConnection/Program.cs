using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace SqlConnectionDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Connection();
            Console.ReadLine();
        }
        public static void Connection()
        {
           string ConnectionString = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(ConnectionString);
                if( conn != null)
                {
                    Console.WriteLine("Connection established Sucessfully");
                }
                conn.Open();
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message );
            }
            finally
            {
                conn.Close();
            }

           
        }
    }
}
