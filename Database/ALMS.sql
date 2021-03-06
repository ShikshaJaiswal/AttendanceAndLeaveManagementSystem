create ALMS
USE ALMS


--PROJECT DETAILS TABLE
create table ProjectDetails(
ProjectId int IDENTITY(1,1) PRIMARY KEY,
ProjName varchar(30) not null,
ProjectTechnology varchar(30),
SDate datetime not null,
EDate datetime not null
)


insert into ProjectDetails values('ExpenseTracker', 'Python','2021-02-01','2021-02-21')
insert into ProjectDetails values('PropertyManagementSystem', 'JAVA', '2021-02-01','2021-02-21')
insert into ProjectDetails values('EcommerceWebsite', 'ReactJs','2021-02-01','2021-02-21')
insert into ProjectDetails values( 'BankingSystem', 'AngularJs','2021-02-01','2021-02-21')
insert into ProjectDetails values('AI Desktop Partner', '.net', '2021-02-01','2021-02-21')
insert into ProjectDetails values('Smart Cab System', 'Go','2021-02-01','2021-02-21')
insert into ProjectDetails values('Data Modeling', ' PostgreSQL','2021-02-01','2021-02-21')
insert into ProjectDetails values( 'Data Lake', 'MongoDB', '2021-02-01','2021-02-21')
insert into ProjectDetails values('Evaluation of Quotations', 'Big Data','2021-02-01','2021-02-21')
insert into ProjectDetails values('Review of Technical Design', 'Deep Learning','2021-02-01','2021-02-21')

select * from ProjectDetails


-- MANAGER DETAILS TABLE
create table ManagerDetails(
MgrId int IDENTITY(5001,1) PRIMARY KEY,
MgrName varchar(30) not null,
MgrDesignation varchar(30),
MgrDOB datetime not null,
MgrAddress varchar(100) not null,
ProjectId int foreign key references ProjectDetails(ProjectId)
)

insert into ManagerDetails values('Uma Shankar Rawat', 'Python Manager', '1991-03-13', 'Colony1, Delhi',1 )
insert into ManagerDetails values('Sandeep Joshi', 'Java Manager', '1992-05-15', 'Colony2, Hyderabad',2)
insert into ManagerDetails values('Saket Acharya', 'ReactJs Manager', '1994-09-23', 'Colony3, Pune',3)
insert into ManagerDetails values('Bali Devi', 'AngularJs Manager', '1995-02-26', 'Colony4, Bangalore',4)
insert into ManagerDetails values('Prashant Manuja', '.Net Manager', '1992-01-19', 'Colony5, Jaipur',5)
insert into ManagerDetails values('Ashok Lodhi', 'GO Manager', '1992-01-19', 'Colony5, Jaipur',6)
insert into ManagerDetails values('Sandeep Tahl', ' PostgreSQL Manager', '1992-01-19', 'Colony5, Jaipur',7)
insert into ManagerDetails values('Abha Mishra', 'MongoDB Manager', '1992-01-19', 'Colony5, Jaipur',8)
insert into ManagerDetails values('Raghu Dev', 'Big Data Manager', '1992-01-19', 'Colony5, Jaipur',9)
insert into ManagerDetails values('Tomar Man', 'Deep Learning Manager', '1992-01-19', 'Colony5, Jaipur',10)

select * from ManagerDetails


--EMPLOYEE DETAILS TABLE
create table EmployeeDetails(
EmpId int IDENTITY(15001,1) PRIMARY KEY,
EmpName varchar(30) not null,
EmpDesignation varchar(20),
EmpDOB datetime not null,
EmpAddress varchar(100) not null,
MgrId int foreign key references ManagerDetails(MgrId),
ProjectId int foreign key references ProjectDetails(ProjectId) 
)
insert into EmployeeDetails values( 'Abhishek Bhushan', 'Python Programmer', '1997-02-11', 'Lane1, Kanpur',5001,1)
insert into EmployeeDetails values('Harshit Joshi', 'Python Programmer', '1998-07-17', 'Lane2, Hyderabad',5001,1)

