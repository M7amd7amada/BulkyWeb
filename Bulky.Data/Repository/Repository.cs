using System.Linq.Expressions;
using Bulky.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Bulky.Data.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public List<T> GetAll()
        => _dbSet.ToList();

    public T Get(Expression<Func<T, bool>> filter)
        => _dbSet.FirstOrDefault(filter)!;

    public void Create(T entity)
    {
        _dbSet.Add(entity);
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public void DeleteRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}