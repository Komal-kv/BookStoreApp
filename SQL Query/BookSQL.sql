use BookApp

----Create table for book -----
Create Table Book
(
BookId int identity(1,1) not null primary key,
BookName varchar(270) not null,
AuthorName varchar(200) not null,
Rating  varchar(10) not null,
RatingCount int ,
DiscountPrice varchar(10) not null,
ActualPrice varchar(10) not null,
Description varchar(max) not null,
BookImage varchar(250),
BookQuantity int not null
);

select * from Book


--------Adding book--------
Create proc AddBook
(
@BookName varchar(270),
@AuthorName varchar(200),
@Rating varchar(10),
@RatingCount int,
@DiscountPrice varchar(10),
@ActualPrice varchar(10),
@Description varchar(max),
@BookImage varchar(250),
@BookQuantity int
)
as
begin
	insert into Book(BookName,AuthorName,Rating,RatingCount,DiscountPrice,ActualPrice,Description,BookImage,BookQuantity)
	values(@BookName,@AuthorName,@Rating,@RatingCount,@DiscountPrice,@ActualPrice,@Description,@BookImage,@BookQuantity);
end;


-----------------Update Book -------------
Create proc UpdateBook
(
@BookId int,
@BookName varchar(270),
@AuthorName varchar(200),
@Rating varchar(10),
@RatingCount int,
@DiscountPrice varchar(10),
@ActualPrice varchar(10),
@Description varchar(max),
@BookImage varchar(250),
@BookQuantity int
)
as
begin
update Book set 
BookName=@BookName,
AuthorName=@AuthorName,
Rating=@Rating,
RatingCount=@RatingCount,
DiscountPrice=@DiscountPrice,
ActualPrice=@ActualPrice,
Description=@Description,
BookImage=@BookImage,
BookQuantity=@BookQuantity
where BookId=@BookId			
end;


-------------- Delete Book ---------------
create proc DeleteBook
(
@BookId int
)
as
begin
delete from Book Where BookId=@BookId
end;


----------- GetBook by Id ------------
create proc GetBookById
(
@BookId int
)
as 
begin
select * from Book where BookId=@BookId
end;


---------- Get all Book ----------
create proc GetAllBooks
as 
begin
select * from Book
end;