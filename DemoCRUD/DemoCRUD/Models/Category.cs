using System.ComponentModel.DataAnnotations;

namespace DemoCRUD.Models;

public class Category
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Tên danh mục bắt buộc nhập")]
    [StringLength(100, ErrorMessage = "Tên danh mục tối đa 100 ký tự")]
    public string Name { get; set; } = string.Empty;
}