using System;
using MediatR;
using Product.Inventory.Management.Domain.Commands.Responses;

namespace Product.Inventory.Management.Domain.Commands.Requests;

public class CreateProductRequest: IRequest<CreateProductResponse>
{
	public string Name { get; set; } = string.Empty;
	public int BrandId { get; set; }
	public int SupplierId { get; set; }
}

