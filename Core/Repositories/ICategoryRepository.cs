using Core.Entities;

namespace Core.Repositories;

public interface ICategoryRepository : IRepositories<Category>
{
    Task<Category> GetCategoryWithProductsAsync(Guid categoryId);
}