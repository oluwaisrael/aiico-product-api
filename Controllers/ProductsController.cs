using Microsoft.AspNetCore.Mvc;
using AiicoProductApi.Models;
using AiicoProductApi.DTOs;

namespace AiicoProductApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    private static List<Product> _products = new();

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_products);
    }

    [HttpPost]
    public IActionResult Create(ProductDto dto)
    {
        var product = new Product
        {
            Id = _products.Count + 1,
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price
        };

        _products.Add(product);
        return CreatedAtAction(nameof(GetAll), new { id = product.Id }, product);
    }
}