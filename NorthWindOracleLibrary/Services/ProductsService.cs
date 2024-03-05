using Microsoft.EntityFrameworkCore;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;
using System.Numerics;

namespace NorthWindOracleLibrary.Services;

public class ProductsService : IOperations<Products>
{
    private readonly Context _context;

    public ProductsService(Context context)
    {
        _context = context;
    }
    public void Add(in Products sender)
    {
        throw new NotImplementedException();
    }

    public List<Products> GetAll()
    {
        return _context.Products.Include(x => x.Categories).ToList();
    }

    public async Task<List<Products>> GetAllAsync()
    {
        return await _context.Products.Include(x => x.Categories).ToListAsync();
    }

    public Products GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Products> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Products GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Products> GetByIdWithIncludesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
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

    public void Update(in Products sender)
    {
        throw new NotImplementedException();
    }
}