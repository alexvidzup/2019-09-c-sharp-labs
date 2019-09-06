use master
go

drop database if exists RabbitDb
go


create database RabbitDb -- create 
go


use RabbitDb
go

CREATE TABLE Rabbits(
	RabbitId INT NOT NULL IDENTITY PRIMARY KEY,
	AGE INT,
	Name VARCHAR(50) NULL
);


INSERT INTO Rabbits VALUES ('1','Rabbit01') --create 
INSERT INTO Rabbits VALUES ('0','Rabbit02')
INSERT INTO Rabbits VALUES ('2','Rabbit03')

SET IDENTITY_INSERT Rabbits ON --To manually set rabbit ID
INSERT INTO Rabbits (RabbitID, Age, Name) values (4,0,'Rabbit04')
SET IDENTITY_INSERT Rabbits OFF


select 'Rabbit Database'

UPDATE Rabbits SET NAME ='Changed' WHERE RabbitId=3

DELETE FROM rabbits WHERE RabbitId=4

select * from Rabbits -- read all info

