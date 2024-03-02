
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Interfaces;

#pragma warning disable CS8603, CS8618

public interface IEmployeesService
{
    /// <summary>
    /// Get all employees
    /// </summary>
    List<Employees> GetEmployees();
    Employees? GetById(int employeeId);
    (bool, Exception exception) Update(Employees employees);
    (bool, Exception exception) Remove(Employees employees);
    (bool, Exception exception) Add(Employees employees);
    /// <summary>
    /// For article, for a real app we do first and last name
    /// </summary>
    (bool, Exception exception) UpdateFirstNameOnly(Employees employee);
}