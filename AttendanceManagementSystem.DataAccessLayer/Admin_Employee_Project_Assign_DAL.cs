using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using AttendanceManagementSystem.EntityLayer;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Employee_Project_Assign_Dal
    {
        public static void AssignProject(AssignProject_EL e) { 
         try
            {
                //write code to update ProjId column of EmployeeDetails ie. update it with the 
                //empId of employee to whom the project is assigned.
                //Connecting a database using connection object
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
                {
                    //sql statement for assigning a Project to newly added employee
                    string cmdText = @"Update EmployeeDetails set ProjectId=@ProjectId where EmpId=@EmpId and ProjectId= 'N/A'";
                    SqlCommand cmd = new SqlCommand(cmdText, con);
                                       
                    cmd.Parameters.AddWithValue("@EmpId", e.EmpId);
                   
                    cmd.Parameters.AddWithValue("@ProjectId", e.ProjectId);
                    //Opening the connection
                    con.Open();
                    //executing the command
                    cmd.ExecuteNonQuery();
                    //closing the connection
                    con.Close();
                }
}
            catch (SqlException ex)
{
    Console.WriteLine(ex.Message);
}

        }
    }
}