insert into EmployeeDetails values('Akash Singh', 'Python Programmer', '1997-09-11', 'Lane3, Bangalore',5002,2)
insert into EmployeeDetails values('Sparsh Kotriwal', 'Python Programmer', '1995-03-23', 'Lane4, Pune',5002,2)

insert into EmployeeDetails values('Tanya Shukla', 'Web Developer', '1998-08-17', 'Lane5, Mysore',5003,3)
insert into EmployeeDetails values('Megha Kayal', 'Web Developer', '1999-07-15', 'Lane6, Lucknow',5003,3)

insert into EmployeeDetails values('Mrityunjai Katiyar', 'Web Developer', '1998-03-19', 'Lane7, Delhi',5004,4)
insert into EmployeeDetails values('Yash Tibrewala', 'Web Developer', '1999-09-24', 'Lane8, Gurgaon',5004,4)

insert into EmployeeDetails values('Harshita Gupta', '.NET Developer', '1997-03-10', 'Lane9, Faizabad',5005,5)
insert into EmployeeDetails values('Gauri Bindal','.NET Developer', '1999-09-12', 'Lane10, Allahabad',5005,5)

insert into EmployeeDetails values('Neha Rai', '.NET Developer', '1996-08-13', 'Lane11, Faridabad',5006,6)
insert into EmployeeDetails values('Tarushi Sharma', '.NET Developer','1999-07-04', 'Lane12, Chandigarh',5006,6)

insert into EmployeeDetails values('Twinkle Monga', 'Data Engineer', '1995-03-19', 'Lane13, Jaipur',5007,7)
insert into EmployeeDetails values('Vasundhara Chandel','Data Engineer', '1997-03-13', 'Lane14, Agra',5007,7)

insert into EmployeeDetails values('Sandeep Chaurasia', 'Data Engineer', '1999-03-16', 'Lane15, Chennai',5008,8)
insert into EmployeeDetails values('Vinod Kumar', 'Data Engineer', '1997-04-07', 'Lane16, Scunderabad',5008,8)

insert into EmployeeDetails values('Radhika Sharma', 'Operations', '1996-02-11', 'Lane17, Ranchi',5009,9)
insert into EmployeeDetails values('Pranay Garg', 'Operations', '1995-03-13', 'Lane18, Patna',5009,9)

insert into EmployeeDetails values('Akshat Saxena', 'Operations','1997-08-11', 'Lane19, Bhubhneshwar',5010,10)
insert into EmployeeDetails values('Karan Bhatia', 'Operations', '1993-07-12', 'Lane20, Mumbai',5010,10)

select * from EmployeeDetails



--EMPLOYEE LOGIN DETAILS TABLE
create table EmpLogin(
EmpId int IDENTITY(15001,1) foreign key references EmployeeDetails(EmpId),
UserName varchar(30) not null,
Pass varchar(30) not null
)


select * from EmpLogin

insert into EmpLogin values('CAPG15001','Pass15001')
insert into EmpLogin values('CAPG15002','Pass15002')
insert into EmpLogin values('CAPG15003','Pass15003')
insert into EmpLogin values('CAPG15004','Pass15004')
insert into EmpLogin values('CAPG15005','Pass15005')
insert into EmpLogin values('CAPG15006','Pass15006')
insert into EmpLogin values('CAPG15007','Pass15007')
insert into EmpLogin values('CAPG15008','Pass15008')
insert into EmpLogin values('CAPG15009','Pass15009')
insert into EmpLogin values('CAPG15010','Pass15010')
insert into EmpLogin values('CAPG15011','Pass15011')
insert into EmpLogin values('CAPG15012','Pass15012')
insert into EmpLogin values('CAPG15013','Pass15013')
insert into EmpLogin values('CAPG15014','Pass15014')
insert into EmpLogin values('CAPG15015','Pass15015')
insert into EmpLogin values('CAPG15016','Pass15016')
insert into EmpLogin values('CAPG15017','Pass15017')
insert into EmpLogin values('CAPG15018','Pass15018')
insert into EmpLogin values('CAPG15019','Pass15019')
insert into EmpLogin values('CAPG15020','Pass15020')

select * from EmpLogin




--MANAGER LOGIN DETAILS TABLE
create table MgrLogin(
MgrId int foreign key references ManagerDetails(MgrId),
UserName varchar(30) not null,
Pass varchar(30) not null
)



