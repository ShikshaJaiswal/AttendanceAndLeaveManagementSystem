using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class UpdateEmployee_EL
    {
        private int empId;
        private int mgrId;
        private string empDesignation;
        private string empName;
        private DateTime empDOB;
        private string empAddress;
        private int projectId;

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string EmpDesignation
        {
            get { return empDesignation; }
            set { empDesignation = value; }
        }
        public int MgrId
        {
            get { return mgrId; }
            set { mgrId = value; }
        }
        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public DateTime EmpDOB
        {
            get { return empDOB; }
            set { empDOB = value; }
        }
        public string EmpAddress
        {
            get { return empAddress; }
            set { empAddress = value; }
        }
    }
}
