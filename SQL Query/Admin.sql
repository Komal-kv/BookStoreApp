use BookApp

create table Admin
(
	AdminId int identity (1,1) primary key,
	FullName varchar(200) not null,
	EmailId varchar(180) not null,
	Password varchar(50) not null,
	MobileNumber bigint not null
);

insert into Admin
values('Shubham Pai', 'shubhampai@gmail.com', 'Shubhu123', 8788252797)

select * from Admin


------------ Admin Login ------------
create proc AdminLogin
(
@EmailId varchar(180),
@Password varchar(50)
)
As 
Begin
	Select * from Admin where EmailId=@EmailId and Password=@Password
End;