insert into MgrLogin values(5001, 'CAPMGR5001','Pass5001')
insert into MgrLogin values(5002, 'CAPMGR5002','Pass5002')
insert into MgrLogin values(5003, 'CAPMGR5003','Pass5003')
insert into MgrLogin values(5004, 'CAPMGR5004','Pass5004')
insert into MgrLogin values(5005, 'CAPMGR5005','Pass5005')
insert into MgrLogin values(5006, 'CAPMGR5006','Pass5006')
insert into MgrLogin values(5007, 'CAPMGR5007','Pass5007')
insert into MgrLogin values(5008, 'CAPMGR508','Pass5008')
insert into MgrLogin values(5009, 'CAPMGR5009','Pass5009')
insert into MgrLogin values(5010, 'CAPMGR5010','Pass5010')

select * from MgrLogin



-- LEAVE REQUEST DETAILS TABLE
create table LeaveRequest(
EmpId int foreign key references EmployeeDetails(EmpId),
ReqStartDate date NOT NULL,
ReqEndDate date NOT NULL,
ReqStatus varchar(10) NOT NULL default 'Pending'
)

insert into LeaveRequest values(15001,'02/02/21','02/05/21',default)
insert into LeaveRequest values(15005,'02/09/21','02/12/21','Rejected')
insert into LeaveRequest values(15010,'02/11/21','02/14/21',default)
insert into LeaveRequest values(15015,'02/18/21','02/21/21','Acceped')
insert into LeaveRequest values(15018,'02/24/21','02/27/21',default)

select * from LeaveRequest


--ATTENDANCE DETAILS TABLE

create table Attendance(
EmpId int foreign key references EmployeeDetails(EmpId),
AttendanceDate date not null,
AttendanceStatus varchar(1)  not null
)
select * from Attendance
insert into Attendance values(15001,'2021-02-01','A')
insert into Attendance values(15002,'2021-02-01','A')
insert into Attendance values(15003,'2021-02-01','A')
insert into Attendance values(15004,'2021-02-01','P')
insert into Attendance values(15005,'2021-02-01','P')
insert into Attendance values(15006,'2021-02-01','P')
insert into Attendance values(15007,'2021-02-01','P')
insert into Attendance values(15008,'2021-02-01','P')
insert into Attendance values(15009,'2021-02-01','P')
insert into Attendance values(15010,'2021-02-01','P')
insert into Attendance values(15011,'2021-02-01','P')
insert into Attendance values(15012,'2021-02-01','P')
insert into Attendance values(15013,'2021-02-01','P')
insert into Attendance values(15014,'2021-02-01','P')
insert into Attendance values(15015,'2021-02-01','P')
insert into Attendance values(15016,'2021-02-01','P')
insert into Attendance values(15017,'2021-02-01','P')
insert into Attendance values(15018,'2021-02-01','P')
insert into Attendance values(15019,'2021-02-01','P')
insert into Attendance values(15020,'2021-02-01','P')

insert into Attendance values(15001,'2021-02-02','P')
insert into Attendance values(15002,'2021-02-02','A')
insert into Attendance values(15003,'2021-02-02','A')
insert into Attendance values(15004,'2021-02-02','A')
insert into Attendance values(15005,'2021-02-02','P')
insert into Attendance values(15006,'2021-02-02','P')
insert into Attendance values(15007,'2021-02-02','P')
insert into Attendance values(15008,'2021-02-02','P')
insert into Attendance values(15009,'2021-02-02','P')
insert into Attendance values(15010,'2021-02-02','P')
insert into Attendance values(15011,'2021-02-02','P')
insert into Attendance values(15012,'2021-02-02','P')
insert into Attendance values(15013,'2021-02-02','P')
insert into Attendance values(15014,'2021-02-02','P')
insert into Attendance values(15015,'2021-02-02','P')
insert into Attendance values(15016,'2021-02-02','P')
insert into Attendance values(15017,'2021-02-02','P')
insert into Attendance values(15018,'2021-02-02','P')
insert into Attendance values(15019,'2021-02-02','P')
insert into Attendance values(15020,'2021-02-02','P')

