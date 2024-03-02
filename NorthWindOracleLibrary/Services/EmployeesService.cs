using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Services;

public class EmployeesService : IEmployeesService
{
    private readonly Context _context;

    public EmployeesService(Context context)
    {
        _context = context;
    }

    public List<Employees> GetEmployees() 
        => _context.Employees.ToList();

    public Employees? GetById(int employeeId) 
        => _context.Employees.FirstOrDefault(x => x.EmployeeId == employeeId);

    /// <summary>
    /// Update a single <see cref="Employees"/>
    /// </summary>
    /// <param name="employees">Valid entity</param>
    /// <returns>
    /// On success, true/null for exception, on failure false and the exception
    /// </returns>
    /// <remarks>
    /// EF Core will update all columns
    /// </remarks>
    public (bool, Exception exception) Update(Employees employees)
    {
        try
        {
            _context.Employees.Attach(employees).State = EntityState.Modified;

            var affected = _context.SaveChanges();
            return (affected == 1, null)!;
        }
        catch (Exception localException)
        {
            return (false, localException);
        }
    }

    public (bool, Exception exception) Remove(Employees employees)
    {
        throw new NotImplementedException();
    }

    public (bool, Exception exception) Add(Employees employees)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// An example to show how to control what columns are updated as apposed to <see cref="Update"/> method
    /// </summary>
    /// <param name="employees">Valid entity</param>
    /// <returns>
    /// On success, true/null for exception, on failure false and the exception
    /// </returns>
    /// <remarks>
    /// If you want to update more properties, repeat what was done for FirstName e.g. LastName too
    /// </remarks>
    public (bool, Exception exception) UpdateFirstNameOnly(Employees employees)
    {
        try
        {
            _context.Employees.Attach(employees);
            UpdateSpecificField(employees, x => x.FirstName);
            //UpdateSpecificField(employees, x => x.FirstName, x => x.LastName);
            
            var affected = _context.SaveChanges();
            return (affected == 1, null)!;
        }
        catch (Exception localException)
        {
            return (false, localException);
        }
    }

    /// <summary>
    /// Used to set individual propertie(s) of an entity
    /// </summary>
    /// <param name="entity">Valid Employee</param>
    /// <param name="updatedProperties">List of properties</param>
    public void UpdateSpecificField(Employees entity, params Expression<Func<Employees, object>>[] updatedProperties)
    {
        foreach (var property in updatedProperties)
        {
            _context.Entry(entity).Property(property).IsModified = true;
        }
    }
}
