using System;


namespace AttendanceManagementSystem.Exceptions
{
   
    public class AdminOrEmployeeException : Exception
    {
        public AdminOrEmployeeException()
        {
        }

        public AdminOrEmployeeException(string message) : base(message)
        {
            
        }

               
    }
}
