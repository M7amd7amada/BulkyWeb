namespace Bulky.Data.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private readonly AppDbContext _dbContext;

    public ProductRepository(AppDbContext dbContext)
        : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public void Update(Product product)
    {
        _dbContext.Products?.Update(product);
    }
}