namespace Bulky.Data.Repository.IRepository;

public interface IProductRepository : IRepository<Product>
{
    public void Update(Product product);
}