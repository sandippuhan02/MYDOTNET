using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAdapterDemo
{
    public class DTableDemo
    {
        public static void Main(string[] args)
        {
            try
            {
             DataTable employees = new DataTable("employees");
                DataColumn roll = new DataColumn("roll")
                {
                    Caption = "Emp_roll",
                    DataType = typeof(int),
                   AllowDBNull = false,
                   AutoIncrement = true,
                   AutoIncrementSeed = 10,
                   AutoIncrementStep = 5
                  

                };


                employees.Columns.Add(roll);
                employees.PrimaryKey = new DataColumn[] { roll };


                DataColumn id = new DataColumn("id");
                id.Caption = "Emp_Id";
                //id.DataType = typeof(int);
                id.DataType = System.Type.GetType("System.Int32");

                id.DataType = typeof(int);
                id.AllowDBNull = false;
                employees.Columns.Add(id);

                DataColumn name = new DataColumn("name");
                name.Caption = "Emp_Name";
                name.DataType = typeof(string);
                name.AllowDBNull = false;
                name.MaxLength = 50;
                employees.Columns.Add(name);


                DataColumn gender = new DataColumn("gender");
                gender.Caption = "Emp_Gender";
                gender.DataType = typeof(string);
                gender.AllowDBNull = false;
                gender.MaxLength = 20;

                employees.Columns.Add(gender);

                DataColumn city = new DataColumn("city")
                {
                    Caption = "Emp_City",
                    DataType = typeof(string),
                    AllowDBNull = false,
                    MaxLength = 20

                };
                employees.Columns.Add(city);

                //adding Rows into datatable
                DataRow row1 = employees.NewRow();
                row1["id"] = 10;
                row1["name"] = "Sandip";
                row1["gender"] = "Male";
                row1["city"] = "ODISHA";
                employees.Rows.Add(row1);

                employees.Rows.Add(11, "pintu", "male", "BLS");
                employees.Rows.Add(12, "sangram", "male", "JG");

                //Displaying our data
                foreach(DataRow row in employees.Rows)
                {
                    Console.WriteLine(row["id"]+" " + row["name"]+" " + row["gender"]+" " + row["city"]);
                }
            }
            catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
