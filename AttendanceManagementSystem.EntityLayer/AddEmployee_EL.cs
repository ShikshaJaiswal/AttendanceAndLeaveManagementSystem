using System;

namespace AttendanceManagementSystem.EntityLayer
{
    public class AddEmployee_EL
    {
        private string empId;
        private string mgrId;
        private string empDesignation;
        private string empName;
        private DateTime empDOB;
        private string empAddress;
        private string projectId;
            
        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public string EmpDesignation
        {
            get { return empDesignation; }
            set { empDesignation = value; }
        }
        public string MgrId
        {
            get { return mgrId; }
            set { mgrId = value; }
        }
        public string ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }

        public DateTime EpmDOB
        {
            get { return empDOB; }
            set {empDOB = value; }
        }
        public string EmpAddress
        {
            get { return empAddress; }
            set { empAddress = value; }
        }
        
        
    }
}
