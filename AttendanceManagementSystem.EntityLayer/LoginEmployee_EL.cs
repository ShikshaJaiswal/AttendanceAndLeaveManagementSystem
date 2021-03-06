using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class LoginEmployee_EL
    {
        private int empId;
        private string username;
        private string pass;
        
        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
