use BookApp

----------- Create address type for user -----------
create table AddressType
(
	TypeId int identity(1,1) primary key,
	AddressType varchar(max) not null
);

insert into AddressType
values('Home'),('Office'),('Others');

select * from AddressType



-------------- Create table for address ------------
create table Addresstable
(
AddressId int identity(1,1) primary key,
Address varchar(max) not null,
City varchar(100) not null,
State varchar(100) not null,
TypeId int not null foreign key (TypeId) references AddressType(TypeId),
UserId int not null foreign key (UserId) references Users(UserId)
)

select * from Addresstable



-------------- Store procedure for Adding address ---------------
create proc AddAddress
(
	@Address varchar(255),
    @City varchar(255),
    @State varchar(255),
    @TypeId int,  
	@UserId int
)
As
Begin
	Insert into Addresstable (Address, City, State, TypeId, UserId)
	values(@Address, @City, @State, @TypeId, @UserId);
End



---------------- Update Address -------------
create proc UpdateAddress
(
	@AddressId int,
	@Address varchar(255),
	@City varchar(100),
	@State varchar(100),
	@UserId int,
	@TypeId int
)
As
Begin
	update Addresstable set Address=@Address,
		City=@City, State=@State,TypeId=@TypeId 
		where UserId=@UserId and AddressId=@AddressId;
end



------------- for deleting address ---------------
create proc DeleteAddress
(
@UserId int,
@AddressId int
)
as
begin
	delete from AddressTable 
	where AddressId = @AddressId and UserId =@UserId;                      
End;




----------- for getting address --------
create proc GetAddress
(
@UserId int,
@AddressId int
)
as
begin
	delete from AddressTable 
	where AddressId = @AddressId and UserId =@UserId;                      
End;


