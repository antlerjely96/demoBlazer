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

    public async Task<Category?> GetCategoryByIdAsync(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public async Task CreateCategoryAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCategoryAsync(int id)
    {
        var cate = await _context.Categories.FindAsync(id);
        if (cate != null)
        {
            _context.Categories.Remove(cate);
            await _context.SaveChangesAsync();
        }
    }
}