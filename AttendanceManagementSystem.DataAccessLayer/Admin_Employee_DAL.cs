using System;
using System.Data;
using System.Data.SqlClient;
using AttendanceManagementSystem.EntityLayer;


namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Employee_DAL
    {

        public static void AddEmployee(AddEmployee_EL e)
        {

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "spAddEmployee",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure
                };
                //passing values to sql parameter
                
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
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
                {

                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "spDeleteEmployee",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure
                    };

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
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
                {
                    SqlCommand cmd = new SqlCommand
                    {
                        CommandText = "spUpdateEmployee",
                        Connection = con,
                        CommandType = CommandType.StoredProcedure
                    };
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
