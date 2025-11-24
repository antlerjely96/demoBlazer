using DemoCRUD.Models;

namespace DemoCRUD.Services;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategoryAsync();
    Task<Category?> GetCategoryByIdAsync(int Id);
    Task<Category> CreateCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(int Id);
}