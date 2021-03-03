using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class LoginEmployee_EL
    {
        private string username;
        private string pass;
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
