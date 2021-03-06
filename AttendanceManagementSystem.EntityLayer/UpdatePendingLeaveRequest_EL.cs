using System;
using System.Collections.Generic;
using System.Text;

namespace AttendanceManagementSystem.EntityLayer
{
    public class UpdatePendingLeaveRequest_EL
    {
        private int empId;
        private string reqStatus;

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string ReqStatus
        {
            get { return reqStatus; }
            set { reqStatus = value; }
        }
    }
}
