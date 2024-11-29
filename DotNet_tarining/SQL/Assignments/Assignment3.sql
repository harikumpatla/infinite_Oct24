use InfiniteDB

--1. Retrieve a list of MANAGERS.
select ename from Employee where job='Manager'

--2. Find out the names and salaries of all employees earning more than 1000 per month. 
select ename , salary from Employee  where salary > 1000

--3. Display the names and salaries of all employees except JAMES.
select ename , salary from employee where ename <> 'james'

--4. Find out the details of employees whose names begin with ‘S’.
select * from Employee where ename like 's%'

--5. Find out the names of all employees that have ‘A’ anywhere in their name.
select * from Employee where ename like '%a%'

--6. Find out the names of all employees that have ‘L’ as their third character in  their name.
select * from Employee where ename like '__l%'

--7. Compute daily salary of JONES.
select ename , salary/30 as Daily_Salary from Employee where ename='jones'

--8. Calculate the total monthly salary of all employees.
select sum(salary) as 'Total_Monthly_Salary ' from Employee 

--9. Print the average annual salary . 
select avg(salary*12) as 'AVG Annual Salary' from Employee

--10. Select the name, job, salary, department number of all employees except SALESMAN from department number 30.
select ename,job,salary,deptno from Employee where job <> 'salesman' and Deptno<>30

--11. List unique departments of the EMP table.
select distinct(deptno) as 'Unique_Values' from Employee

--12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as Employee , salary as ' Monthly Salary' from Employee where salary>1500 and (Deptno = 10 or Deptno = 30) 

--13. Display the name, job, and salary of all the employees whose job is MANAGER or  ANALYST and their salary is not equal to 1000, 3000, or 5000.
select ename as Employee , salary as ' Monthly Salary' from Employee where (job='Manager' or job='analyst') and (salary<>1000 and salary<>3000 and salary<>5000)

---14. Display the name, salary and commission for all employees whose commission  amount is greater than their salary increased by 10%.
select ename , salary , comm from Employee where comm>salary*10/100

--15. Display the name of all employees who have two Ls in their name and are in  department 30 or their manager is 7782.
select ename from Employee where ename like '%ll%' and (Deptno=30 or Mgr_Id=7782)

--16. Display the names of employees with experience of over 30 years and under 40 yrs.Count the total number of employees.
select  ename ,count(ename) as 'Number Of Employees'  
from Employee 
where datediff(year,hiredate,getdate())  between 30 and 40
group by ename

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select d.dname,e.ename
from Employee e,dept d
where e.deptno = d.deptno
order by d.dname asc, e.ename desc

--18. Find out experience of MILLER.
select datediff(year,hiredate,getdate()) as 'Employee Experience' 
from Employee 
where ename = 'miller'

