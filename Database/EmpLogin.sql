use AttendanceAndLeaveManagementSystem

create table EmpLogin(
EmpId varchar(10) foreign key references EmployeeDetails(EmpId),
EmpName varchar(30) not null,
UserName varchar(30) not null,
Pass varchar(30) not null
)

insert into EmpLogin values('CAPG1001', 'Abhishek Bhushan','CAPG1001','Python_Programmer1')
insert into EmpLogin values('CAPG1002', 'Harshit Joshi', 'CAPG1002','Python_Programmer2')
insert into EmpLogin values('CAPG1003', 'Akash Singh', 'CAPG1003','Python_Programmer3')
insert into EmpLogin values('CAPG1004', 'Sparsh Kotriwal','CAPG1004', 'Python_Programmer4')

insert into EmpLogin values('CAPG1005', 'Tanya Shukla','CAPG1005', 'Web_Developer1')
insert into EmpLogin values('CAPG1006', 'Megha Kayal', 'CAPG1006','Web_Developer2')
insert into EmpLogin values('CAPG1007', 'Mrityunjai Katiyar', 'CAPG1007','Web_Developer3')
insert into EmpLogin values('CAPG1008', 'Yash Tibrewala', 'CAPG1008','Web_Developer4')

insert into EmpLogin values('CAPG1009', 'Harshita Gupta', 'CAPG1009','.NET_Developer1')
insert into EmpLogin values('CAPG1010', 'Gauri Bindal','CAPG1010','.NET_Developer2')
insert into EmpLogin values('CAPG1011', 'Neha Rai', 'CAPG1011','.NET_Developer3')
insert into EmpLogin values('CAPG1012', 'Tarushi Sharma', 'CAPG1012','.NET_Developer4')

insert into EmpLogin values('CAPG1013', 'Twinkle Monga', 'CAPG1013','Data_Engineer1')
insert into EmpLogin values('CAPG1014', 'Vasundhara Chandel','CAPG1014','Data_Engineer2')
insert into EmpLogin values('CAPG1015', 'Sandeep Chaurasia', 'CAPG1015','Data_Engineer3')
insert into EmpLogin values('CAPG1016', 'Vinod Kumar', 'CAPG1016','Data_Engineer4')

insert into EmpLogin values('CAPG1017', 'Radhika Sharma', 'CAPG1017','Operations1')
insert into EmpLogin values('CAPG1018', 'Pranay Garg', 'CAPG1018','Operations2')
insert into EmpLogin values('CAPG1019', 'Akshat Saxena', 'CAPG1019','Operations3')
insert into EmpLogin values('CAPG1020', 'Karan Bhatia', 'CAPG1020','Operations4')

select * from EmpLogin
