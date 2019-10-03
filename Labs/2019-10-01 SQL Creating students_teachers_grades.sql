use master

drop database if exists UniversityDb
go
create database UniversityDb
go

use UniversityDb

CREATE TABLE Students (
StudentID INT NOT NULL IDENTITY PRIMARY KEY,
StudentName NVARCHAR(50) NULL,
StudentDOB DATE NULL
)

create table Teachers(
TeacherID Int not null identity primary key,
TeacherName NVARCHAR(50) null,
)


CREATE TABLE Grades (
GradeId int not null identity primary key,

Grade int null ,
IfPass bit null,
GradeDate date null,
StudentID INT NULL FOREIGN KEY REFERENCES Students(StudentID),
TeacherID INT NULL FOREIGN KEY REFERENCES Teachers(TeacherID)
)



insert into Students values ('John','1985-01-15')
insert into Students values ('Mike','1990-05-20')
insert into Students values ('Peter','1995-10-30')

insert into Teachers values ('Mr Johnson')
insert into Teachers values ('Mrs Poppins')
insert into Teachers values ('Mr Anderson')

insert into Grades values (3,0,'2019-09-19',3,2)
insert into Grades values (4,1,'2019-09-09',1,3)
insert into Grades values (5,1,'2019-09-29',2,1)



select * from Students
select * from Teachers
select * from Grades

-- Joining 3 tables together
select * from Students
inner join Grades on Students.StudentID = Grades.StudentID
inner join Teachers on Teachers.TeacherID = Grades.TeacherID

--Comparing date of the grade with todays date and setting if statement for another table column
select *, DATEDIFF(d,GradeDate,GETDATE()) as 'DaysAgo',
Case
When DATEDIFF(d,GradeDate,GETDATE()) < 10 then 'yes'
else 'no'
end
as 'IsRepeatable' from Grades

-- adding 7 days to the date
select *, DATEADD(d,7,GradeDate) as 'NextGradeDate'
from Grades

insert into Students values ('Valentin','2000-05-05')

select * from Students

update Students
Set StudentName='Rafael', StudentDOB='1999-05-05'
WHERE StudentID = 4;

select * from Students

delete from Students where StudentID=4

select * from Students