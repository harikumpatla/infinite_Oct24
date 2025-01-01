create database Railway_Reservation_System
use Railway_Reservation_System
------------------ADMIN------------------------------------------------------------
create table Admin
(trainNumber int primary key,
trainName varchar(20),sleeper int , third int ,second int , first int,Total_Berth int , available_Berth int,source varchar(20),destination varchar(20),IsActive bit)

------------------------------------------------------------------------------------------------------------------------
------------ADD Trains-------------------

create or alter proc sp_addTrains
@trainNumber int,@trainName varchar(20),@sleeper int,@3rdClass int ,@2rdClass int ,@1rdClass int 
,@Total_Berth int ,@available_Berth int , @source varchar(20),@destination varchar(20),@isactive int
as 
begin
	if exists (select * from Admin where trainNumber=@trainNumber)
		begin
		 raiserror('Train Number Exists.....',16,1);
		 return;
		end;
	 insert into Admin
	 (trainNumber,trainName,sleeper,third,second,first,Total_Berth,available_Berth,source,destination,IsActive) 
	 values(@trainNumber,@trainName,@sleeper,@3rdClass,@2rdClass,@1rdClass,@Total_Berth,@available_Berth,@source,@destination,@isactive)
	 end

 --------------------------------------------------------------------------------------------------------------------
 ----------------------UPDATE TRAINS--------------------------------------------

create or alter proc sp_ModifyTrains
@trainNumber int,
@source varchar(20),
@destination varchar(20)
as 
begin
		if not exists (select * from Admin where trainNumber=@trainNumber)
		 begin
		  raiserror('Train Number does not exist..',16,1);
		  return;
		 end;
		update Admin set source = @source ,  destination=@destination , isactive=1 where trainNumber=@trainNumber
 end
----------------------------------------------------------------------------------------------------------------------
---------------------DELETE TRAINS---------------------------------------

create or alter proc sp_DeleteTrains
@trainNumber int
as 
begin
		if not exists (select * from Admin where trainNumber=@trainNumber)
		 begin
		   raiserror('Train Number does not exist..',16,1);
		   return;
		 end;
         update Admin set isactive = 0 where trainNumber=@trainNumber
 end
-------------------------------------------------------------------------------------------
------------------------------USERS-------------------------------------------------

create table Users(
PNR_Num int primary key,
Name varchar(30),
age int,
Gender varchar(30),
Train_Number int foreign key references Admin(trainNumber),
source varchar(20),
destination varchar(20),
classes varchar(20),
status varchar(20)
)
-----------------------------------------------------------------------------------------------------
-----------TICKET BOOKING-------------------------------

CREATE OR ALTER PROCEDURE sp_ticketbooking
    @train_No INT,
    @pname VARCHAR(20),
    @p_age INT,
    @gender VARCHAR(15),
    @class VARCHAR(20),
    @source VARCHAR(20),
    @destination VARCHAR(20),
	@seats INT,
    @status VARCHAR(20),
	@display VARCHAR(20) OUTPUT
AS
BEGIN
	DECLARE @pnr int;
    DECLARE @availabletkts INT;
    DECLARE @IsActive INT;
    SELECT @pnr = ISNULL(MAX(PNR_Num), 1806300) + 1 FROM Users;
    IF @class = 'FIRSTCLASS' or @class = 'SECONDCLASS' or @class = 'THIRDCLASS' or @class = 'SLEEPER'
    BEGIN
        SELECT @availabletkts = available_Berth,@IsActive = IsActive
        FROM Admin
        WHERE trainNumber = @train_No;
 
        IF @availabletkts >= @seats and @IsActive=1
        BEGIN
            
            INSERT INTO Users(PNR_Num,Name,age,Gender,Train_Number,source,destination,classes,status)
            VALUES (@pnr,@pname,@p_age,@gender,@train_No,@source,@destination,@class,@status);
 
            UPDATE Admin
            SET available_Berth = available_Berth - @seats
            WHERE trainNumber = @train_No;
 
            SET @display = 'Booked';
        END
    END
END;

---------SHOW TRAINS--------------------

create or alter proc sp_Show
@source varchar(20) , @destination varchar(20)
as
begin
   if not exists (select * from Admin where source=@source and destination=@destination)
	begin
	raiserror('No Trains are avaliable Between source and Destination! ',16,1);
	return;
    end;
	else select * from Admin where source=@source and destination=@destination
end

----------------CANCEL TICKET------------------------

create or alter procedure sp_Cancelticket
@pnr_no int
as
  begin
	declare @trainNo int;
	declare @class varchar(20);
	declare @status varchar(20);
 
     select @trainNo = Train_Number, @class = classes from Users where PNR_Num = @pnr_no and status = 'Booked'
	 if @class = 'SLEEPER' or @class = 'FIRSTCLASS' or @class = 'SECONDCLASS' or @class = 'THIRDCLASS'
	   begin
		 update Users set status = 'Cancelled' where PNR_Num = @pnr_no;
		 update Admin set available_Berth=available_Berth+1;
		 raiserror('Cancelled',16,1);
	   end;
	   else raiserror('Not Cancelled --- Please Enter Correct PNR Number Or Already Cancelled.',16,1);
  end;

  ---------------SHOW TICKET----------------
create or alter procedure sp_showTicket
@pnr_no int
as
  begin
     if not exists (select * from Users where PNR_Num = @pnr_no)
	 begin
	 raiserror('Error : Please Enter Correct PNR Number..',16,1);
	 return;
     end;
  end;
  select * from Users where PNR_Num = @pnr_no;



select * from Admin
select * from Users

