namespace BulkyWeb.Models; 

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    [Required]
    [MaxLength(100)]
    [DisplayName("Category Name")]
    public string Name { get; set; } = string.Empty;

    [Range(1, 100)]
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; } 
}