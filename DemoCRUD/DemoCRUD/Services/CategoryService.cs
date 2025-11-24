using DemoCRUD.Data;
using DemoCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD.Services;

public class CategoryService : ICategoryService
{
    private readonly AppDBContext _context;

    public CategoryService(AppDBContext context)
    {
        _context = context;
    }
    
    public async Task<List<Category>> GetAllCategoryAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> GetCategoryByIdAsync(int Id)
    {
        return await _context.Categories.FindAsync(Id);
    }

    public async Task<Category> CreateCategoryAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
        return category;
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        _context.Entry(category).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCategoryAsync(int Id)
    {
        var category = await _context.Categories.FindAsync(Id);
        if (category != null)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}