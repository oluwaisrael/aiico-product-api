using Microsoft.AspNetCore.Mvc;

namespace AiicoProductApi.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok("Israel's endpoint is working");
    }
}