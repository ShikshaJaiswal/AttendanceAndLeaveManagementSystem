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
            Console.WriteLine(" Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            /*
            if (AttendanceManagementSystem.BusinessLayer.AMSValidation.ValidateUserIdAndPasswordAdmin())
            {*/
                AttendanceManagementSystem.PresentationLayer.AdminMenu.DisplayMenu();
            

            
            
        }

        public static void EmployeeLogin()
        {
            // write code to enable employee login and validate in business layer
            Console.WriteLine(" Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            /*
            if (AttendanceManagementSystem.BusinessLayer.AMSValidation.ValidateUserIdAndPasswordEmp())
            {*/
                AttendanceManagementSystem.PresentationLayer.EmployeeMenu.DisplayMenu();
            
        }
    }
}
