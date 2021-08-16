-- Lewandowski Adam 
-- 15.08.2021
-- Topic: Data Insertion for the actual game

USE Student_Simulator
GO

DELETE FROM Student
DBCC CHECKIDENT ('Student', RESEED, 0)
GO
BULK INSERT Student
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataStudent.csv'
WITH ( FORMAT='CSV');
GO

--SELECT * FROM Student
--GO

DELETE FROM Department
DBCC CHECKIDENT ('Department', RESEED, 0)
GO
BULK INSERT Department
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataDepartment.csv'
WITH ( FORMAT='CSV');
GO

--SELECT * FROM Department
--GO

DELETE FROM Field_of_study
DBCC CHECKIDENT ('Field_of_study', RESEED, 0)
GO
BULK INSERT Field_of_study
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataFieldOfStudy.csv'
WITH ( FORMAT='CSV');
GO

--SELECT * FROM Field_of_study
--GO

DELETE FROM [Subject]
DBCC CHECKIDENT ('Subject', RESEED, 0)
GO
BULK INSERT [Subject]
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataSubject.csv'
WITH ( FORMAT='CSV');
GO

--SELECT * FROM [Subject]
--GO

DELETE FROM [Character]
DBCC CHECKIDENT ('Character', RESEED, 0)
GO
BULK INSERT [Character]
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataCharacter.csv'
WITH ( FORMAT='CSV');
GO

--SELECT * FROM [Character]
--GO

DELETE FROM Employee
DBCC CHECKIDENT ('Employee', RESEED, 0)
GO
BULK INSERT Employee
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataEmployee.csv'
WITH ( FORMAT='CSV');
GO

--SELECT * FROM Employee
--GO

DELETE FROM Subject_Assignment
DBCC CHECKIDENT ('Subject_Assignment', RESEED, 0)
GO
BULK INSERT Subject_Assignment
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataSubjectAssignment.csv'
WITH ( 
    FORMAT='CSV',
	FIRSTROW = 1);
GO

--SELECT * FROM Subject_Assignment
--GO


DELETE FROM Grades
DBCC CHECKIDENT ('Grades', RESEED, 0)
GO
BULK INSERT Grades
    FROM 'E:\Pendrive\Notatki\02. Wyk³ady\IV Semestr\PIV\Symulator Studenta\Student-Simulator\Student-Simulator\ServerDocumentation\TestDataGrades.csv'
WITH ( 
    FORMAT='CSV',
	FIRSTROW = 1);
GO

--SELECT * FROM Grades
--GO
