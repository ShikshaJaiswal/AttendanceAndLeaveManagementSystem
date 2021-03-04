using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class AssignProject_EL
    {
        private string empId;
        private string projectId;

        public string EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }
    }
}
