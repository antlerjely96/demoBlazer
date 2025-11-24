using DemoCRUD.Models;

namespace DemoCRUD.Data;
using Microsoft.EntityFrameworkCore;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }
}