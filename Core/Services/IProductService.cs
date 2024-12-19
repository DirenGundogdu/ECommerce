using Core.Entities;

namespace Core.Services;

public interface IProductService
{
    IQueryable<Product> GetProductsByCategory(Guid categoryId);
    IQueryable<Product> GetProductsInStock();
}