use AttendanceAndLeaveMgmt;

create table MgrLogin(
MgrId varchar(10) foreign key references ManagerDetails(MgrId),
MgrName varchar(30) not null,
UserName varchar(30) not null,
Pass varchar(30) not null
)
insert into MgrLogin values('CAPMGR101', 'Uma Shankar Rawat', 'CAPMGR101','Python_Manager')
insert into MgrLogin values('CAPMGR102', 'Sandeep Joshi', 'CAPMGR102','Web_Development_Manager')
insert into MgrLogin values('CAPMGR103', 'Saket Acharya', 'CAPMGR103','.NET_Manager')
insert into MgrLogin values('CAPMGR104', 'Bali Devi', 'CAPMGR104','Data_Engineer_Manager')
insert into MgrLogin values('CAPMGR105', 'Prashant Manuja','CAPMGR105', 'Operations_Manager')


select * from MgrLogin