using System.ComponentModel.DataAnnotations;

namespace DEmoCRUD_2.Models;

public class Category
{
    public int Id { get; set; }
    [Required (ErrorMessage ="Please fill category name")]
    public string Name { get; set; } = "";
}