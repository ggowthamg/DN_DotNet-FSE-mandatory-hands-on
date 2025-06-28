USE StoreProcedureDB;
GO

CREATE PROCEDURE sp_GetEmployeesByDepartment
    @DeptID INT
AS
BEGIN
    SELECT 
        E.EmployeeID,
        E.FirstName,
        E.LastName,
        D.DepartmentName,
        E.Salary,
        E.JoinDate
    FROM 
        Employees E
    INNER JOIN 
        Departments D ON E.DepartmentID = D.DepartmentID
    WHERE 
        E.DepartmentID = @DeptID;
END;
GO
EXEC sp_GetEmployeesByDepartment @DeptID = 2;
