using System;
using Product.Inventory.Management.Domain.Entities;
using Product.Inventory.Management.Infrastructure.Interfaces;

namespace Product.Inventory.Management.Infrastructure.PostgreSQL.Repositories;

public class BrandRepository : IBrandRepository
{
    private readonly DbContext _context;

    public BrandRepository(DbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Brand brand)
    {
        await _context.Brands.AddAsync(brand);
        await _context.SaveChangesAsync();
    }
}

