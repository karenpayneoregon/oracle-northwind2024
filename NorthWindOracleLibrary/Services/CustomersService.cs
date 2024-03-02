using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Services;

public class CustomersService : IOperations<Customers>
{
    private readonly Context _context;

    public CustomersService(Context context)
    {
        _context = context;
    }

    public List<Customers> GetAll()
    {
        return _context.Customers.ToList();
    }

    public Task<List<Customers>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Customers GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Customers GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Customers> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Customers> GetByIdWithIncludesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        throw new NotImplementedException();
    }

    public void Add(in Customers sender)
    {
        throw new NotImplementedException();
    }

    public void Update(in Customers sender)
    {
        throw new NotImplementedException();
    }

    public int Save()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }
}
