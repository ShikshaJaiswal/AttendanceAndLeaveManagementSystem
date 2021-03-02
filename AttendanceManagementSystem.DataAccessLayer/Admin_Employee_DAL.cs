using System;
using System.Data.SqlClient;
using AttendanceManagementSystem.EntityLayer;


namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Employee_DAL
    {

        public static void AddEmployee(AddEmployee_EL e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("insert into EmployeeDetails values(@EmpId,@EmpName,@EmpDesignation,@EmpDOB,@EmpAddress,@MgrId, @ProjectId)", con);

                //passing values to sql parameter
                cmd.Parameters.AddWithValue("@EmpId", e.EmpId);
                cmd.Parameters.AddWithValue("@EmpName", e.EmpName);
                cmd.Parameters.AddWithValue("@EmpDesignation", e.EmpDesignation);
                cmd.Parameters.AddWithValue("@EmpDOB", e.EpmDOB);
                cmd.Parameters.AddWithValue("@EmpAddress", e.EmpAddress);
                cmd.Parameters.AddWithValue("@MgrId", e.MgrId);
                cmd.Parameters.AddWithValue("@ProjectId", e.ProjectId);

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
        public static void DeleteEmployee(DelEmployee_EL e)
        {
            
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {

                    SqlCommand cmd = new SqlCommand("Delete from EmployeeDetails where EmpId= @EmpId", con);
                    
                    cmd.Parameters.AddWithValue("@EmpId", e.EmpId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void UpdateEmployee(UpdateEmployee_EL e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {

                    SqlCommand cmd = new SqlCommand("Update EmployeeDetails set EmpName=@EmpName,EmpDesignation=@EmpDesignation,EmpDOB=@EmpDOB,EmpAddress=@EmpAddress,MgrId=@MgrId, ProjectId=@ProjectId Where EmpId=@EmpId", con);
                    Console.WriteLine("Enter EmpId to update record:");

                    cmd.Parameters.AddWithValue("@EmpId", e.EmpId);

                    cmd.Parameters.AddWithValue("@EmpName", e.EmpDesignation);
                    cmd.Parameters.AddWithValue("@EmpDesignation", e.EmpDesignation);
                    cmd.Parameters.AddWithValue("@EmpDOB", e.EmpDOB);
                    cmd.Parameters.AddWithValue("@EmpAddress", e.EmpAddress);
                    cmd.Parameters.AddWithValue("@MgrId", e.MgrId);
                    cmd.Parameters.AddWithValue("@ProjectId", e.ProjectId);

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
