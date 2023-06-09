﻿using System;
using AutoMapper;
using Product.Inventory.Management.API.Models;
using Product.Inventory.Management.API.Models.Product;
using Product.Inventory.Management.Application.Commands.Requests.Product;

namespace Product.Inventory.Management.API.Mappers.Profiles;

public class ProductProfile : Profile
{
	public ProductProfile()
	{
        CreateMap<CreateProductModel, CreateProductRequest>();
    }
}

