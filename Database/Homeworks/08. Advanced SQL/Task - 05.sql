USE TelerikAcademy

SELECT AVG(e.Salary) AS AverageSalary
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'