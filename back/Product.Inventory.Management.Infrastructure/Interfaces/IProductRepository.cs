using System;
using System.Linq.Expressions;
using ProductEntity = Product.Inventory.Management.Domain.Entities.Product;

namespace Product.Inventory.Management.Infrastructure.Interfaces;

public interface IProductRepository
{
    public Task Create(ProductEntity product);
    public Task<ProductEntity?> GetByFilterAsync(Expression<Func<ProductEntity, bool>> filter);
}

