<<<<<<< HEAD
use AttendanceAndLeaveManagementSystem

create table LeaveRequest(
EmpId varchar(10) foreign key references EmployeeDetails(EmpId),
EmpName varchar(30) NOT NULL,
ReqStartDate datetime NOT NULL,
ReqEndDate datetime NOT NULL,
ReqStatus varchar(10) NOT NULL default 'Pending'
)

insert into LeaveRequest values('CAPG1001', 'Abhishek Bhushan','02/02/21','02/05/21',default)
insert into LeaveRequest values('CAPG1005', 'Tanya Shukla','02/09/21','02/12/21','Rejected')
insert into LeaveRequest values('CAPG1009', 'Harshita Gupta','02/11/21','02/14/21',default)
insert into LeaveRequest values('CAPG1013', 'Twinkle Monga','02/18/21','02/21/21','Acceped')
insert into LeaveRequest values('CAPG1017', 'Radhika Sharma','02/24/21','02/27/21',default)

=======
use AttendanceAndLeaveMgmt;

create table LeaveRequest(
EmpId varchar(10) foreign key references EmployeeDetails(EmpId),
EmpName varchar(30) NOT NULL,
ReqStartDate datetime NOT NULL,
ReqEndDate datetime NOT NULL,
ReqStatus varchar(10) NOT NULL default 'Pending'
)

insert into LeaveRequest values('CAPG1001', 'Abhishek Bhushan','02/02/21','02/05/21',default)
insert into LeaveRequest values('CAPG1005', 'Tanya Shukla','02/09/21','02/12/21','Rejected')
insert into LeaveRequest values('CAPG1009', 'Harshita Gupta','02/11/21','02/14/21',default)
insert into LeaveRequest values('CAPG1013', 'Twinkle Monga','02/18/21','02/21/21','Acceped')
insert into LeaveRequest values('CAPG1017', 'Radhika Sharma','02/24/21','02/27/21',default)

>>>>>>> fd732a686007df5f96dacab25c627df0b6bc5ba2
select * from LeaveRequest