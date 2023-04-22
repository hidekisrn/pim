using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Inventory.Management.API.Models;
using Product.Inventory.Management.Domain.Commands.Requests;

namespace Product.Inventory.Management.API.Controllers;

[ApiController]
[Route("product")]
public class ProductController : ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ProductController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpPost]
    [Route("")]
    public async Task<IActionResult> Create([FromBody] CreateProductModel model)
    {
        var request = _mapper.Map<CreateProductModel, CreateProductRequest>(model);

        var result = await _mediator.Send(request);
        return Ok(result);
    }
}

