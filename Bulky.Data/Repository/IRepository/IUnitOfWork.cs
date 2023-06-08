namespace Bulky.Data.Repository.IRepository; 

public interface IUnitOfWork
{
    public ICategoryRepository CategoryRepository { get; }
    public IProductRepository ProductRepository { get; }

    public void Save();
}