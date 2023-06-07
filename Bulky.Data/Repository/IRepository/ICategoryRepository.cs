namespace Bulky.Data.Repository.IRepository;

public interface ICategoryRepository : IRepository<Category>
{
    public void Update(Category category);
}