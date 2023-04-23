

using Microsoft.EntityFrameworkCore;
using Product.Inventory.Management.Domain.Entities;
using ProductEntity = Product.Inventory.Management.Domain.Entities.Product;

namespace Product.Inventory.Management.Infrastructure;

public class DbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public DbContext(DbContextOptions<DbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelbuilder)
    {
        base.OnModelCreating(modelbuilder);

        modelbuilder.Entity<ProductEntity>(p =>
        {
            p.Property(d => d.Name).IsRequired();
            p.HasOne(d => d.Brand).WithMany(b => b.Products).HasForeignKey(d => d.BrandId);
            p.HasOne(d => d.Supplier).WithMany(s => s.Products).HasForeignKey(d => d.SupplierId);
            p.Property(d => d.Properties);
        });

        modelbuilder.Entity<Supplier>(s =>
        {
            s.Property(d => d.Name).IsRequired();
        });


        modelbuilder.Entity<Brand>(s =>
        {
            s.Property(d => d.Name).IsRequired();
        });
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<Brand> Brands { get; set; }
}
