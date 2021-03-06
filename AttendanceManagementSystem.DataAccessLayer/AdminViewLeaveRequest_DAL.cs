using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class AdminViewLeaveRequest_DAL
    {
        public static void AdminViewLeaveRequest()
        {
            //write code to view Attendance of employees of a particular project for a particular date.
            //take attendance from attendance table for the dates during which the project works.
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlDataReader rd;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spViewLeaveRequest",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure,
                };
                //passing values to sql parameter

                
                try
                {
                    con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("EmpId:{0} ReqStartDate: {1} ReqEndDate: {2} ReqStatus: {3}", rd["EmpId"], rd["ReqStartDate"], rd["ReqEndDate"], rd["ReqStatus"]);
                        }
                    }
                    rd.Close();


                }


                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
