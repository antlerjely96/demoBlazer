using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEmoCRUD_2.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Please fill product name")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please fill Price")]
    public double Price { get; set; }

    [Required(ErrorMessage = "Please fill quantity")]
    public int Quantity { get; set; }

    [Required(ErrorMessage = "Please choose Category")]
    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public Category? category { get; set; }
}