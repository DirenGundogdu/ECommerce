using Core.Entities;

namespace Core.Services;

public interface ICategoryService
{
    Task<Category> GetCategoryWithProductsAsync(Guid categoryId);
}