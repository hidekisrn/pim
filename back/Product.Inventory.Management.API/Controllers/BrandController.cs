using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Inventory.Management.API.Models;
using Product.Inventory.Management.API.Models.Brand;
using Product.Inventory.Management.Application.Commands.Requests.Product;

namespace Product.Inventory.Management.API.Controllers;

[ApiController]
[Route("product")]
public class BrandController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public BrandController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    [Route("")]
    public async Task<IActionResult> Create([FromBody] CreateBrandModel model)
    {
        var request = _mapper.Map<CreateBrandModel, CreateProductRequest>(model);

        var result = await _mediator.Send(request);
        return Ok(result);
    }
}

