Create database BookApp

use BookApp

Create Table Users
(
UserId int identity(1,1) Primary key,
FullName varchar(250) not null,
Email varchar(180) not null,
Password varchar(50) not null,
MobileNumber bigint not null
)

Select * from Users


-------------- Store procedure for registeration -------------
Create proc UserRegister
(
@FullName varchar(250),
@Email varchar(180),
@Password varchar(50),
@MobileNumber bigint
)
As
Begin
	insert Users
	values (@FullName, @Email, @Password, @MobileNumber)
End;


------------- Store Procedure for Login---------------
create proc LogIn
(
@Email varchar(180),
@Password varchar(50)
)
As
Begin
	select * from Users where Email=@Email and Password=@Password
End;



------------- Store procedure for forgetpassword --------------
create proc ForgetPassword
(
@Email varchar(180)
)
As
Begin
	Select * from Users where Email=@Email
End;



--------------- Store procedure for Resetpassword ---------------
create proc ResetPassword
(
@Email varchar(180),
@Password varchar(50)
)
As
begin
	Update Users
	Set Password=@Password where Email=@Email
End;