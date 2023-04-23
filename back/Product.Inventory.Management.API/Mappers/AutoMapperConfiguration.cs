using System;
using AutoMapper;
using Product.Inventory.Management.API.Mappers.Profiles;

namespace Product.Inventory.Management.API.Mappers;

public static class AutoMapperConfiguration
{
    public static IServiceCollection ConfigureMappings(this IServiceCollection services)
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile<ProductProfile>();
            mc.AddProfile<BrandProfile>();
        });

        services.AddSingleton(mappingConfig.CreateMapper());

        return services;
    }
}

