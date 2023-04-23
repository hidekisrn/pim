using MediatR;
using Product.Inventory.Management.Application.Commands.Responses.Product;

namespace Product.Inventory.Management.Application.Commands.Requests.Product;

public class CreateProductRequest : IRequest<CreateProductResponse>
{
    public string Name { get; set; } = string.Empty;
    public int BrandId { get; set; }
    public int SupplierId { get; set; }
}