insert into Attendance values(15001,'2021-02-03','P')
insert into Attendance values(15002,'2021-02-03','P')
insert into Attendance values(15003,'2021-02-03','A')
insert into Attendance values(15004,'2021-02-03','A')
insert into Attendance values(15005,'2021-02-03','A')
insert into Attendance values(15006,'2021-02-03','P')
insert into Attendance values(15007,'2021-02-03','P')
insert into Attendance values(15008,'2021-02-03','P')
insert into Attendance values(15009,'2021-02-03','P')
insert into Attendance values(15010,'2021-02-03','P')
insert into Attendance values(15011,'2021-02-03','P')
insert into Attendance values(15012,'2021-02-03','P')
insert into Attendance values(15013,'2021-02-03','P')
insert into Attendance values(15014,'2021-02-03','P')
insert into Attendance values(15015,'2021-02-03','P')
insert into Attendance values(15016,'2021-02-03','P')
insert into Attendance values(15017,'2021-02-03','P')
insert into Attendance values(15018,'2021-02-03','P')
insert into Attendance values(15019,'2021-02-03','P')
insert into Attendance values(15020,'2021-02-03','P')

insert into Attendance values(15001,'2021-02-04','P')
insert into Attendance values(15002,'2021-02-04','P')
insert into Attendance values(15003,'2021-02-04','P')
insert into Attendance values(15004,'2021-02-04','A')
insert into Attendance values(15005,'2021-02-04','A')
insert into Attendance values(15006,'2021-02-04','A')
insert into Attendance values(15007,'2021-02-04','P')
insert into Attendance values(15008,'2021-02-04','P')
insert into Attendance values(15009,'2021-02-04','P')
insert into Attendance values(15010,'2021-02-04','P')
insert into Attendance values(15011,'2021-02-04','P')
insert into Attendance values(15012,'2021-02-04','P')
insert into Attendance values(15013,'2021-02-04','P')
insert into Attendance values(15014,'2021-02-04','P')
insert into Attendance values(15015,'2021-02-04','P')
insert into Attendance values(15016,'2021-02-04','P')
insert into Attendance values(15017,'2021-02-04','P')
insert into Attendance values(15018,'2021-02-04','P')
insert into Attendance values(15019,'2021-02-04','P')
insert into Attendance values(15020,'2021-02-04','P')

insert into Attendance values(15001,'2021-02-05','P')
insert into Attendance values(15002,'2021-02-05','P')
insert into Attendance values(15003,'2021-02-05','P')
insert into Attendance values(15004,'2021-02-05','P')
insert into Attendance values(15005,'2021-02-05','A')
insert into Attendance values(15006,'2021-02-05','A')
insert into Attendance values(15007,'2021-02-05','A')
insert into Attendance values(15008,'2021-02-05','P')
insert into Attendance values(15009,'2021-02-05','P')
insert into Attendance values(15010,'2021-02-05','P')
insert into Attendance values(15011,'2021-02-05','P')
insert into Attendance values(15012,'2021-02-05','P')
insert into Attendance values(15013,'2021-02-05','P')
insert into Attendance values(15014,'2021-02-05','P')
insert into Attendance values(15015,'2021-02-05','P')
insert into Attendance values(15016,'2021-02-05','P')
insert into Attendance values(15017,'2021-02-05','P')
insert into Attendance values(15018,'2021-02-05','P')
insert into Attendance values(15019,'2021-02-05','P')
insert into Attendance values(15020,'2021-02-05','P')

insert into Attendance values(15001,'2021-02-08','P')
insert into Attendance values(15002,'2021-02-08','P')
insert into Attendance values(15003,'2021-02-08','P')
insert into Attendance values(15004,'2021-02-08','P')
insert into Attendance values(15005,'2021-02-08','P')
insert into Attendance values(15006,'2021-02-08','A')
insert into Attendance values(15007,'2021-02-08','A')
insert into Attendance values(15008,'2021-02-08','A')
insert into Attendance values(15009,'2021-02-08','P')
insert into Attendance values(15010,'2021-02-08','P')
insert into Attendance values(15011,'2021-02-08','P')
insert into Attendance values(15012,'2021-02-08','P')
insert into Attendance values(15013,'2021-02-08','P')
insert into Attendance values(15014,'2021-02-08','P')
insert into Attendance values(15015,'2021-02-08','P')
insert into Attendance values(15016,'2021-02-08','P')
insert into Attendance values(15017,'2021-02-08','P')
insert into Attendance values(15018,'2021-02-08','P')
insert into Attendance values(15019,'2021-02-08','P')
insert into Attendance values(15020,'2021-02-08','P')

