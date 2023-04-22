using System;
using MediatR;
using Product.Inventory.Management.Domain.Commands.Requests;
using Product.Inventory.Management.Domain.Commands.Responses;

namespace Product.Inventory.Management.Domain.Commands.Handlers;

public class CreateProductHandler : IRequestHandler<CreateProductRequest, CreateProductResponse>
{
	public CreateProductHandler()
	{
	}

    public async Task<CreateProductResponse> Handle(CreateProductRequest command, CancellationToken cancellationToken)
    {
        return new CreateProductResponse();
    }
}

