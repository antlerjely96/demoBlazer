using DEmoCRUD_2.Data;
using DEmoCRUD_2.Models;
using Microsoft.EntityFrameworkCore;

namespace DEmoCRUD_2.Services;

public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;

    public CategoryService(AppDbContext context)
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

    public async Task AddCategoryAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        _context.Categories.Update(category);
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