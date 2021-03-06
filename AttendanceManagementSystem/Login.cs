﻿using System;
using System.Collections.Generic;
using System.Text;
using AttendanceManagementSystem.DataAccessLayer;
using AttendanceManagementSystem.Exceptions;
using AttendanceManagementSystem.EntityLayer;



namespace AttendanceManagementSystem.PresentationLayer
{
    public class Login
    {        
        
        public static void AdminLogin()
        {
            // write code to enable admin login and validate in business layer
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            try
            {
                if (Login_DAL.LoginDetailsAdmin(username, password))
                {
                    Console.WriteLine("Admin Login Successful!");
                    AdminMenu.DisplayMenu();
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
            Console.WriteLine("Enter Employee Id");
            int EmpId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            try
            {
                if (Login_DAL.LoginDetailsEmp(EmpId, username, password))
                {
                    Console.WriteLine("Employee Login Successful!");

                   
                    EmployeeMenu.DisplayMenu();
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