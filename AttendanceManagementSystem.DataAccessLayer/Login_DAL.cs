using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Login_DAL
    {  

        public static bool LoginDetailsAdmin(string username, string password)
        {

            SqlConnection conA = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select *from MgrLogin where UserName=@UserName and Pass=@Pass", conA);
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
        public static bool LoginDetailsEmp(string username, string password)
        {


            SqlConnection conE = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;");
            SqlCommand cmd = new SqlCommand("select *from EmpLogin where UserName=@UserName and Pass=@Pass", conE);
            try
            {

                conE.Open();
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

