using Core.Entities;

namespace Core.Repositories;

public interface IProductRepository : IRepositories<Product>
{
    IQueryable<Product> GetProductsByCategory(Guid categoryId);
    IQueryable<Product> GetProductsInStock();
}