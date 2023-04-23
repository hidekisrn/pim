using System;
using Product.Inventory.Management.Domain.Entities;

namespace Product.Inventory.Management.Infrastructure.Interfaces;

public interface IBrandRepository
{
    public Task AddAsync(Brand product);
}

