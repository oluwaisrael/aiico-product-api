using System.ComponentModel.DataAnnotations;

namespace AiicoProductApi.DTOs;

public class ProductDto
{
    [Required(ErrorMessage = "Name is required")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")]
    public string Name { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Description cannot exceed 259 characters")]
    public string Description { get; set; } = string.Empty;

    [Range(0.01, 100000000, ErrorMessage = "Price must be greater than 0")]
    public decimal Price { get; set; }
}
