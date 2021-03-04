use ALMS

---ADD EMPLOYEE PROCEDURE
CREATE PROCEDURE spAddEmployee	
	@EmpName varchar(30) ,
	@EmpDesignation varchar(20),
	@EmpDOB datetime ,
	@EmpAddress varchar(100),
	@MgrId int,
	@ProjectId int
AS
BEGIN
	SET NOCOUNT OFF;
	INSERT INTO EmployeeDetails VALUES(@EmpName, @EmpDesignation, @EmpDOB, @EmpAddress, @MgrId, @ProjectId);
END
GO
exec spAddEmployee  'Divya Shukla', '.NET', '1993-07-12', 'Lane24, Mumbai', 5010, 10

select * from EmployeeDetails


---DELETE EMPLOYEE PROCEDURE
CREATE PROCEDURE spDeleteEmployee
	@EmpId int
AS
BEGIN
	SET NOCOUNT OFF;
	Delete from EmployeeDetails  where EmpId = @EmpId;
END
GO
exec spDeleteEmployee 15021
select * from EmployeeDetails

--PROCEDURE TO UPDATE EMPLOYEE DETAILS
CREATE PROCEDURE spUpdateEmployee
	@EmpId INT,
	@EmpName varchar(30),
	@EmpDesignation varchar(20),
	@EmpDOB datetime,
	@EmpAddress varchar(100),
	@MgrId int,
	@ProjectId int
AS
BEGIN
	SET NOCOUNT OFF;
	update EmployeeDetails set
	EmpName=@EmpName,
	EmpDesignation=@EmpDesignation,
	EmpDOB=@EmpDOB,
	EmpAddress=@EmpAddress,	
	MgrId=@MgrId,
	ProjectId=@ProjectId
	where EmpId = @EmpId;
END
GO

exec spUpdateEmployee
@EmpId= 15020,
@EmpName ='Rohan Jalan',
@EmpDesignation='Python',
@EmpDOB= '03/03/90',
@EmpAddress='Lane20, Hyderabad',
@MgrId= 5010,
@ProjectId= 10

select * from EmployeeDetails

--PROCEDURE TO ADD PROJECT

Create Procedure spAddProject

@ProjName varchar(30) ,
@ProjectTechnology varchar(30),
@StartDate datetime,
@EndDate datetime
AS
BEGIN
SET NOCOUNT OFF;
	INSERT INTO ProjectDetails VALUES(@ProjName, @ProjectTechnology,@Startdate, @Enddate);
END
GO

exec spAddProject
 @ProjName='HUIHUI', @ProjectTechnology='SAP', @Startdate='12/30/21', @Enddate='01/31/22'

select * from ProjectDetails

--PROCEDURE TO DELETE PROJECT
CREATE PROCEDURE spDeleteProject
@ProjectId int
AS
BEGIN
	SET NOCOUNT OFF;
	Delete from ProjectDetails  where ProjectId = @ProjectId;
END
GO
exec spDeleteProject 11
select * from ProjectDetails



--PROCEDURE TO UPDATE PROJECT
Create Procedure spUpdateProject
@ProjectId int ,
@ProjName varchar(30) ,
@ProjectTechnology varchar(30),
@StartDate datetime,
@EndDate datetime
AS
BEGIN
SET NOCOUNT OFF;
	update ProjectDetails set
	ProjName=@ProjName,
	ProjectTechnology=@ProjectTechnology,
	SDate=@StartDate,
	EDate=@Enddate
	where ProjectId = @ProjectId;
END
GO

exec spUpdateProject
@ProjectId=7,
@ProjName='PostgreSQL',
@ProjectTechnology='Salesforce',
@Startdate='12/30/21',
@Enddate='01/31/22'

select * from ProjectDetails

--PROCEDURE FOR MANAGER LOGIN

Create Procedure spManagerLogin
@UserName varchar(30) ,
@Pass varchar(30)
AS 
BEGIN
Select * from MgrLogin where UserName=@UserName and Pass=@Pass
END
GO

select * from MgrLogin
exec spManagerLogin 'CAPMGR5002', 'Pass5002'

--PROCEDURE FOR EMPLOYEE LOGIN

Create Procedure spEmployeeLogin
@UserName varchar(30) ,
@Pass varchar(30)
AS 
BEGIN
Select * from EmpLogin where UserName=@UserName and Pass=@Pass
END
GO
exec spEmployeeLogin 'CAPG15001', 'Pass15001'

