using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AttendanceManagementSystem.EntityLayer;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class UpdatePendingLeaveRequest_DAL
    {
        public static void UpdatePendingLeaveRequest(UpdatePendingLeaveRequest_EL e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spUpdatePendingLeaveRequest",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };
                //passing values to sql parameter

                cmd.Parameters.AddWithValue("@EmpId", e.EmpId);
                cmd.Parameters.AddWithValue("@ReqStatus", e.ReqStatus);


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
