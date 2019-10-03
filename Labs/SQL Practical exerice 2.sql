-- Exercise 2, create spartans 

use master

 

drop database if exists SpartansDb 
go
create database SpartansDb
go
use SpartansDb
go

/*Spartans Table – include details about all the Spartans on this course. 
Separate Title, First Name and Last Name into separate columns, and include University attended, 
course taken and mark achieved. Add any other columns you feel would be appropriate. */

CREATE TABLE Spartans (
SpartanID INT NOT NULL IDENTITY PRIMARY KEY,
Title NVARCHAR(50) NULL,
FirstName NVARCHAR(50) NULL,
LastName NVARCHAR(50) NULL,
University NVARCHAR(50) NULL,
Course NVARCHAR(50) NULL,
Mark INT NULL,
TrueSpartan BIT NULL
)

INSERT INTO Spartans VALUES ('Dr','Aly','Esmail','Pythagoras University','Metaphysics',5,1)
INSERT INTO Spartans VALUES ('Elder','Fuat','Kalay','Johnsons University','Magic design',6,1)
INSERT INTO Spartans VALUES ('El bailarín','Jonathan','Freire-Benites','Universidad el Salsa','Accounting',8,1)
INSERT INTO Spartans VALUES ('El Mister','Miguel','Vieira','universidade portwein','Cooking',4,1)
INSERT INTO Spartans VALUES ('Big Man','Mohssin','Abihilal','Music school','Rapping',8,1)
INSERT INTO Spartans VALUES ('Pro','Myles','Muda','University of pros','How to get jobs first',10,1)
INSERT INTO Spartans VALUES ('Mrs','Ruoyi','Jiang','Cool School','Fishing',6,1)
INSERT INTO Spartans VALUES ('Sir','Ryan','Burdus','Imperial','Fish tank design',7,1)
INSERT INTO Spartans VALUES ('Strongman','Samuel','Ribeiro','Gym','Get big or go home',5,1)
INSERT INTO Spartans VALUES ('Lord','Alex','Vidzup','Internet','Science of memes',1,1)

SELECT * FROM Spartans