insert into Attendance values(15001,'2021-02-09','P')
insert into Attendance values(15002,'2021-02-09','P')
insert into Attendance values(15003,'2021-02-09','P')
insert into Attendance values(15004,'2021-02-09','P')
insert into Attendance values(15005,'2021-02-09','P')
insert into Attendance values(15006,'2021-02-09','P')
insert into Attendance values(15007,'2021-02-09','A')
insert into Attendance values(15008,'2021-02-09','A')
insert into Attendance values(15009,'2021-02-09','A')
insert into Attendance values(15010,'2021-02-09','P')
insert into Attendance values(15011,'2021-02-09','P')
insert into Attendance values(15012,'2021-02-09','P')
insert into Attendance values(15013,'2021-02-09','P')
insert into Attendance values(15014,'2021-02-09','P')
insert into Attendance values(15015,'2021-02-09','P')
insert into Attendance values(15016,'2021-02-09','P')
insert into Attendance values(15017,'2021-02-09','P')
insert into Attendance values(15018,'2021-02-09','P')
insert into Attendance values(15019,'2021-02-09','P')
insert into Attendance values(15020,'2021-02-09','P')

insert into Attendance values(15001,'2021-02-10','P')
insert into Attendance values(15002,'2021-02-10','P')
insert into Attendance values(15003,'2021-02-10','P')
insert into Attendance values(15004,'2021-02-10','P')
insert into Attendance values(15005,'2021-02-10','P')
insert into Attendance values(15006,'2021-02-10','P')
insert into Attendance values(15007,'2021-02-10','P')
insert into Attendance values(15008,'2021-02-10','A')
insert into Attendance values(15009,'2021-02-10','A')
insert into Attendance values(15010,'2021-02-10','A')
insert into Attendance values(15011,'2021-02-10','P')
insert into Attendance values(15012,'2021-02-10','P')
insert into Attendance values(15013,'2021-02-10','P')
insert into Attendance values(15014,'2021-02-10','P')
insert into Attendance values(15015,'2021-02-10','P')
insert into Attendance values(15016,'2021-02-10','P')
insert into Attendance values(15017,'2021-02-10','P')
insert into Attendance values(15018,'2021-02-10','P')
insert into Attendance values(15019,'2021-02-10','P')
insert into Attendance values(15020,'2021-02-10','P')

insert into Attendance values(15001,'2021-02-11','P')
insert into Attendance values(15002,'2021-02-11','P')
insert into Attendance values(15003,'2021-02-11','P')
insert into Attendance values(15004,'2021-02-11','P')
insert into Attendance values(15005,'2021-02-11','P')
insert into Attendance values(15006,'2021-02-11','P')
insert into Attendance values(15007,'2021-02-11','P')
insert into Attendance values(15008,'2021-02-11','P')
insert into Attendance values(15009,'2021-02-11','A')
insert into Attendance values(15010,'2021-02-11','A')
insert into Attendance values(15011,'2021-02-11','A')
insert into Attendance values(15012,'2021-02-11','P')
insert into Attendance values(15013,'2021-02-11','P')
insert into Attendance values(15014,'2021-02-11','P')
insert into Attendance values(15015,'2021-02-11','P')
insert into Attendance values(15016,'2021-02-11','P')
insert into Attendance values(15017,'2021-02-11','P')
insert into Attendance values(15018,'2021-02-11','P')
insert into Attendance values(15019,'2021-02-11','P')
insert into Attendance values(15020,'2021-02-11','P')

