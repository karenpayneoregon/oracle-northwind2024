using Microsoft.EntityFrameworkCore;
using NorthWindOracleLibrary.Data;
using NorthWindOracleLibrary.Interfaces;
using NorthWindOracleLibrary.Models;

namespace NorthWindOracleLibrary.Services;

public class ContactTypeService : IOperations<ContactType>
{
    private readonly Context _context;

    public ContactTypeService(Context context)
    {
        _context = context;
    }

    public List<ContactType> GetAll()
    {
        return _context.ContactType.ToList();
    }

    public Task<List<ContactType>> GetAllAsync()
    {
        return _context.ContactType.ToListAsync();
    }

    public ContactType GetById(int id)
    {
        return _context.ContactType.FirstOrDefault(x => x.ContactTypeIdentifier == id)!;
    }

    public ContactType GetByIdWithIncludes(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ContactType> GetByIdAsync(int id)
    {
        return (await _context.ContactType.FirstOrDefaultAsync(x => x.ContactTypeIdentifier == id))!;
    }

    public Task<ContactType> GetByIdWithIncludesAsync(int id)
    {
        throw new NotImplementedException();
    }

    public bool Remove(int id)
    {
        ContactType contactType = _context.ContactType.FirstOrDefault(x => x.ContactTypeIdentifier == id)!;
        if (contactType is null)
        {
            return false;
        }
        else
        {
            _context.ContactType.Remove(contactType);
            var affected = _context.SaveChanges();
            return affected == 1;
        }
    }

    public void Add(in ContactType sender)
    {
        _context.Add(sender);
        _context.SaveChanges();
    }

    public void Update(in ContactType sender)
    {
        _context.Attach(sender).State = EntityState.Modified;
        _context.SaveChanges();
    }

    public int Save()
    {
        return _context.SaveChanges();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}