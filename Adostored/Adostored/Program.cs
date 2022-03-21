using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Adostored
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cs = "data source=DESKTOP-O9TSFB5 SQLEXPRESS;database=employeeemanagement;integrated security=true";
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "spGetCode_EmployeeByEMPNO";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter param1 = new SqlParameter
                    {
                        ParameterName = "@EMPNO",
                        SqlDbType = SqlDbType.Int,
                        Value = 1,
                        Direction = ParameterDirection.Input
                    };
                    cmd.Parameters.Add(param1);

                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    Console.WriteLine("employees data");
                    while(rd.Read())
                    {
                        Console.WriteLine(rd[0] +","+rd[1]+","+rd[2]+","+rd[3]);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
