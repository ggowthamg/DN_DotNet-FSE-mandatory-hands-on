USE StoreProcedureDB;
GO

CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO


EXEC sp_InsertEmployee 
    @FirstName = 'Alice',
    @LastName = 'Williams',
    @DepartmentID = 3,
    @Salary = 7200.00,
    @JoinDate = '2022-06-01';


SELECT * FROM Employees;
