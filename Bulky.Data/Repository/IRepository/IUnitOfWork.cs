namespace Bulky.Data.Repository.IRepository; 

public interface IUnitOfWork
{
    public ICategoryRepository CategoryRepository { get; }

    public void Save();
}