<<<<<<< HEAD
use AttendanceAndLeaveManagementSystem

create table ManagerDetails(
MgrId varchar(10) primary key,
MgrName varchar(30) not null,
MgrDesignation varchar(30),
MgrDOB datetime not null,
MgrAddress varchar(100) not null,
PId1 varchar(10) foreign key references ProjectDetails(ProjectId),
PId2 varchar(10) foreign key references ProjectDetails(ProjectId)
)



insert into ManagerDetails values('CAPMGR101', 'Uma Shankar Rawat', 'Python Team-Manager', '1991-03-13', 'Colony1, Delhi','PR101','PR102')
insert into ManagerDetails values('CAPMGR102', 'Sandeep Joshi', 'Web Development Team-Manager', '1992-05-15', 'Colony2, Hyderabad','PR103','PR104')
insert into ManagerDetails values('CAPMGR103', 'Saket Acharya', '.NET Team-Manager', '1994-09-23', 'Colony3, Pune','PR105','PR106')
insert into ManagerDetails values('CAPMGR104', 'Bali Devi', 'Data Engineer Team-Manager', '1995-02-26', 'Colony4, Bangalore','PR107','PR108')
insert into ManagerDetails values('CAPMGR105', 'Prashant Manuja', 'Operations Team-Manager', '1992-01-19', 'Colony5, Jaipur','PR109','PR110')


select * from ManagerDetails




create table EmployeeDetails(
EmpId varchar(10) primary key,
EmpName varchar(30) not null,
EmpDesignation varchar(20),
EmpDOB datetime not null,
EmpAddress varchar(100) not null,
MgrId varchar(10) foreign key references ManagerDetails(MgrId),
ProjectId varchar(10) foreign key references ProjectDetails(ProjectId)
)



insert into EmployeeDetails values('CAPG1001', 'Abhishek Bhushan', 'Python Programmer', '1997-02-11', 'Lane1, Kanpur','CAPMGR101','PR101')
insert into EmployeeDetails values('CAPG1002', 'Harshit Joshi', 'Python Programmer', '1998-07-17', 'Lane2, Hyderabad','CAPMGR101','PR101')
insert into EmployeeDetails values('CAPG1003', 'Akash Singh', 'Python Programmer', '1997-09-11', 'Lane3, Bangalore','CAPMGR101','PR102')
insert into EmployeeDetails values('CAPG1004', 'Sparsh Kotriwal', 'Python Programmer', '1995-03-23', 'Lane4, Pune','CAPMGR101','PR102')

insert into EmployeeDetails values('CAPG1005', 'Tanya Shukla', 'Web Developer', '1998-08-17', 'Lane5, Mysore','CAPMGR102','PR103')
insert into EmployeeDetails values('CAPG1006', 'Megha Kayal', 'Web Developer', '1999-07-15', 'Lane6, Lucknow','CAPMGR102','PR103')
insert into EmployeeDetails values('CAPG1007', 'Mrityunjai Katiyar', 'Web Developer', '1998-03-19', 'Lane7, Delhi','CAPMGR102','PR104')
insert into EmployeeDetails values('CAPG1008', 'Yash Tibrewala', 'Web Developer', '1999-09-24', 'Lane8, Gurgaon','CAPMGR102','PR104')

insert into EmployeeDetails values('CAPG1009', 'Harshita Gupta', '.NET Developer', '1997-03-10', 'Lane9, Faizabad','CAPMGR103','PR105')
insert into EmployeeDetails values('CAPG1010', 'Gauri Bindal','.NET Developer', '1999-09-12', 'Lane10, Allahabad','CAPMGR103','PR105')
insert into EmployeeDetails values('CAPG1011', 'Neha Rai', '.NET Developer', '1996-08-13', 'Lane11, Faridabad','CAPMGR103','PR106')
insert into EmployeeDetails values('CAPG1012', 'Tarushi Sharma', '.NET Developer','1999-07-04', 'Lane12, Chandigarh','CAPMGR103','PR106')

insert into EmployeeDetails values('CAPG1013', 'Twinkle Monga', 'Data Engineer', '1995-03-19', 'Lane13, Jaipur','CAPMGR104','PR107')
insert into EmployeeDetails values('CAPG1014', 'Vasundhara Chandel','Data Engineer', '1997-03-13', 'Lane14, Agra','CAPMGR104','PR107')
insert into EmployeeDetails values('CAPG1015', 'Sandeep Chaurasia', 'Data Engineer', '1999-03-16', 'Lane15, Chennai','CAPMGR104','PR108')
insert into EmployeeDetails values('CAPG1016', 'Vinod Kumar', 'Data Engineer', '1997-04-07', 'Lane16, Scunderabad','CAPMGR104','PR108')

insert into EmployeeDetails values('CAPG1017', 'Radhika Sharma', 'Operations', '1996-02-11', 'Lane17, Ranchi','CAPMGR105','PR109')
insert into EmployeeDetails values('CAPG1018', 'Pranay Garg', 'Operations', '1995-03-13', 'Lane18, Patna','CAPMGR105','PR109')
insert into EmployeeDetails values('CAPG1019', 'Akshat Saxena', 'Operations','1997-08-11', 'Lane19, Bhubhneshwar','CAPMGR105','PR110')
insert into EmployeeDetails values('CAPG1020', 'Karan Bhatia', 'Operations', '1993-07-12', 'Lane20, Mumbai','CAPMGR105','PR110')

select * from EmployeeDetails
=======
use AttendanceAndLeaveMgmt;

