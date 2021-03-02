using System;
using System.Collections.Generic;
using System.Text;



namespace AttendanceManagementSystem.PresentationLayer
{
    class Login
    {
        public static void AdminLogin()
        {
            // write code to enable admin login and validate in business layer
            Console.WriteLine("Enter Username:");
            string Username = Console.ReadLine();
            AttendanceManagementSystem.BusinessLayer.AMSValidation.ValidateUserIdAndPassword();

            AttendanceManagementSystem.PresentationLayer.AdminMenu.DisplayMenu();
            
        }

        public static void EmployeeLogin()
        {
            // write code to enable employee login and validate in business layer
            Console.WriteLine("Enter Username:");
            string Username = Console.ReadLine();
            AttendanceManagementSystem.BusinessLayer.AMSValidation.ValidateUserIdAndPassword();
            AttendanceManagementSystem.PresentationLayer.EmployeeMenu.DisplayMenu();
        }
    }
}
