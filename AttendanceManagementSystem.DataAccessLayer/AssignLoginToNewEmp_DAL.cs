using System;
using System.Data;
using System.Data.SqlClient;
using AttendanceManagementSystem.EntityLayer;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class AssignLoginToNewEmp_DAL
    {

        public static void AssignLoginToNewEmp(AssignLoginToNewEmp_EL e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spAddNewLogin",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };
                //passing values to sql parameter

                cmd.Parameters.AddWithValue("@UserName", e.UserName);
                cmd.Parameters.AddWithValue("@Pass", e.Pass);
                
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