insert into Attendance values(15001,'2021-02-12','P')
insert into Attendance values(15002,'2021-02-12','P')
insert into Attendance values(15003,'2021-02-12','P')
insert into Attendance values(15004,'2021-02-12','P')
insert into Attendance values(15005,'2021-02-12','P')
insert into Attendance values(15006,'2021-02-12','P')
insert into Attendance values(15007,'2021-02-12','P')
insert into Attendance values(15008,'2021-02-12','P')
insert into Attendance values(15009,'2021-02-12','A')
insert into Attendance values(15010,'2021-02-12','A')
insert into Attendance values(15011,'2021-02-12','A')
insert into Attendance values(15012,'2021-02-12','P')
insert into Attendance values(15013,'2021-02-12','P')
insert into Attendance values(15014,'2021-02-12','P')
insert into Attendance values(15015,'2021-02-12','P')
insert into Attendance values(15016,'2021-02-12','P')
insert into Attendance values(15017,'2021-02-12','P')
insert into Attendance values(15018,'2021-02-12','P')
insert into Attendance values(15019,'2021-02-12','P')
insert into Attendance values(15020,'2021-02-12','P')

insert into Attendance values(15001,'2021-02-15','P')
insert into Attendance values(15002,'2021-02-15','P')
insert into Attendance values(15003,'2021-02-15','P')
insert into Attendance values(15004,'2021-02-15','P')
insert into Attendance values(15005,'2021-02-15','P')
insert into Attendance values(15006,'2021-02-15','P')
insert into Attendance values(15007,'2021-02-15','P')
insert into Attendance values(15008,'2021-02-15','P')
insert into Attendance values(15009,'2021-02-15','A')
insert into Attendance values(15010,'2021-02-15','A')
insert into Attendance values(15011,'2021-02-15','A')
insert into Attendance values(15012,'2021-02-15','P')
insert into Attendance values(15013,'2021-02-15','P')
insert into Attendance values(15014,'2021-02-15','P')
insert into Attendance values(15015,'2021-02-15','P')
insert into Attendance values(15016,'2021-02-15','P')
insert into Attendance values(15017,'2021-02-15','P')
insert into Attendance values(15018,'2021-02-15','P')
insert into Attendance values(15019,'2021-02-15','P')
insert into Attendance values(15020,'2021-02-15','P')

insert into Attendance values(15001,'2021-02-16','P')
insert into Attendance values(15002,'2021-02-16','P')
insert into Attendance values(15003,'2021-02-16','P')
insert into Attendance values(15004,'2021-02-16','P')
insert into Attendance values(15005,'2021-02-16','P')
insert into Attendance values(15006,'2021-02-16','P')
insert into Attendance values(15007,'2021-02-16','P')
insert into Attendance values(15008,'2021-02-16','P')
insert into Attendance values(15009,'2021-02-16','P')
insert into Attendance values(15010,'2021-02-16','P')
insert into Attendance values(15011,'2021-02-16','A')
insert into Attendance values(15012,'2021-02-16','A')
insert into Attendance values(15013,'2021-02-16','P')
insert into Attendance values(15014,'2021-02-16','A')
insert into Attendance values(15015,'2021-02-16','P')
insert into Attendance values(15016,'2021-02-16','P')
insert into Attendance values(15017,'2021-02-16','P')
insert into Attendance values(15018,'2021-02-16','P')
insert into Attendance values(15019,'2021-02-16','P')
insert into Attendance values(15020,'2021-02-16','P')

insert into Attendance values(15001,'2021-02-17','P')
insert into Attendance values(15002,'2021-02-17','P')
insert into Attendance values(15003,'2021-02-17','P')
insert into Attendance values(15004,'2021-02-17','P')
insert into Attendance values(15005,'2021-02-17','P')
insert into Attendance values(15006,'2021-02-17','P')
insert into Attendance values(15007,'2021-02-17','P')
insert into Attendance values(15008,'2021-02-17','P')
insert into Attendance values(15009,'2021-02-17','P')
insert into Attendance values(15010,'2021-02-17','P')
insert into Attendance values(15011,'2021-02-17','P')
insert into Attendance values(15012,'2021-02-17','A')
insert into Attendance values(15013,'2021-02-17','A')
insert into Attendance values(15014,'2021-02-17','A')
insert into Attendance values(15015,'2021-02-17','P')
insert into Attendance values(15016,'2021-02-17','P')
insert into Attendance values(15017,'2021-02-17','P')
insert into Attendance values(15018,'2021-02-17','P')
insert into Attendance values(15019,'2021-02-17','P')
insert into Attendance values(15020,'2021-02-17','P')


