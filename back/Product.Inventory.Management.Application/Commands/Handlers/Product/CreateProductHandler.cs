using MediatR;
using Product.Inventory.Management.Application.Commands.Requests.Product;
using Product.Inventory.Management.Application.Commands.Responses.Product;
using Product.Inventory.Management.Infrastructure.Interfaces;
using ProductEntity = Product.Inventory.Management.Domain.Entities.Product;

namespace Product.Inventory.Management.Application.Commands.Handlers.Product;

public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
{
    private readonly IProductRepository _productRepository;

    public CreateProductHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<CreateProductResponse> Handle(CreateProductRequest command, CancellationToken cancellationToken)
    {
        var product = new ProductEntity()
        {
            Name = command.Name,
            BrandId = command.BrandId,
            SupplierId = command.SupplierId

        };

        await _productRepository.AddAsync(product);

        return new CreateProductResponse();
    }
}

