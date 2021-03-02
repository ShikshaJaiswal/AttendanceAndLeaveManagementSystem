using System;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Employee_DAL
    {

        public static void AddEmployee()
        {
            
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand("insert into EmployeeDetails values(@EmpId,@EmpName,@EmpDesignation,@EmpDOB,@EmpAddress,@MgrId)", con);

                    //passing values to sql parameter
                    cmd.Parameters.AddWithValue("@EmpId", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpName", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpDesignation", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpDOB", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpAddress", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@MgrId", Console.ReadLine());

                    
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
        public static void DeleteEmployee()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {
                    
                    SqlCommand cmd = new SqlCommand("Delete from EmployeeDetails where EmpId= @EmpId" , con);
                    Console.WriteLine("Enter EmpId to delete record:");
                    cmd.Parameters.AddWithValue("@EmpId", Console.ReadLine());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateEmployee()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {
                    
                    SqlCommand cmd = new SqlCommand("Update EmployeeDetails set EmpName=@EmpName,EmpDesignation=@EmpDesignation,EmpDOB=@EmpDOB,EmpAddress=@EmpAddress,MgrId=@MgrId Where EmpId=@EmpId", con);
                    Console.WriteLine("Enter EmpId to update record:");

                    cmd.Parameters.AddWithValue("@EmpId", Console.ReadLine());

                    cmd.Parameters.AddWithValue("@EmpName", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpDesignation", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpDOB", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@EmpAddress", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@MgrId", Console.ReadLine());

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
