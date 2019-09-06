create database RabbitDb
go



use RabbitDb
go

CREATE TABLE Rabbits(
	RabbitId NOT NULL IDENTITY PRIMARY KEY,
	AGE INT,
	Name VARCHAR(50) NULL
);
select 'Here is a comment'