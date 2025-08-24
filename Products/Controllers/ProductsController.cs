using Microsoft.AspNetCore.Mvc;
using ProductsMicrosservice.Products.Services;

namespace ProductsMicrosservice.Products.Controllers;

[Route("api/[controller]/[Action]")]
[ApiController]
public class ProductsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetProducts()
    {
        return Ok(GetProductsService.CreateProducts());
    }
}