insert into Attendance values(15001,'2021-02-18','P')
insert into Attendance values(15002,'2021-02-18','P')
insert into Attendance values(15003,'2021-02-18','P')
insert into Attendance values(15004,'2021-02-18','P')
insert into Attendance values(15005,'2021-02-18','P')
insert into Attendance values(15006,'2021-02-18','P')
insert into Attendance values(15007,'2021-02-18','P')
insert into Attendance values(15008,'2021-02-18','P')
insert into Attendance values(15009,'2021-02-18','P')
insert into Attendance values(15010,'2021-02-18','P')
insert into Attendance values(15011,'2021-02-18','P')
insert into Attendance values(15012,'2021-02-18','P')
insert into Attendance values(15013,'2021-02-18','A')
insert into Attendance values(15014,'2021-02-18','A')
insert into Attendance values(15015,'2021-02-18','A')
insert into Attendance values(15016,'2021-02-18','P')
insert into Attendance values(15017,'2021-02-18','P')
insert into Attendance values(15018,'2021-02-18','P')
insert into Attendance values(15019,'2021-02-18','P')
insert into Attendance values(15020,'2021-02-18','P')


insert into Attendance values(15001,'2021-02-19','P')
insert into Attendance values(15002,'2021-02-19','P')
insert into Attendance values(15003,'2021-02-19','P')
insert into Attendance values(15004,'2021-02-19','P')
insert into Attendance values(15005,'2021-02-19','P')
insert into Attendance values(15006,'2021-02-19','P')
insert into Attendance values(15007,'2021-02-19','P')
insert into Attendance values(15008,'2021-02-19','P')
insert into Attendance values(15009,'2021-02-19','P')
insert into Attendance values(15010,'2021-02-19','P')
insert into Attendance values(15011,'2021-02-19','P')
insert into Attendance values(15012,'2021-02-19','P')
insert into Attendance values(15013,'2021-02-19','P')
insert into Attendance values(15014,'2021-02-19','A')
insert into Attendance values(15015,'2021-02-19','A')
insert into Attendance values(15016,'2021-02-19','A')
insert into Attendance values(15017,'2021-02-19','P')
insert into Attendance values(15018,'2021-02-19','P')
insert into Attendance values(15019,'2021-02-19','P')
insert into Attendance values(15020,'2021-02-19','P')

insert into Attendance values(15001,'2021-02-22','P')
insert into Attendance values(15002,'2021-02-22','P')
insert into Attendance values(15003,'2021-02-22','P')
insert into Attendance values(15004,'2021-02-22','P')
insert into Attendance values(15005,'2021-02-22','P')
insert into Attendance values(15006,'2021-02-22','P')
insert into Attendance values(15007,'2021-02-22','P')
insert into Attendance values(15008,'2021-02-22','P')
insert into Attendance values(15009,'2021-02-22','P')
insert into Attendance values(15010,'2021-02-22','P')
insert into Attendance values(15011,'2021-02-22','P')
insert into Attendance values(15012,'2021-02-22','P')
insert into Attendance values(15013,'2021-02-22','P')
insert into Attendance values(15014,'2021-02-22','P')
insert into Attendance values(15015,'2021-02-22','A')
insert into Attendance values(15016,'2021-02-22','A')
insert into Attendance values(15017,'2021-02-22','A')
insert into Attendance values(15018,'2021-02-22','P')
insert into Attendance values(15019,'2021-02-22','P')
insert into Attendance values(15020,'2021-02-22','P')

