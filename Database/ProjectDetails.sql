use AttendanceAndLeaveMgmt

drop table ProjectDetails

create table ProjectDetails(
ProjectId varchar(10) primary key,
ProjName varchar(30) not null,
ProjectTechnology varchar(30),
SDate datetime not null,
EDate datetime not null
)
--python developer
insert into ProjectDetails values('PR101', 'ExpenseTracker', 'Python','2021-02-01','2021-02-21')
insert into ProjectDetails values('PR102', 'PropertyManagementSystem', 'Python', '2021-02-01','2021-02-21')
--web developer
insert into ProjectDetails values('PR103', 'EcommerceWebsite', 'ReactJs','2021-02-01','2021-02-21')
insert into ProjectDetails values('PR104', 'BankingSystem', 'AngularJs','2021-02-01','2021-02-21')
--.net developer
insert into ProjectDetails values('PR105', 'AI Desktop Partner', '.net', '2021-02-01','2021-02-21')
insert into ProjectDetails values('PR106', 'Smart Cab System', '.net','2021-02-01','2021-02-21')
--data engineer
insert into ProjectDetails values('PR107', 'Data Modeling', ' PostgreSQL','2021-02-01','2021-02-21')
insert into ProjectDetails values('PR108', 'Data Lake', 'Apache Spark', '2021-02-01','2021-02-21')
--operations
insert into ProjectDetails values('PR109', 'Evaluation of Quotations', 'Operations','2021-02-01','2021-02-21')
insert into ProjectDetails values('PR110', 'Review of Technical Design', 'Operations','2021-02-01','2021-02-21')

select * from ProjectDetails