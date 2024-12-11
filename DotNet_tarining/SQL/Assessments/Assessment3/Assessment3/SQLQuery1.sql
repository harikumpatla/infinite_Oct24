--1.Create a Function to calculate the course duration for the above relation by receiving start date and end date as input.


create table C_students (
C_ID varchar(10),
C_Name varchar(25),
Start_Date varchar(20),
End_Date varchar(20),
Fee int)

insert into C_students values('DN003','DotNet','2018-02-01','2018-02-28',15000),('DV004','DataVisualization','2018-03-01','2018-04-15',15000),('JA002','AdvancedJava','2018-01-02','2018-01-20',10000),('JC001','CoreJava','2018-01-02','2018-01-12',3000)
select * from C_students

create function Calculate_Course_Duration(@start_date DATE, @end_date DATE) 
returns int 
as 
begin 
return DATEDIFF(day, @start_date, @end_date) 
end 
select dbo.Calculate_Course_Duration('2018-01-02', '2018-01-20') AS DurationInDays;

--Create a trigger to display the Course Name and Start date of the course

CREATE TABLE T_CourseInfo(
C_Name VARCHAR(30),
Start_date DATE)
 

CREATE TRIGGER InsertionTrigger ON C_students
AFTER INSERT AS
BEGIN
INSERT INTO T_CourseInfo(C_Name, Start_date)
SELECT C_Name, Start_date FROM inserted 
END
 
INSERT INTO C_students VALUES
('HA004','DataScience','2020-11-12','2020-11-22',9000)
 
SELECT * FROM T_CourseInfo

select * from C_students


--3.Test the Procedure using ADO classes to call the Procedure and show the generated ProductId, and Discounted Price

CREATE TABLE ProductsDetails(
ProductID INT IDENTITY(1,1),
ProductName VARCHAR(20),
Price INT,
DiscountedPrice as (Price*0.90)
)
 
CREATE PROCEDURE ProdDetailsInsertion @ProductName VARCHAR(25), 
@Price INT, @ProductID INT OUTPUT as
BEGIN
INSERT INTO ProductsDetails(ProductName, Price) VALUES(@ProductName,@Price)
SET @ProductID = SCOPE_IDENTITY()
END
 
DECLARE @NewProductID INT
EXEC ProdDetailsInsertion 
@ProductName = 'Smart phone',
@Price = 20000,
@ProductID = @NewProductID OUTPUT
 
SELECT @NewProductID as ProductID
SELECT * FROM ProductsDetails






