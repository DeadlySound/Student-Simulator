-- Lewandowski Adam 
-- 14.08.2021
-- Temat: Obs³uga sieci wyci¹gów narciarskich

USE master
GO


DROP DATABASE IF EXISTS Student_Simulator;
GO
CREATE DATABASE Student_Simulator
ON
(
	NAME = Student_Simulator,
	FILENAME = 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student_Simulator.mdf',
	SIZE = 10,
	MAXSIZE = 50,
	FILEGROWTH = 5
)
LOG ON
(
	NAME = Student_Simulator_log,
	FILENAME = 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Symulator_Studenta_log.ldf',
	SIZE = 5MB,
	MAXSIZE = 25MB,
	FILEGROWTH = 5MB
);
GO

USE Student_Simulator
GO
DROP TABLE IF EXISTS Student;
GO
CREATE TABLE Student
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nickname nvarchar(32) NOT NULL,
)
GO


USE Student_Simulator
GO
DROP TABLE IF EXISTS School;			-- "Katedra" in Polish (I hope)
GO
CREATE TABLE School
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
[Name] nvarchar(128) NOT NULL
)
GO


USE Student_Simulator
GO
DROP TABLE IF EXISTS Field_of_study;			-- "Kierunek studiów" in Polish (I hope)
GO
CREATE TABLE Field_of_study
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
)
GO


USE Student_Simulator
GO
DROP TABLE IF EXISTS [Subject];												-- "Kierunek studiów" in Polish (I hope)
GO
CREATE TABLE [Subject]
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
[Name] nvarchar(64) NOT NULL,
Hours_per_week int NOT NULL,
Field_of_study_ID int NOT NULL FOREIGN KEY REFERENCES Field_of_study(ID), 
Term int NOT NULL,															-- "Semestr"
School_ID int NOT NULL FOREIGN KEY REFERENCES School(ID)
)
GO

USE Student_Simulator
GO
DROP TABLE IF EXISTS [Character];
GO
CREATE TABLE [Character]
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
)
GO


USE Student_Simulator
GO
DROP TABLE IF EXISTS Employee;												-- 
GO
CREATE TABLE Employee
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
First_Name nvarchar(32) NOT NULL,
Last_Name nvarchar(32) NOT NULL,
Character_ID int NOT NULL,											
School_ID int NOT NULL FOREIGN KEY REFERENCES School(ID)
)
GO

USE Student_Simulator
GO
DROP TABLE IF EXISTS Subject_Assignment;												-- 
GO
CREATE TABLE Subject_Assignment
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Employee_ID int NOT NULL FOREIGN KEY REFERENCES Employee(ID),
Subject_ID int NOT NULL FOREIGN KEY REFERENCES [Subject](ID),
Academic_Year nvarchar(7) NOT NULL
)
GO

USE Student_Simulator
GO
DROP TABLE IF EXISTS Grades;												-- 
GO
CREATE TABLE Grades
(
ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
Subject_ID int NOT NULL FOREIGN KEY REFERENCES [Subject](ID),
Student_ID int NOT NULL FOREIGN KEY REFERENCES Student(ID),
Grade int NULL 
)
GO