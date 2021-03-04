using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
   public class UpdateProject_EL
    {
        private string projectId;
        private string projName;
        private string projectTechnology;
        private DateTime startdate;
        private DateTime enddate;

        public string ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

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
