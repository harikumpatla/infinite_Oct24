create database InfiniteDB

use InfiniteDB

Create table Employee
(
   empno int primary key,
   ename varchar(20) not null,
   job varchar(25) not null,
   Mgr_Id int ,
   Hiredate varchar(10) not null,
   salary int not null,
   COMM int ,
   Deptno int  references Dept(deptno)
)

create table Dept
(
   deptno int primary key,
   dname varchar(20) not null,
   loc varchar(15)
)

insert into Employee values(7369,' SMITH','CLERK',7902,'17-DEC-80',800,null,20),
(7499,'ALLEN','SALESMAN',7698,'20-FEB-81',1600,300,30),
(7521,'WARD','SALESMAN',7698,'22-FEB-81',1250,500,30),
(7566,'JONES','MANAGER',7839,'02-APR-81',2975,null,20),
(7654,'MARTIN','SALESMAN',7698,'28-SEP-81',1250,1400,30),
(7698,'BLAKE','MANAGER',7839,'01-MAY-81',2850,null,30),
(7782,'CLARK','MANAGER',7839,'09-JUN-81',2450,null,10),
(7788,'SCOTT','ANALYST',7566,'19-APR-87',3000,null,20),
(7839,'KING','PRESIDENT',null,'17-NOV-81',5000,null,10),
(7844,'TURNER','SALESMAN',7698,'08-SEP-81',1500,0,30),
(7876,'ADAMS','CLERK',7788,'23-MAY-87',1100,null,20),
(7900,'JAMES','CLERK',7698,'03-DEC-81',950,null,30),
(7902,'FORD','ANALYST',7566,'03-DEC-81',3000,null,20),
(7934,'MILLER','CLERK',7782,'23-JAN-82',1300,null,10)

insert into Dept values(10,'ACCOUNTING','NEW YORK'),
(20,'RESEARCH','DALLAS'),
(30,'SALES','CHICAGO'),
(40,'OPERATIONS','BOSTON')

--tasks

--1. List all employees whose name begins with 'A'.
select * from Employee
where ename like 'A%'

--2. Select all those employees who don't have a manager. 

select * from Employee
where Mgr_Id is null 

--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 

select ename,empno,salary from Employee
where salary>=1200 and salary<=1400

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.

select * , salary as 'Before Salary',salary+(salary*10/100) as 'After Salary' from Employee
where deptno=20

--5. Find the number of CLERKS employed. Give it a descriptive heading. 

select COUNT('job') as 'Total Clerks'from Employee 
where job='clerk'

--6. Find the average salary for each job type and the number of people employed in each job.

select job,avg(salary) as 'Emp Average' , COUNT('job') as 'Emp Count' from Employee
group by job

--7. List the employees with the lowest and highest salary. 

select Ename from Employee                        
where salary=(select max(salary) from Employee)
select ename from Employee 
where salary=(select min(salary) from Employee)

--8.Fetching department name which doesnt have employees.

select d.Dname                                 
from dept d Left join Employee e 
on d.Deptno=e.Deptno
where e.Deptno IS NULL

--9.Fetching details who is analyst and sal >1200 as well as deptno is 20
select * from Employee                            
where job='Analyst' and salary>1200 and deptno=20

---10.Fetching salaries,employee names and total salary based on their departemnt using self join
select e.Ename,e.salary,e.Deptno,sum(e1.salary) as 'Total salary'  
from Employee e join Employee e1
on e.Deptno=e1.Deptno
group by e.ename,e.salary,e.deptno

--11.Fetching sal of miller and smith using in opearator
select ename sal from Employee                    
where ename in ('King','miller')

--12.Fetching employee names whose names starts with A and M----
select ename from Employee                        
where Ename like 'A%' or  Ename like 'M%'

--13.Fetching annual salary of smith
select ename,salary,salary*12 as 'Smith Annual Salary'  
from Employee
where ename='Smith'

--14.Fetching Employee names and salaries whose salary is not in between 1500 and 2850
select ename,salary from Employee                     
where salary not between 1500 and 2850

--15.Fetching managers who have more than 2 employees reporting to them 
select mgr_id,count(*) as Emp_Count           
from Employee group by mgr_id
having  count(*)>2

create or alter proc sp_GetSalary(@salary int)
as
begin
   declare @ename
   declare @empno
   declare @salary
   select ename,empno,salary from Employee where  empno=@empid

   if(@salary<salary)
      
   end

sp_GetSalary 1250,7698