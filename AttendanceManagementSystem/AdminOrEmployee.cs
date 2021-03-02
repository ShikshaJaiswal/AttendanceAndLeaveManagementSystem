using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using AttendanceManagementSystem.Exceptions;

namespace AttendanceManagementSystem.PresentationLayer
{
    class AdminOrEmployee
    {
        public static void AskAdminOrEmployee()
        {
            try
            {
                Console.WriteLine("Want to enter as Admin or Employee?");
                string ans = Console.ReadLine();

                if (ans == "Admin" || ans == "admin")
                {
                    AttendanceManagementSystem.PresentationLayer.Login.AdminLogin();
                }
                else if (ans == "Employee" || ans== "employee")
                {
                    AttendanceManagementSystem.PresentationLayer.Login.EmployeeLogin();
                }
                else
                {
                    throw (new AdminOrEmployeeException("Invalid User!"));
                }
                
            }
            catch(AdminOrEmployeeException aoee)
            {
                // code to catch exception if user is neither admin nor employee
                Console.WriteLine(aoee.Message);
            }

            }
        }

    
}

