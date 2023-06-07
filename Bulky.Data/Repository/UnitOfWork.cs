namespace Bulky.Data.Repository;

public class UnitOfWork : IUnitOfWork
{
    public ICategoryRepository CategoryRepository { get; private set; }
    private readonly AppDbContext _dbContext;

    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        CategoryRepository = new CategoryRepository(_dbContext);
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }
}