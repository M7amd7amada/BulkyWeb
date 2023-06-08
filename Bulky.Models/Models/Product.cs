namespace Bulky.Models;  

public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }

    [Required]
    public string ISPN { get; set; } = string.Empty;
    [Required]
    public string Author { get; set; } = string.Empty;

    [Required]
    [Range(1, 1000)]
    [DisplayName("List Price")]
    [Column(TypeName = "decimal(8, 2)")]
    public decimal ListPrice { get; set; }

    [Required]
    [Range(1, 1000)]
    [DisplayName("Price For 1-50")]
    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price { get; set; }

    [Required]
    [Range(1, 1000)]
    [DisplayName("Price For 50+")]
    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price50 { get; set; }

    [Required]
    [Range(1, 1000)]
    [DisplayName("Price For 100+")]
    [Column(TypeName = "decimal(8, 2)")]
    public decimal Price100 { get; set; }

    public int CategoryId { get; set; } 
    [ForeignKey("CategoryId")]
    public Category? Category { get; set; }
}
