create database Assessment1
use Assessment1

CREATE TABLE Book (
    ID INT PRIMARY KEY,
    Title VARCHAR(255),
    Author VARCHAR(255),
	ISBN_No VARCHAR(20) UNIQUE,
    ReviewerName VARCHAR(255))

insert into Book values(1,'My first  sql book','Mary Parker',981483029127,'2012-02-22 12:08:17')
insert into Book values(2,'My Second SQL book','John Mayer',857300923713,'1972-07-03 09:22:45')
insert into Book values(3,'My Third SQL book','Cary Flint',523120967812,'2015-10-18 14:05:44')

SELECT * FROM Book WHERE author LIKE '%er';

create table reviews(id int primary key references Book(id),book_id int,reviewer_name varchar(20),content varchar(30),rating int,published_date datetime)

insert into reviews values(1,1,'John Smith','My first review',4,'2017-12-10 05:50:11')
insert into reviews values(2,2,'John Smith','My Second review',5,'2017-10-13 15:05:12')
insert into reviews values(3,2,'Alice walker','Another review',1,'2017-10-22 23:47:10')

SELECT title, author, reviewerName FROM Book;

SELECT reviewer_name FROM reviews GROUP BY reviewer_name HAVING COUNT(*) > 1;

CREATE TABLE CUSTOMERS (
   ID INT PRIMARY KEY,
   NAME NVARCHAR(50),
   AGE INT,
   ADDRESS NVARCHAR(100),
   SALARY FLOAT
);

INSERT INTO CUSTOMERS (ID, NAME, AGE, ADDRESS, SALARY)
VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(13, 'Kaushik', 23, 'Kota', 2000.00),
(14, 'Chaitanya', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);

SELECT name FROM Customers WHERE address LIKE '%o%';

CREATE TABLE ORDERS (
   OID INT PRIMARY KEY,
   DATE DATETIME,
   CUSTOMER_ID INT,
   AMOUNT FLOAT,
   FOREIGN KEY (CUSTOMER_ID) REFERENCES CUSTOMERS(ID)
);

INSERT INTO ORDERS (OID, DATE, CUSTOMER_ID, AMOUNT)
VALUES
(100, '2009-10-08 00:00:00', 1, 3000.00),
(101, '2009-11-20 00:00:00', 2, 1500.00),
(102, '2009-10-08 00:00:00', 3, 2500.00),
(103, '2008-05-20 00:00:00', 4, 6500.00);

SELECT DATE, COUNT(*) AS TotalCustomers
FROM Orders
GROUP BY DATE;

CREATE TABLE Employee (
   ID INT PRIMARY KEY,       
   NAME VARCHAR(50),        
   AGE INT,                  
   ADDRESS VARCHAR(100),    
   SALARY FLOAT              
);

INSERT INTO Employee (ID, NAME, AGE, ADDRESS, SALARY)
VALUES
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(13, 'Kaushik', 23, 'Kota', 2000.00),
(14, 'Chaitanya', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP',null),
(7, 'Muffy', 24, 'Indore',null);

SELECT LOWER(Name) AS EmployeeName
FROM Employee
WHERE Salary IS NULL;

CREATE TABLE StudentDetails (
   RegisterNo INT PRIMARY KEY,
   Name VARCHAR(50),
   Age INT,
   Qualification VARCHAR(20),
   MobileNo BIGINT,
   Mail_id VARCHAR(50),
   Location VARCHAR(50),
   Gender CHAR(1)
);

INSERT INTO StudentDetails (RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gender)
VALUES
(2, 'Sai', 22, 'B.E', 9952836777, 'Sai@gmail.com', 'Chennai', 'M'),
(3, 'Kumar', 20, 'BSC', 7890125648, 'Kumar@gmail.com', 'Madurai', 'M'),
(4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Selam', 'F'),
(5, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
(6, 'SaiSaran', 21, 'B.A', NULL, NULL, 'Madurai', 'F'),
(7, 'Tom', 23, 'A', 7890345678, 'Tom@gmail.com', 'Pune', 'M');

SELECT Gender, COUNT(*) AS Total
FROM StudentDetails
GROUP BY Gender;