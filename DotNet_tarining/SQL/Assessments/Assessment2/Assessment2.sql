use HariDB

declare @brithday date = '1998-07-27'

select 

@brithday as birthday,

DATENAME(weekday,@Brithday) as dayofweek
 
declare  @Brithday date = '1998-07-27'

select 

DATEDIFF(day,@Brithday,getdate()) as AgeInDays

select * from Employee
       where year(getdate()) - year(hiredate) > 5
       And month(hiredate) = month(getdate());

CREATE FUNCTION CalB (@deptNo INT, @salary DECIMAL(10, 2))
 
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @bonus DECIMAL(10, 2);
    IF @deptNo = 10
        SET @bonus = @Salary * 0.15;
    ELSE IF @DeptNo = 20
        SET @bonus = @Salary * 0.20;
    ELSE
        SET @bonus = @Salary * 0.05;
    RETURN @bonus;
END;
 
SELECT
    empno
    ename,
    DeptNo,
    Salary,
    dbo.CalB(DeptNo, Salary) AS Bonus
FROM
    Employee;

CREATE TABLE employee1 (
    empno INT PRIMARY KEY,
    ename VARCHAR(50),
    sal DECIMAL(10),
    doj DATE
);

 
INSERT INTO Employee1 
VALUES 
(1, 'hari', 1200, '1998-07-27'),
(2, 'vasu', 1400, '1995-03-10'),
(3, 'mani', 1600, '1998-07-20');
select * from employee1
-- b. Update the second row salary with a 15% increment
UPDATE Employee1
SET sal = sal * 1.15
WHERE empno = 2;
-- c. Delete the first row
DELETE FROM Employee1
WHERE empno = 1;
rollback
commit
 
SELECT * FROM Employee1;

create or alter proc updateSal
as
begin
update e
set e.salary = e.salary+ 500 
from employee e
Join department D ON e.DeptNo = d.Deptno
where d.Dname = 'Sales' and e.salary < 1500;
end
exec updateSal;
select * from Employee
 