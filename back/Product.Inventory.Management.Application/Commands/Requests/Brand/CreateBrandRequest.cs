using System;
using MediatR;
using Product.Inventory.Management.Application.Commands.Responses.Brand;

namespace Product.Inventory.Management.Application.Commands.Requests.Brand;

public class CreateBrandRequest : IRequest<CreateBrandResponse>
{
	public string Name { get; set; } = string.Empty;
}

