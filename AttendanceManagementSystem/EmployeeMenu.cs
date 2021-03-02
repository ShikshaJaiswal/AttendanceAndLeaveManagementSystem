using System;
using System.Collections.Generic;
using System.Text;
using AttendanceManagementSystem.Exceptions;

namespace AttendanceManagementSystem.PresentationLayer
{
    class EmployeeMenu
    {
        public static void DisplayMenu()
        {
            char ans = 'y';
            do
            {
                Console.WriteLine("Choose the option from the Menu:");
                Console.WriteLine("1. Project Attendance \n2. Leave Requests \n3. View Attendance \n4. Update leave requests");
                char option = Convert.ToChar(Console.ReadLine());


                switch (option)
                {
                    case '1':
                        //Mark the person's attendance for today if he selects 1(Project Attendance)
                        AttendanceManagementSystem.DataAccessLayer.EmployeeAttendanceUpdate_DAL.UpdateAttendaceOfEmployee();                        
                        break;
                    case '2':
                        
                        char selected = 'y';
                        do
                        {
                            Console.WriteLine("Choose the option from the menu:");
                            Console.WriteLine("1. Add Leave Request \n2. Delete Leave request");
                            char EmpOption = Convert.ToChar(Console.ReadLine());
                            switch (EmpOption)
                            {
                                case '1':
                                    AttendanceManagementSystem.DataAccessLayer.EmployeeLeaveRequestUpdate_DAL.AddLeaveRequest();
                                    break;
                                case '2':
                                    AttendanceManagementSystem.DataAccessLayer.EmployeeLeaveRequestUpdate_DAL.DeleteLeaveRequest();
                                    break;
                            }
                            Console.WriteLine("Continue editing Leave Requests (y/n)?");
                            selected = Convert.ToChar(Console.ReadLine());
                        } while (selected == 'y' || ans == 'Y');
                        break;

                    case '3':
                        // code to catch exception since user isn't admin
                        try
                        {
                            throw new AdminOrEmployeeException("Only Managers have the permission to view this!");
                        }
                        catch (AdminOrEmployeeException aoee)
                        {
                           
                            Console.WriteLine(aoee.Message);
                        }                       
                        break;

                    case '4':
                        // code to catch exception since user isn't admin
                        try
                        {
                            throw new AdminOrEmployeeException("Only Managers have the permission to view this!");
                        }
                        catch (AdminOrEmployeeException aoee)
                        {
                            
                            Console.WriteLine(aoee.Message);
                        }
                        break;

                }
                Console.WriteLine("Continue with Employee Menu (y/n)?");
                ans = Convert.ToChar(Console.ReadLine());
            }
            while (ans == 'y' || ans == 'Y');

        }
    
}
}
