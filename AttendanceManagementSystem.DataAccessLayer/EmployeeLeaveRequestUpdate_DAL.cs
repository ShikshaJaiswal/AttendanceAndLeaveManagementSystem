using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AttendanceManagementSystem.EntityLayer;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class EmployeeLeaveRequestUpdate_DAL
    {
        public static void AddLeaveRequest(AddLeaveRequest_EL e)
        {
            //write code to update column statusOfRequest column in LeaveRequests
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spAddLeaveRequest",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };
                //passing values to sql parameter

                cmd.Parameters.AddWithValue("@EmpId", e.EmpId);
                cmd.Parameters.AddWithValue("@ReqStartDate", e.ReqStartDate);
                cmd.Parameters.AddWithValue("@ReqEndDate", e.ReqEndDate);
                cmd.Parameters.AddWithValue("@ReqStatus", default);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }


                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        public static void DeleteLeaveRequest(DelLeaveRequest_EL e)
        {
            //write code to update column statusOfRequest column in LeaveRequests
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spDelLeaveRequest",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };
                //passing values to sql parameter

                cmd.Parameters.AddWithValue("@EmpId", e.EmpId);
               
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                }


                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}