create table ManagerDetails(
MgrId varchar(10) primary key,
MgrName varchar(30) not null,
MgrDesignation varchar(30),
MgrDOB datetime not null,
MgrAddress varchar(100) not null,
PId1 varchar(10) foreign key references ProjectDetails(ProjectId),
PId2 varchar(10) foreign key references ProjectDetails(ProjectId)
)



insert into ManagerDetails values('CAPMGR101', 'Uma Shankar Rawat', 'Python Team-Manager', '1991-03-13', 'Colony1, Delhi','PR101','PR102')
insert into ManagerDetails values('CAPMGR102', 'Sandeep Joshi', 'Web Development Team-Manager', '1992-05-15', 'Colony2, Hyderabad','PR103','PR104')
insert into ManagerDetails values('CAPMGR103', 'Saket Acharya', '.NET Team-Manager', '1994-09-23', 'Colony3, Pune','PR105','PR106')
insert into ManagerDetails values('CAPMGR104', 'Bali Devi', 'Data Engineer Team-Manager', '1995-02-26', 'Colony4, Bangalore','PR107','PR108')
insert into ManagerDetails values('CAPMGR105', 'Prashant Manuja', 'Operations Team-Manager', '1992-01-19', 'Colony5, Jaipur','PR109','PR110')


select * from ManagerDetails




create table EmployeeDetails(
EmpId varchar(10) primary key,
EmpName varchar(30) not null,
EmpDesignation varchar(20),
EmpDOB datetime not null,
EmpAddress varchar(100) not null,
MgrId varchar(10) foreign key references ManagerDetails(MgrId),
ProjectId varchar(10) foreign key references ProjectDetails(ProjectId)
)



insert into EmployeeDetails values('CAPG1001', 'Abhishek Bhushan', 'Python Programmer', '1997-02-11', 'Lane1, Kanpur','CAPMGR101','PR101')
insert into EmployeeDetails values('CAPG1002', 'Harshit Joshi', 'Python Programmer', '1998-07-17', 'Lane2, Hyderabad','CAPMGR101','PR101')
insert into EmployeeDetails values('CAPG1003', 'Akash Singh', 'Python Programmer', '1997-09-11', 'Lane3, Bangalore','CAPMGR101','PR102')
insert into EmployeeDetails values('CAPG1004', 'Sparsh Kotriwal', 'Python Programmer', '1995-03-23', 'Lane4, Pune','CAPMGR101','PR102')

insert into EmployeeDetails values('CAPG1005', 'Tanya Shukla', 'Web Developer', '1998-08-17', 'Lane5, Mysore','CAPMGR102','PR103')
insert into EmployeeDetails values('CAPG1006', 'Megha Kayal', 'Web Developer', '1999-07-15', 'Lane6, Lucknow','CAPMGR102','PR103')
insert into EmployeeDetails values('CAPG1007', 'Mrityunjai Katiyar', 'Web Developer', '1998-03-19', 'Lane7, Delhi','CAPMGR102','PR104')
insert into EmployeeDetails values('CAPG1008', 'Yash Tibrewala', 'Web Developer', '1999-09-24', 'Lane8, Gurgaon','CAPMGR102','PR104')

insert into EmployeeDetails values('CAPG1009', 'Harshita Gupta', '.NET Developer', '1997-03-10', 'Lane9, Faizabad','CAPMGR103','PR105')
insert into EmployeeDetails values('CAPG1010', 'Gauri Bindal','.NET Developer', '1999-09-12', 'Lane10, Allahabad','CAPMGR103','PR105')
insert into EmployeeDetails values('CAPG1011', 'Neha Rai', '.NET Developer', '1996-08-13', 'Lane11, Faridabad','CAPMGR103','PR106')
insert into EmployeeDetails values('CAPG1012', 'Tarushi Sharma', '.NET Developer','1999-07-04', 'Lane12, Chandigarh','CAPMGR103','PR106')

insert into EmployeeDetails values('CAPG1013', 'Twinkle Monga', 'Data Engineer', '1995-03-19', 'Lane13, Jaipur','CAPMGR104','PR107')
insert into EmployeeDetails values('CAPG1014', 'Vasundhara Chandel','Data Engineer', '1997-03-13', 'Lane14, Agra','CAPMGR104','PR107')
insert into EmployeeDetails values('CAPG1015', 'Sandeep Chaurasia', 'Data Engineer', '1999-03-16', 'Lane15, Chennai','CAPMGR104','PR108')
insert into EmployeeDetails values('CAPG1016', 'Vinod Kumar', 'Data Engineer', '1997-04-07', 'Lane16, Scunderabad','CAPMGR104','PR108')

insert into EmployeeDetails values('CAPG1017', 'Radhika Sharma', 'Operations', '1996-02-11', 'Lane17, Ranchi','CAPMGR105','PR109')
insert into EmployeeDetails values('CAPG1018', 'Pranay Garg', 'Operations', '1995-03-13', 'Lane18, Patna','CAPMGR105','PR109')
insert into EmployeeDetails values('CAPG1019', 'Akshat Saxena', 'Operations','1997-08-11', 'Lane19, Bhubhneshwar','CAPMGR105','PR110')
insert into EmployeeDetails values('CAPG1020', 'Karan Bhatia', 'Operations', '1993-07-12', 'Lane20, Mumbai','CAPMGR105','PR110')

select * from EmployeeDetails
>>>>>>> fd732a686007df5f96dacab25c627df0b6bc5ba2
