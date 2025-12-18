using System.ComponentModel.DataAnnotations;

namespace DEmoCRUD_2.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required (ErrorMessage ="Please fill category name")]
    public string Name { get; set; } = "";

    public ICollection<Product> Products { get; set; } = new List<Product>();
}