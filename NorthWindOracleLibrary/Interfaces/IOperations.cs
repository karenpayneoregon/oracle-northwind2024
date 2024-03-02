namespace NorthWindOracleLibrary.Interfaces;
public interface IOperations<T> where T : class
{
    List<T> GetAll();
    Task<List<T>> GetAllAsync();
    T GetById(int id);
    T GetByIdWithIncludes(int id);
    Task<T> GetByIdAsync(int id);
    Task<T> GetByIdWithIncludesAsync(int id);
    bool Remove(int id);
    void Add(in T sender);
    void Update(in T sender);
    int Save();
    Task<int> SaveAsync();
}