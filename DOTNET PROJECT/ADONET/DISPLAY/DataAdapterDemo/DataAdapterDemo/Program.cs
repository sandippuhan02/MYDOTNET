using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAdapterDemo
{
    public   class Program
    {
        public static void Main(string[] args)
        {
            Connection();
        }
        public static void Connection()
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString;
            string query = "select * from Student";
            //--Connection part
            SqlConnection con = new SqlConnection(connectionstring);


            //SqlCommand  cmd = new SqlCommand(query, con);
            //con.Open();
            //SqlDataReader reader = cmd.ExecuteReader();
            //con.Close();

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            foreach( DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2}", row[0], row[1], row[2]);

            }

            Console.WriteLine("==Through DataTable==");
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2}", row[0], row[1], row[2]);

            }
            Console.ReadLine();



        }
    }
}
