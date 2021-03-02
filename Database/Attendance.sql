
use AttendanceAndLeaveMgmt;

create table Attendance(
EmpId varchar(10) foreign key references EmployeeDetails(EmpId),
EmpName varchar(30) NOT NULL,
TotalLeaves int NOT NULL default 3,
PDays int NOT NULL,
ADays int NOT NULL,

)



insert into Attendance values('CAPG1001', 'Abhishek Bhushan', Default, '27', '3')
insert into Attendance values('CAPG1002', 'Harshit Joshi',Default, '28', '2')
insert into Attendance values('CAPG1003', 'Akash Singh', Default, '30', '0')
insert into Attendance values('CAPG1004', 'Sparsh Kotriwal',Default, '29', '1')

insert into Attendance values('CAPG1005', 'Tanya Shukla', Default, '28', '2')
insert into Attendance values('CAPG1006', 'Megha Kayal',Default, '27', '3')
insert into Attendance values('CAPG1007', 'Mrityunjai Katiyar',Default, '29', '1')
insert into Attendance values('CAPG1008', 'Yash Tibrewala', Default, '30', '0')

insert into Attendance values('CAPG1009', 'Harshita Gupta', Default, '29', '1')
insert into Attendance values('CAPG1010', 'Gauri Bindal',Default, '28', '2')
insert into Attendance values('CAPG1011', 'Neha Rai', Default, '30', '0')
insert into Attendance values('CAPG1012', 'Tarushi Sharma', Default, '30', '0')

insert into Attendance values('CAPG1013', 'Twinkle Monga', Default, '29', '1')
insert into Attendance values('CAPG1014', 'Vasundhara Chandel',Default, '29', '1')
insert into Attendance values('CAPG1015', 'Sandeep Chaurasia', Default, '27', '3')
insert into Attendance values('CAPG1016', 'Vinod Kumar', Default, '28', '2')

insert into Attendance values('CAPG1017', 'Radhika Sharma', Default, '29', '1')
insert into Attendance values('CAPG1018', 'Pranay Garg', Default, '27', '3')
insert into Attendance values('CAPG1019', 'Akshat Saxena', Default, '28', '2')
insert into Attendance values('CAPG1020', 'Karan Bhatia', Default, '29', '1')

alter table Attendance add RemainingLeaves as TotalLeaves - ADays

select * from Attendance