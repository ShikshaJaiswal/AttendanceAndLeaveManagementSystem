using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class ViewAttendanceByDate_EL
    {
        private DateTime attendanceDate;

        public DateTime AttendanceDate
        {
            get { return attendanceDate; }
            set { attendanceDate = value; }
        }
    }
}
