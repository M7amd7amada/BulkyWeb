using System.Linq.Expressions;

namespace Bulky.Data.Repository.IRepository;

public interface IRepository<T> where T : class
{
    public List<T> GetAll();
    public T Get(Expression<Func<T, bool>> filter);
    public void Create(T entity);
    public void Delete(T entity);
    public void DeleteRange(IEnumerable<T> entities);
}