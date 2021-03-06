using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using AttendanceManagementSystem.EntityLayer;
using AttendanceManagementSystem.DataAccessLayer;



namespace AttendanceManagementSystem.PresentationLayer
{

    public class AdminMenu
    {
        public static void DisplayMenu()
        {
            char ans = 'y';
            do
            {
                Console.WriteLine("Choose the option from the Menu:");
                Console.WriteLine("1. Employee Information \n2. Project Information \n3. View Pending leave requests \n4. View Project attendance");
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
                                                                         
                                    Admin_Employee_DAL.AddEmployee(AddEmployeeInput());
                                    AssignLoginToNewEmp_DAL.AssignLoginToNewEmp(AssignLoginToNewEmpInput());

                                    break;
                                case '2':
                                    Admin_Employee_DAL.DeleteEmployee(DelEmployeeInput());
                                    break;
                                case '3':
                                    Admin_Employee_DAL.UpdateEmployee(UpdateEmployeeInput());
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
                                    Admin_Project_Operations_DAL.AddProject(AddProjecInput());
                                    break;
                                case '2':
                                   Admin_Project_Operations_DAL.DeleteProject(DelProjectInput());
                                    break;
                                case '3':
                                   Admin_Project_Operations_DAL.UpdateProject(UpdateProjectInput());
                                    break;
                            }
                            Console.WriteLine("Continue editing Project Details (y/n)?");
                            selected = Convert.ToChar(Console.ReadLine());
                        } while (selected == 'y' || ans == 'Y');
                        break;

                    

                    case '3':
                        //code to display leave request table  
                        Console.WriteLine("Following are the pending leave requests:");
                        AdminViewLeaveRequest_DAL.AdminViewLeaveRequest();
                        UpdatePendingLeaveRequest_DAL.UpdatePendingLeaveRequest(UpdatePendingLeaveRequestInput());

                        break;
                    case '4':
                        selected = 'y';
                        do
                        {
                            Console.WriteLine("Choose the option from the menu:");
                            Console.WriteLine("1. View attendance by date \n2. View attendance of last week \n3. View attendance of last month");
                            char EmpOption = Convert.ToChar(Console.ReadLine());                            
                            switch (EmpOption)
                            {
                                case '1':

                                   Admin_Project_Attendance_DAL.ViewAttendanceByDate(ViewAttendanceByDateInput());
                                    break;
                                case '2':
                                  Admin_Project_Attendance_DAL.ViewWeeklyAttendance();
                                    break;
                                case '3':
                                    Admin_Project_Attendance_DAL.ViewMonthlyAttendance();
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
        public static AddEmployee_EL AddEmployeeInput()
        {
            Console.WriteLine("Enter: EmpName, EmpDesignation, EmpDOB, EmpAddress, MgrId, ProjectId to add record:");
            AddEmployee_EL ae = new AddEmployee_EL
            {
                EmpName = Console.ReadLine(),
                EmpDesignation = Console.ReadLine(),
                EpmDOB = DateTime.Parse(Console.ReadLine()),
                EmpAddress = Console.ReadLine(),
                MgrId = Convert.ToInt32(Console.ReadLine()),
                ProjectId = Convert.ToInt32(Console.ReadLine())
            };

            return ae;

        }

        public static AssignLoginToNewEmp_EL AssignLoginToNewEmpInput()
        {
            

            Console.WriteLine("Enter UserName and Password for this Employee");
            AssignLoginToNewEmp_EL altne = new AssignLoginToNewEmp_EL
            {
                UserName = Console.ReadLine(),
                Pass = Console.ReadLine()
            };
            return altne;
        }

        public static DelEmployee_EL DelEmployeeInput()
        {
            Console.WriteLine("Enter EmpId to delete record:");
            DelEmployee_EL de = new DelEmployee_EL
            {
                EmpId = Convert.ToInt32(Console.ReadLine())
            };
            return de;
        }

        public static UpdateEmployee_EL UpdateEmployeeInput()
        {
            UpdateEmployee_EL ue = new UpdateEmployee_EL();
            Console.WriteLine("Enter EmpId to update record:");            
            ue.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter EmpName, EmpDesignation, EmpDOB, EmpAddress, MgrId, ProjectId to add record:");
            ue.EmpName = Console.ReadLine();
            ue.EmpDesignation = Console.ReadLine();
            ue.EmpDOB = DateTime.Parse(Console.ReadLine());
            ue.EmpAddress = Console.ReadLine();
            ue.MgrId = Convert.ToInt32(Console.ReadLine());
            ue.ProjectId = Convert.ToInt32(Console.ReadLine());
            return ue;

        }

     

        public static AddProject_EL AddProjecInput()
        {
            AddProject_EL ape = new AddProject_EL();
            
            Console.WriteLine("Project Name");
            ape.ProjName = Console.ReadLine();
            Console.WriteLine("Enter Technology");
            ape.ProjectTechnology = Console.ReadLine();
            Console.WriteLine("Enter StartDate");
            ape.Startdate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter EndDate");
            ape.Enddate = DateTime.Parse(Console.ReadLine());
            return ape;
        }
        public static DelProject_EL DelProjectInput()
        {
            Console.WriteLine("Enter ProjectId to delete record:");
            DelProject_EL dpe = new DelProject_EL
            {
                ProjectId = Console.ReadLine()
            };
            return dpe;
        }

        public static UpdateProject_EL UpdateProjectInput()
        {
            Console.WriteLine("Enter ProjectId to update record:");
            UpdateProject_EL upe = new UpdateProject_EL();
            upe.ProjectId = Console.ReadLine();
            Console.WriteLine("Enter ProjName, ProjectTechnology, Startdate, Enddate to add record:");
            upe.ProjName = Console.ReadLine();
            upe.ProjectTechnology = Console.ReadLine();
            upe.Startdate = DateTime.Parse(Console.ReadLine());
            upe.Enddate = DateTime.Parse(Console.ReadLine());
            return upe;

        }
        public static ViewAttendanceByDate_EL ViewAttendanceByDateInput()
        {
            Console.WriteLine("Enter the date (mm/dd/yy) to view attedance:");
            ViewAttendanceByDate_EL vtbd = new ViewAttendanceByDate_EL();
            vtbd.AttendanceDate = DateTime.Parse(Console.ReadLine());
            return vtbd;
        }

        public static UpdatePendingLeaveRequest_EL UpdatePendingLeaveRequestInput()
        {
            Console.WriteLine("Update the pending request?");
            UpdatePendingLeaveRequest_EL uplr = new UpdatePendingLeaveRequest_EL();
            Console.WriteLine("Enter Id:");
            uplr.EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Updated Status: Accepted/Rejected");
            uplr.ReqStatus = Console.ReadLine();

            return uplr;
        }
    }
}
