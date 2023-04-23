using System;
using MediatR;
using Product.Inventory.Management.Application.Commands.Requests.Brand;
using Product.Inventory.Management.Application.Commands.Responses.Brand;
using Product.Inventory.Management.Infrastructure.Interfaces;
using BrandEntity = Product.Inventory.Management.Domain.Entities.Brand;

namespace Product.Inventory.Management.Application.Commands.Handlers.Brand
{
	public class CreateBrandHandler: IRequestHandler<CreateBrandRequest, CreateBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;

		public CreateBrandHandler(IBrandRepository brandRepository)
		{
            _brandRepository = brandRepository;
		}

        public async Task<CreateBrandResponse> Handle(CreateBrandRequest command, CancellationToken cancellationToken)
        {
            var product = new BrandEntity()
            {
                Name = command.Name
            };

            await _brandRepository.AddAsync(product);

            return new CreateBrandResponse();
        }
    }
}

