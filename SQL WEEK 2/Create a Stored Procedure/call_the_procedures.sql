EXEC sp_GetEmployeesByDepartment @DeptID = 3;

EXEC sp_InsertEmployee 
    @FirstName = 'Sarah', 
    @LastName = 'Williams', 
    @DepartmentID = 2, 
    @Salary = 6200.00, 
    @JoinDate = '2023-08-10';

SELECT * FROM Employees;
