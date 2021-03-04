using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using AttendanceManagementSystem.EntityLayer;



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
                                                                         
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Employee_DAL.AddEmployee(AddEmployeeInput());
                                    break;
                                case '2':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Employee_DAL.DeleteEmployee(DelEmployeeInput());
                                    break;
                                case '3':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Employee_DAL.UpdateEmployee(UpdateEmployeeInput());
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
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Operations_DAL.AddProject(AddProjecInput());
                                    break;
                                case '2':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Operations_DAL.DeleteProject(DelProjectInput());
                                    break;
                                case '3':
                                    AttendanceManagementSystem.DataAccessLayer.Admin_Project_Operations_DAL.UpdateProject(UpdateProjectInput());
                                    break;
                            }
                            Console.WriteLine("Continue editing Project Details (y/n)?");
                            selected = Convert.ToChar(Console.ReadLine());
                        } while (selected == 'y' || ans == 'Y');
                        break;

                    

                    case '3':
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
                    case '4':
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
        public static AddEmployee_EL AddEmployeeInput()
        {
            Console.WriteLine("Enter: EmpName, EmpDesignation, EmpDOB, EmpAddress, MgrId, ProjectId to add record:");
            AddEmployee_EL ae = new AddEmployee_EL();

            ae.EmpName = Console.ReadLine();
            ae.EmpDesignation = Console.ReadLine();
            ae.EpmDOB = DateTime.Parse(Console.ReadLine());
            ae.EmpAddress = Console.ReadLine();
            ae.MgrId = Convert.ToInt32( Console.ReadLine());
            ae.ProjectId = Convert.ToInt32(Console.ReadLine());

            return ae;

        }
        public static DelEmployee_EL DelEmployeeInput()
        {
            Console.WriteLine("Enter EmpId to delete record:");
            DelEmployee_EL de = new DelEmployee_EL();
            de.EmpId = Convert.ToInt32(Console.ReadLine());
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
            DelProject_EL dpe = new DelProject_EL();
            dpe.ProjectId = Console.ReadLine();
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


    }
}
