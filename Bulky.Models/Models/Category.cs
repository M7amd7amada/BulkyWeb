using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Bulky.Models; 

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(100)]
    [DisplayName("Category Name")]
    public string Name { get; set; } = string.Empty;

    [Range(1, 100, ErrorMessage = "The order should be between 1 - 100")]
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; } 
}