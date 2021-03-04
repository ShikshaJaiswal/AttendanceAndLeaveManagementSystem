using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class AddProject_EL
    {
       
        private string projName;
        private string projectTechnology;
        private DateTime startdate;
        private DateTime enddate;

       

        public string ProjName
        {
            get { return projName; }
            set { projName = value; }
        }

        public string ProjectTechnology
        {
            get { return projectTechnology; }
            set { projectTechnology = value; }
        }
        public DateTime Startdate
        {
            get { return startdate; }
            set { startdate = value; }
        }
        public DateTime Enddate
        {
            get { return enddate; }
            set { enddate = value; }
        }

    }
}
