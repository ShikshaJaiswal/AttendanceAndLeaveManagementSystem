using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Project_Operations_DAL
    {
        public static void AddProject()
        {
            //write code to add project in ProjectDetails

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand("insert into ProjectDetails values(@ProjectId,@ProjName,@ProjectTechnology,@Startdate,@Enddate)", con);

                //passing values to sql parameter
                cmd.Parameters.AddWithValue("@ProjectId", Console.ReadLine());
                cmd.Parameters.AddWithValue("@ProjName", Console.ReadLine());
                cmd.Parameters.AddWithValue("@ProjectTechnology", Console.ReadLine());
                cmd.Parameters.AddWithValue("@Startdate", Console.ReadLine());
                cmd.Parameters.AddWithValue("@Enddate", Console.ReadLine());



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
        public static void DeleteProject()
        {
            //write code to delete project in ProjectDetails 
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {

                    SqlCommand cmd = new SqlCommand("Delete from ProjectDetails where ProjectId= @ProjectId", con);
                    Console.WriteLine("Enter ProjectId to delete record:");
                    cmd.Parameters.AddWithValue("@ProjectId", Console.ReadLine());
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void UpdateProject()
        {
            //write code to edit project in ProjectDetails
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                {

                    SqlCommand cmd = new SqlCommand("Update ProjectDetails set ProjName=@ProjName,ProjectTechnology=@ProjectTechnology,Startdate=@Startdate,Enddate=@Enddate Where ProjectId=@ProjectId", con);
                    Console.WriteLine("Enter ProjectId to update record:");

                    cmd.Parameters.AddWithValue("@ProjectId", Console.ReadLine());

                    cmd.Parameters.AddWithValue("@ProjName", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@ProjectTechnology", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@Startdate", Console.ReadLine());
                    cmd.Parameters.AddWithValue("@Enddate", Console.ReadLine());


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
