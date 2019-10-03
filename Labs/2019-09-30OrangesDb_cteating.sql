use master

 

drop database if exists OrangeDb 
go
create database OrangeDb
go

 

use OrangeDb
drop table if exists Oranges
drop table if exists Categories
drop table if exists Batch

 

CREATE TABLE Categories(
    CategoryID INT NOT NULL IDENTITY PRIMARY KEY,
    CategoryName NVARCHAR(50) NULL
)

 

CREATE TABLE Oranges(
/*if take off IDENTITY can manually type in primary key when inserting data*/
    OrangeID INT NOT NULL IDENTITY PRIMARY KEY,
    OrangeName NVARCHAR(50) NULL,
    DateHarvested Date NULL,
    IsLuxuryGrade Bit NULL,
    CategoryID INT NULL FOREIGN KEY REFERENCES Categories(CategoryID)
)

 

CREATE TABLE Batch(
    BatchID int not null identity primary key,
    OrangeID int null Foreign key references Oranges(OrangeID),
    Quantity int null,
    DespatchDate Date null
)
insert into Categories values ('Clementines');
insert into Categories values ('Reds');
insert into Categories values ('Easy Peelers');

 

insert into Oranges values ('Clementine','2019-09-07',0,1);
insert into Oranges values ('Blood Orange','2019-09-15',1,2);
insert into Oranges values ('Tangerine','2019-09-08','false',3);
insert into Oranges values ('Clementine','2018-12-25',0,1);

 

insert into Batch values(1,100,GETDATE());
insert into Batch values(2,100,GETDATE());
insert into Batch values(3,100,GETDATE());
insert into Batch values(4,50,'2019-08-01');

 

-- commenty
select * from Oranges
select * from Categories

 


select OrangeID, OrangeName, CategoryName from Oranges
inner join Categories on Oranges.CategoryID = Categories.CategoryID

 

-- Expiry date = harvest date + 90 days
select orangeid, orangename,categoryname, dateharvested, DATEADD(d,90,dateharvested) as 'ExpiryDate'
from oranges
inner join Categories on Oranges.CategoryID = Categories.CategoryID

 

select *, (DateDiff(d, dateharvested, DespatchDate))as 'SinceHarvested', 
Case
When (DateDiff(d, dateharvested, DespatchDate)) > 90 then 'true'
else 'false'
end
as 'IsExpired' from Batch
inner join oranges on Oranges.orangeid = batch.orangeid