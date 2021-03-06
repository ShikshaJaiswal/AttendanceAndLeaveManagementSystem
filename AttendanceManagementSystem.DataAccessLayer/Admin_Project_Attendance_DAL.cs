using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using AttendanceManagementSystem.EntityLayer;

namespace AttendanceManagementSystem.DataAccessLayer
{
    public class Admin_Project_Attendance_DAL
    {
        public static void ViewAttendanceByDate(ViewAttendanceByDate_EL e)
        {
            //write code to view Attendance of employees of a particular project for a particular date.
            //take attendance from attendance table for the dates during which the project works.
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlDataReader rd;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "ViewAttendanceByDate",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure,
                };
                //passing values to sql parameter

                cmd.Parameters.AddWithValue("@AttendanceDate", e.AttendanceDate);            
                
                
                try
                {
                    con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("EmpId:{0} AttendanceDate:{1} AttendanceStatus:{2}", rd["EmpId"], rd["AttendanceDate"], rd["AttendanceStatus"]);
                        }
                    }
                    rd.Close();

                    
                }


                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }

        public static void ViewWeeklyAttendance()
        {
            //write code to view Attendance of employees of a particular project for current week
            //take attendance from attendance table for the dates during which the project works.
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlDataReader rd;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "ViewAttendanceByWeek",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure,
                };
                


                try
                {
                    con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("EmpId:{0} AttendanceDate:{1} AttendanceStatus:{2}", rd["EmpId"], rd["AttendanceDate"], rd["AttendanceStatus"]);
                        }
                    }
                    rd.Close();


                }


                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        public static void ViewMonthlyAttendance()
        {
            //write code to view Attendance of employees of a particular project for current month. 
            //take attendance from attendance table for the dates during which the project works.
            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=ALMS;Integrated Security=True;"))
            {
                SqlDataReader rd;
                SqlCommand cmd = new SqlCommand
                {
                    CommandText = "ViewAttendanceByMonth",
                    Connection = con,
                    CommandType = CommandType.StoredProcedure,
                };



                try
                {
                    con.Open();
                    using (rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            Console.WriteLine("EmpId:{0} AttendanceDate:{1} AttendanceStatus:{2}", rd["EmpId"], rd["AttendanceDate"], rd["AttendanceStatus"]);
                        }
                    }
                    rd.Close();


                }


                catch (SqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
    }
