using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class AddLeaveRequest_EL
    {
        private int empId;
        private DateTime reqStartDate;
        private DateTime reqEndDate;


        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }

        public DateTime ReqStartDate
        {
            get { return reqStartDate; }
            set { reqStartDate = value; }
        }
        public DateTime ReqEndDate
        {
            get { return reqEndDate; }
            set { reqEndDate = value; }
        }
    }
}
