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



---DELETE EMPLOYEE PROCEDURE
CREATE PROCEDURE spDeleteEmployee
	@EmpId int
AS
BEGIN
	SET NOCOUNT OFF;
	Delete from EmployeeDetails  where EmpId = @EmpId;
END
GO




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



--PROCEDURE TO DELETE PROJECT
CREATE PROCEDURE spDeleteProject
@ProjectId int
AS
BEGIN
	SET NOCOUNT OFF;
	Delete from ProjectDetails  where ProjectId = @ProjectId;
END
GO




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



--PROCEDURE FOR MANAGER LOGIN

Create Procedure spManagerLogin
@UserName varchar(30) ,
@Pass varchar(30)
AS 
BEGIN
Select * from MgrLogin where UserName=@UserName and Pass=@Pass
END
GO




--PROCEDURE FOR EMPLOYEE LOGIN

Create Procedure spEmployeeLogin
@UserName varchar(30) ,
@Pass varchar(30)
AS 
BEGIN
Select * from EmpLogin where UserName=@UserName and Pass=@Pass
END
GO




create Procedure spAddNewLogin
@UserName varchar(30) ,
@Pass varchar(30)
AS 
BEGIN
INSERT INTO EmpLogin VALUES(@UserName, @Pass);
END
GO

select * from EmployeeDetails
select * from ManagerDetails
select * from EmpLogin
select * from ProjectDetails
select * from MgrLogin