using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Login_DAL
    {  

        public static bool LoginDetailsAdmin(string username, string password)
        {

            SqlConnection conA = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "spManagerLogin",
                Connection = conA,
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                conA.Open();
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Pass", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


            finally
            {
                conA.Close();
            }

        }
        public static bool LoginDetailsEmp(int EmpId, string username, string password)
        {


            SqlConnection conE = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "spEmployeeLogin",
                Connection = conE,
                CommandType = CommandType.StoredProcedure
            };
            try
            {

                conE.Open();
                cmd.Parameters.AddWithValue("@EmpId", EmpId);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@Pass", password);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {

                    return true;
                }
                else
                {

                    return false;

                }

            }

            finally
            {
                conE.Close();
            }


        }
    }
}

