using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class AssignLoginToNewEmp_EL
    {
        private string userName;
        private string pass;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
    }
}
