create database SupperWaze

create table Clients
(
ClientCode int identity(1,1) primary key,
ClientName varchar(20) not null,
ClientAdress varchar(20) not null,
ClientPhone varchar(20) not null,
LastShoppingCode int foreign key references LastShopping(LastShoppingCode),
)
insert into Clients
(
ClientName,
ClientAdress,
ClientPhone
)
values
(
' שירה חוגה ',
'גינת היאור 64',
'0583253246'
)
select * from Clients
create table LastShopping
(
LastShoppingCode int identity(1,1) primary key,
ClientCode int not null,
ProductCode int foreign key references Products(ProductCode),
ProductAmount int not null
)
insert into LastShopping
(
ClientCode,
ProductCode,
ProductAmount
)
values
(
8,
35,
4
)
select * from LastShopping
create table Products
(
ProductCode int identity(1,1)primary key,
ProductDescription varchar(50) not null,
ProductLocation varchar(10) not null,
ProductPrice float not null,
SaleCode int foreign key references Sales(SaleCode)not null,
ProductCompany varchar(50) not null,
UnitsInStock int not null,
ProductCapacity varchar(30) not null,
ClassCode int foreign key references Classes(ClassCode),

)
insert  into Products 
(
ProductDescription,
ProductLocation,
ProductPrice,
SaleCode,
ProductCompany,
UnitsInStock,
ProductCapacity,
ClassCode
)
values
(
'כוסות שתיה קרה מעוטרות זהב',
'F,d,1,2',
9.9,
1,
' ניקול' ,
500,
'50',
2
)
select* From Products
create table Classes
(
ClassCode int identity(1,1) primary key,
ClassName varchar(30) not null,
ClassLocation varchar(20)not null
)
select* from Classes
insert into Classes
(
ClassName,
ClassLocation
)
values
(
'נקיון וחד פעמי' ,
'F'
)
create table Distances
(
ClassCode int identity(1,1) primary key,
Distance int not null,
ClassLocation varchar(1000) not null
)
create table Sales
(
SaleCode int identity(1,1) primary key,
ProductCode int not null,
MinimumNumberOfUnitsToBuy int not null,
MinimumPurshasePricePerOffer int not null,
)
--איך מוסיפים עמודה לטבלה בנויה
Add calum SalePrice int not null
 into Sales table 


Select* from Sales
insert into Sales
(
ProductCode,
MinimumNumberOfUnitsToBuy,
MinimumPurshasePricePerOffer
)
values
(
2,
2,
50,
9.9
)