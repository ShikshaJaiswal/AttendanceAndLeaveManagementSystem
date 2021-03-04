using System;

namespace AttendanceManagementSystem.EntityLayer
{
    public class AddEmployee_EL
    {
        
        private int mgrId;
        private string empDesignation;
        private string empName;
        private DateTime empDOB;
        private string empAddress;

        
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
        public int ProjectId { get; set; }
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
