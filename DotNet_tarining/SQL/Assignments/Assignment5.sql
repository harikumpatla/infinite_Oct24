--1. Write a T-Sql based procedure to generate complete payslip of a given employee with respect to the following condition

--   a) HRA as 10% of Salary
--   b) DA as 20% of Salary
--   c) PF as 8% of Salary
--   d) IT as 5% of Salary
--   e) Deductions as sum of PF and IT
--   f) Gross Salary as sum of Salary, HRA, DA
--   g) Net Salary as Gross Salary - Deductions

--Print the payslip neatly with all details

use InfiniteDB

create or alter  proc   Generate_PaySlip(@Empid int)
as begin
declare @Ename varchar(20),@Salary int
declare @HRA float
declare @DA float
declare @PF float
declare @IT float
declare @Deduction float
declare @Gross_Salary float
declare @Net_Salary float

select @Ename=EName,@Salary=salary from Employee where EmpNo=@Empid

set @HRA=@Salary*0.10
set @DA=@Salary*0.20
set @PF=@Salary*0.08
set @IT=@Salary*0.05
set @Deduction=@PF+@IT
set @Gross_Salary=@Salary+@HRA+@DA
set @Net_Salary=@Gross_Salary-@Deduction

print 'Payslip for Employee : ' +@Ename
print 'Basic Salary : '+cast(@Salary as varchar(10))
print 'HRA : ' +cast(@HRA as varchar(10))
print 'DA : ' +cast(@DA as varchar(10))
print 'PF : ' +cast(@PF as varchar(10))
print 'IT : ' +cast(@IT as varchar(10))
print 'Deduction : ' +cast(@Deduction as varchar(10))
print 'Gross salary : ' +cast(@Gross_Salary as varchar(10))
print 'Net salary : ' +cast(@Net_Salary as varchar(10))
end

exec Generate_PaySlip 7934

--2.Create a trigger to restrict data manipulation on EMP table during General holidays. Display the error message like “Due to Independence day you cannot manipulate data” or "Due To Diwali", you cannot manipulate" etc

CREATE TABLE Holidays (
    holiday_date DATE PRIMARY KEY,
    holiday_name VARCHAR(20) NOT NULL
);
use InfiniteDB
INSERT INTO Holidays (holiday_date, holiday_name) VALUES
('2025-01-26', 'Republic Day'),
('2025-03-12', 'Holi'),
('2025-08-15', 'Independence Day'),
('2025-10-25', 'Diwali');

insert into holidays values('2024-12-06','Holiday');

CREATE or alter TRIGGER RestrictManipulationOnHolidays
ON employee
for insert,update,delete
as
BEGIN
    DECLARE @holiday_name VARCHAR(20);
	declare @current_date date = cast(getdate() as date)
    SELECT @holiday_name =holiday_name
    FROM Holidays
    WHERE holiday_date = @current_date;
    IF @holiday_name IS NOT NULL
	begin
        raiserror('Data manipulation is restricted due to %s',16,1, @holiday_name)
		rollback transaction
    END 
END
update Employee set salary=1000 where EmpNo=7788
select * from Employee