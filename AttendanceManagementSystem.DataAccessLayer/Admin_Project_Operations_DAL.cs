using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using AttendanceManagementSystem.EntityLayer;
using System.Data;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Project_Operations_DAL
    {
        public static void AddProject(AddProject_EL e)
        {
            //write code to add project in ProjectDetails

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spAddProject",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };

                //passing values to sql parameter
                
                cmd.Parameters.AddWithValue("@ProjName", e.ProjName);
                cmd.Parameters.AddWithValue("@ProjectTechnology", e.ProjectTechnology);
                cmd.Parameters.AddWithValue("@Startdate", e.Startdate);
                cmd.Parameters.AddWithValue("@Enddate", e.Enddate);

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
        public static void DeleteProject(DelProject_EL e)
        {
            //write code to delete project in ProjectDetails 
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "spDeleteProject",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure
                    };
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

        public static void UpdateProject(UpdateProject_EL e)
        {
            //write code to edit project in ProjectDetails
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
                {

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "spUpdateProject",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@ProjectId", e.ProjectId);

                    cmd.Parameters.AddWithValue("@ProjName", e.ProjName);
                    cmd.Parameters.AddWithValue("@ProjectTechnology", e.ProjectTechnology);
                    cmd.Parameters.AddWithValue("@Startdate", e.Startdate);
                    cmd.Parameters.AddWithValue("@Enddate", e.Enddate);


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
