create database Lab3456
go
use Lab3456

create table Location (
	locationID varchar(10) not null,
	locationName varchar(20),
	locationPrice int,
	startDateTime datetime,
	endDateTime datetime,
	availability int,
	constraint PK_locationID_locationName primary key(locationID),
)
select * from Location
--drop table Location
insert into Location values ('L00000001', 'Thao Cam Vien', 15000, '2022-11-30 09:44', '2022-11-30 10:44', 40) 
insert into Location values ('L00000002', 'Ho Boi Yet Kieu', 20000, '2022-12-30 09:44', '2022-12-30 10:44', 20) 
insert into Location values ('L00000003', 'NowZone', 10000, '2022-10-30 09:44', '2022-10-30 10:44', 10) 

create proc increaseAvailability @locationID varchar(10)
as
begin
	update Location set availability = availability + 1 where locationID=@locationID
end
--drop proc increaseAvailability
--exec increaseAvailability 'L00000001'

create proc decreaseAvailability @locationID varchar(10), @freeSpace int
as
begin
	update Location set availability = availability - @freeSpace where locationID = @locationID
end
--drop proc decreaseAvailability
--exec decreaseAvailability 'L00000001', 5


create table UserCreditCard(
	userID varchar(10) not null,
	userName varchar(20),
	userAge int,
	userCash int,
	created datetime,
	userPassword int,
	constraint PK_userID_userName primary key(userID),
)
select * from UserCreditCard
--drop table UserCreditCard
insert into UserCreditCard values ('00000001', 'Nguyen Van A', 20, 20000000, GETDATE(), 123)
insert into UserCreditCard values ('00000002', 'Nguyen Van B', 18, 1000000, GETDATE(), 123)

create proc decreaseCash @inputAmount int, @userID varchar(10)
as
begin
	update UserCreditCard set userCash = userCash - @inputAmount where userID = @userID
end
--drop proc decreaseCash
--exec decreaseCash 500000, '00000001'

create proc increaseCash @inputAmount int, @userID varchar(10)
as
begin
	update UserCreditCard set userCash = userCash + @inputAmount where userID = @userID
end
--drop proc decreaseCash
--exec increaseCash 500000, '00000001'


create table Invoice(
	invoiceID varchar(20) not null,
	userID varchar(10),
	totalPrice int,
	constraint PK_Invoice primary key(invoiceID),
	constraint FK_Invoice_UserCreditCard_userID foreign key (userID) references UserCreditCard(userID),
)
--drop table Invoice

create table InvoiceDetail(
	invoiceID varchar(20) not null,
	locationID varchar(10) not null,
	ticketAmount int,
	constraint FK_InvoiceDetail_Invoice_invoiceID foreign key (invoiceID) references Invoice(invoiceID),
	constraint FK_InvoiceDetail_Location_locationID foreign key (locationID) references Location(locationID),
	primary key(invoiceID, locationID),
)
--drop table InvoiceDetail
