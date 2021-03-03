using System;
using System.Collections.Generic;
using System.Text;
using AttendanceManagementSystem.DataAccessLayer;
using AttendanceManagementSystem.Exceptions;



namespace AttendanceManagementSystem.PresentationLayer
{
    public class Login
    {
        public static AttendanceManagementSystem.EntityLayer.LoginEmployee_EL  EmpLoginInput()
        {
            AttendanceManagementSystem.EntityLayer.LoginEmployee_EL eli = new EntityLayer.LoginEmployee_EL();
            Console.WriteLine("Enter Username:");
            eli.UserName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            eli.Pass= Console.ReadLine();
            return eli;
        }
        
        public static void AdminLogin()
        {
            // write code to enable admin login and validate in business layer
            Console.WriteLine(" Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            try
            {
                if (Login_DAL.LoginDetailsAdmin(username, password))
                {
                    Console.WriteLine("Admin Login Successful!");
                    AttendanceManagementSystem.PresentationLayer.AdminMenu.DisplayMenu();
                }
                else
                {
                    throw (new LoginException("Invalid Username or Password!"));
                }
            }
            catch (LoginException le)
            {

                Console.WriteLine(le.Message);
               
            }

        }

        public static void EmployeeLogin()
        {
            // write code to enable employee login and validate in business layer
            Console.WriteLine(" Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            try
            {
                if (Login_DAL.LoginDetailsEmp(username, password))
                {
                    Console.WriteLine("Employee Login Successful!");
                    AttendanceManagementSystem.PresentationLayer.EmployeeMenu.DisplayMenu();
                }
                else
                {
                    throw (new LoginException("Invalid Username or Password!"));
                }
            }
            catch (LoginException le)
            {

                Console.WriteLine(le.Message);

            }
        }
    }
}