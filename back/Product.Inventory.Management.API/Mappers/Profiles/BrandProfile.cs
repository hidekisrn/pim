using System;
using AutoMapper;
using Product.Inventory.Management.API.Models.Brand;
using Product.Inventory.Management.API.Models.Product;
using Product.Inventory.Management.Application.Commands.Requests.Product;

namespace Product.Inventory.Management.API.Mappers.Profiles;

public class BrandProfile : Profile
{
	public BrandProfile()
	{
        CreateMap<CreateBrandModel, CreateProductRequest>();
    }
}

