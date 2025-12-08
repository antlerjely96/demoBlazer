using DEmoCRUD_2.Models;

namespace DEmoCRUD_2.Services;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategoryAsync();
    Task<Category?> GetCategoryByIdAsync(int Id);
    Task AddCategoryAsync(Category category);
    Task UpdateCategoryAsync(Category category);
    Task DeleteCategoryAsync(int Id);
}