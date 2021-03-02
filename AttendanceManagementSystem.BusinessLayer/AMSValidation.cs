using System;
using System.Data.SqlClient;
using System.Data;


using System.Text;
namespace AttendanceManagementSystem.BusinessLayer
{/*
    public class AMSValidation
    {
        
        public static bool ValidateUserIdAndPasswordAdmin()
        {
            
             SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;");
            try
            {
                con.Open();
                SqlDataReader sdr = new SqlDataReader("Select COUNT (*)FROM MgrLogin WHERE UserName=" + username + " ", +"and Pass=" + password + " ", con);
                DataTable dt = new DataTable();
                if (dt.Rows[0][0].ToString() == 1)
                {
                    Console.WriteLine("Login successful");
                    return true;
                    
                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                    return false;
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex.Message");
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public static bool ValidateUserIdAndPasswordEmp()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;");
                try
                {
                con.Open();
                SqlDataReader sdr = new SqlDataReader("Select COUNT (*)FROM EmpLogin WHERE UserName=" + username + " ", +"and Pass=" + password + " ", con);
                DataTable dt = new DataTable();
                if (dt.Rows[0][0].ToString() == 1)
                {
                    
                    Console.WriteLine("Login successful");
                    return true;

                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                    return false;
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex.Message");
                return false;
            }
            finally
            {
                con.Close();
            }


        }
    }
    */
}
