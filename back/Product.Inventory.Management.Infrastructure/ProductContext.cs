

using Microsoft.EntityFrameworkCore;
using Product.Inventory.Management.Domain.Entities;
using ProductEntity = Product.Inventory.Management.Domain.Entities.Product;

namespace Product.Inventory.Management.Infrastructure;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        base.OnModelCreating(modelbuilder);

    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
}
