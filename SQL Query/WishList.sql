use BookApp

Create table WishList
(
	WishListId int identity(1,1) not null primary key,
	UserId int foreign key references Users(UserId) on delete no action,
	BookId int foreign key references Book(BookId) on delete no action
);

Select * from WishList


----------- Store procedure for add wishlist ----------
create procedure AddWishList
(
@UserId int,
@BookId int
)
as
begin 
       insert into WishList
	   values (@UserId,@BookId);
end;



------------- Store procedure for Delete wishlist ----------------
create procedure DeleteWishList
(
@WishListId int,
@UserId int
)
as
begin
delete WishList where WishListId = @WishListId and UserId=@UserId;
end;



----------------- Store procedure for get wishlist ------------------
Create procedure GetWishList
(
	@UserId int
)
as
begin
	select WishListId,UserId,c.BookId,BookName,AuthorName,
	DiscountPrice,ActualPrice,BookImage from WishList c join Book b on c.BookId=b.BookId 
	where UserId=@UserId;
end;
