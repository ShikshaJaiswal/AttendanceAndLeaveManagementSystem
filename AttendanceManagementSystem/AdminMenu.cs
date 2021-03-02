using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;



namespace AttendanceManagementSystem.PresentationLayer
{
    class AdminMenu
    {
        public static void DisplayMenu()
        {
            char ans = 'y';
            do
            {
                Console.WriteLine("Choose the option from the Menu:");
                Console.WriteLine("1. Employee Information \n2. Project Information \n3. Assign project to employee \n4. View Pending leave requests \n5. View Project attendance");
                char option = Convert.ToChar(Console.ReadLine());


                switch (option)
                {
                    case '1':
                        char selected = 'y';
                        do
                        {
                            Console.WriteLine("Choose the option from the menu:");
                            Console.WriteLine("1. Add Employee \n2. Delete Employee \n3. Update Employee");
                            char EmpOption = Convert.ToChar(Console.ReadLine());
                            switch (EmpOption)
                            {
                                case '1':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Employee_DAL.AddEmployee();
                                    break;
                                case '2':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Employee_DAL.DeleteEmployee();
                                    break;
                                case '3':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Employee_DAL.UpdateEmployee();
                                    break;
                            }
                            Console.WriteLine("Continue editing Employee Details (y/n)?");
                            selected = Convert.ToChar(Console.ReadLine());
                        } while (selected == 'y' || ans == 'Y');
                        break;
                    case '2':
                         selected = 'y';
                        do
                        {
                            Console.WriteLine("Choose the option from the menu:");
                            Console.WriteLine("1. Add new Project \n2. Delete existing project \n3. Edit project details");
                            char EmpOption = Convert.ToChar(Console.ReadLine());
                            switch (EmpOption)
                            {
                                case '1':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Operations_DAL.AddProject();
                                    break;
                                case '2':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Operations_DAL.DeleteProject();
                                    break;
                                case '3':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Operations_DAL.EditProjectDetails();
                                    break;
                            }
                            Console.WriteLine("Continue editing Project Details (y/n)?");
                            selected = Convert.ToChar(Console.ReadLine());
                        } while (selected == 'y' || ans == 'Y');
                        break;

                    case '3':
                        AttendanceManagementSystem.DataAccessLayer.Admin_Employee_Project_Assign_Dal.AssignProject();                       
                        break;

                    case '4':
                        //code to display pending leave request table   
                        try
                        {
                            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HC3KF0;Initial Catalog=AttendanceAndLeaveManagementSystem;Integrated Security=True;"))
                            {
                                SqlCommand cmd = new SqlCommand("Select * from LeaveRequest where ReqStatus= 'Pending'", con);
                                con.Open();
                                SqlDataReader dr = cmd.ExecuteReader();
                                if (dr.HasRows)
                                {
                                    while (dr.Read())
                                    {
                                        Console.WriteLine("EmpId:{0} EmpName:{1} ReqStartDate:{2} ReqEndDate:{3} ReqStatus:{4}", dr["EmpId"], dr["EmpName"], dr["ReqStartDate"], dr["ReqEndDate"], dr["ReqStatus"]);
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case '5':
                        selected = 'y';
                        do
                        {
                            Console.WriteLine("Choose the option from the menu:");
                            Console.WriteLine("1. View attendance by date \n2. View attendance by week \n3. View attendance by month");
                            char EmpOption = Convert.ToChar(Console.ReadLine());
                            switch (EmpOption)
                            {
                                case '1':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Attendance_DAL.ViewAttendanceByDate();
                                    break;
                                case '2':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Attendance_DAL.ViewMonthlyAttendance();
                                    break;
                                case '3':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Attendance_DAL.ViewMonthlyAttendance();
                                    break;
                            }
                            Console.WriteLine("Continue editing Attendance Details (y/n)?");
                            selected = Convert.ToChar(Console.ReadLine());
                        } while (selected == 'y' || ans == 'Y');
                        break;


                }
                Console.WriteLine("Continue with Admin Menu (y/n)?");
                ans = Convert.ToChar(Console.ReadLine());
            }
            while (ans == 'y' || ans == 'Y');
           

        }
    }
}
