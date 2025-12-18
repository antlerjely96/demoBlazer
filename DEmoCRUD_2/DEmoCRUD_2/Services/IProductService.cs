using DEmoCRUD_2.Models;

namespace DEmoCRUD_2.Services;

public interface IProductService
{
    Task<List<Product>> GetAllProductAsync();
    Task<Product?> GetProductByIdAsync(int Id);
    Task CreateProductAsync(Product product);
    Task UpdateProductAsync(Product product);
    Task DeleteProductAsync(int Id);
}