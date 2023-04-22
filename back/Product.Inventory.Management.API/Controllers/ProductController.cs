using Microsoft.AspNetCore.Mvc;

namespace Product.Inventory.Management.API.Controllers;

[ApiController]
[Route("product")]
public class ProductController : ControllerBase
{
    public ProductController()
    {
    }

    [HttpPost]
    [Route("")]
    public IActionResult Create()
    {
        return Ok();
    }
}