insert into Attendance values(15001,'2021-02-23','P')
insert into Attendance values(15002,'2021-02-23','P')
insert into Attendance values(15003,'2021-02-23','P')
insert into Attendance values(15004,'2021-02-23','P')
insert into Attendance values(15005,'2021-02-23','P')
insert into Attendance values(15006,'2021-02-23','P')
insert into Attendance values(15007,'2021-02-23','P')
insert into Attendance values(15008,'2021-02-23','P')
insert into Attendance values(15009,'2021-02-23','P')
insert into Attendance values(15010,'2021-02-23','P')
insert into Attendance values(15011,'2021-02-23','P')
insert into Attendance values(15012,'2021-02-23','P')
insert into Attendance values(15013,'2021-02-23','P')
insert into Attendance values(15014,'2021-02-23','P')
insert into Attendance values(15015,'2021-02-23','P')
insert into Attendance values(15016,'2021-02-23','A')
insert into Attendance values(15017,'2021-02-23','A')
insert into Attendance values(15018,'2021-02-23','A')
insert into Attendance values(15019,'2021-02-23','P')
insert into Attendance values(15020,'2021-02-23','P')
select * from Attendance
insert into Attendance values(15001,'2021-02-24','P')
insert into Attendance values(15002,'2021-02-24','P')
insert into Attendance values(15003,'2021-02-24','P')
insert into Attendance values(15004,'2021-02-24','P')
insert into Attendance values(15005,'2021-02-24','P')
insert into Attendance values(15006,'2021-02-24','P')
insert into Attendance values(15007,'2021-02-24','P')
insert into Attendance values(15008,'2021-02-24','P')
insert into Attendance values(15009,'2021-02-24','P')
insert into Attendance values(15010,'2021-02-24','P')
insert into Attendance values(15011,'2021-02-24','P')
insert into Attendance values(15012,'2021-02-24','P')
insert into Attendance values(15013,'2021-02-24','P')
insert into Attendance values(15014,'2021-02-24','P')
insert into Attendance values(15015,'2021-02-24','P')
insert into Attendance values(15016,'2021-02-24','P')
insert into Attendance values(15017,'2021-02-24','P')
insert into Attendance values(15018,'2021-02-24','A')
insert into Attendance values(15019,'2021-02-24','A')
insert into Attendance values(15020,'2021-02-24','A')
select * from Attendance
insert into Attendance values(15001,'2021-02-25','A')
insert into Attendance values(15002,'2021-02-25','P')
insert into Attendance values(15003,'2021-02-25','P')
insert into Attendance values(15004,'2021-02-25','P')
insert into Attendance values(15005,'2021-02-25','P')
insert into Attendance values(15006,'2021-02-25','P')
insert into Attendance values(15007,'2021-02-25','P')
insert into Attendance values(15008,'2021-02-25','P')
insert into Attendance values(15009,'2021-02-25','P')
insert into Attendance values(15010,'2021-02-25','P')
insert into Attendance values(15011,'2021-02-25','P')
insert into Attendance values(15012,'2021-02-25','P')
insert into Attendance values(15013,'2021-02-25','P')
insert into Attendance values(15014,'2021-02-25','P')
insert into Attendance values(15015,'2021-02-25','P')
insert into Attendance values(15016,'2021-02-25','P')
insert into Attendance values(15017,'2021-02-25','P')
insert into Attendance values(15018,'2021-02-25','P')
insert into Attendance values(15019,'2021-02-25','A')
insert into Attendance values(15020,'2021-02-25','A')
select * from Attendance

insert into Attendance values(15001,'2021-02-26','A')
insert into Attendance values(15002,'2021-02-26','A')
insert into Attendance values(15003,'2021-02-26','P')
insert into Attendance values(15004,'2021-02-26','P')
insert into Attendance values(15005,'2021-02-26','P')
insert into Attendance values(15006,'2021-02-26','P')
insert into Attendance values(15007,'2021-02-26','P')
insert into Attendance values(15008,'2021-02-26','P')
insert into Attendance values(15009,'2021-02-26','P')
insert into Attendance values(15010,'2021-02-26','P')
insert into Attendance values(15011,'2021-02-26','P')
insert into Attendance values(15012,'2021-02-26','P')
insert into Attendance values(15013,'2021-02-26','P')
insert into Attendance values(15014,'2021-02-26','P')
insert into Attendance values(15015,'2021-02-26','P')
insert into Attendance values(15016,'2021-02-26','P')
insert into Attendance values(15017,'2021-02-26','P')
insert into Attendance values(15018,'2021-02-26','P')
insert into Attendance values(15019,'2021-02-26','P')
insert into Attendance values(15020,'2021-02-26','A')


select * from Attendance
