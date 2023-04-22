using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Product.Inventory.Management.Infrastructure.Interfaces;
using ProductEntity = Product.Inventory.Management.Domain.Entities.Product;

namespace Product.Inventory.Management.Infrastructure.PostgreSQL.Repositories
{
	public class ProductRepository : IProductRepository
	{

		private readonly ProductContext _context;

		public ProductRepository(ProductContext context)
		{
			_context = context;
		}

		public async Task Create(ProductEntity product)
		{
			await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<ProductEntity?> GetByFilterAsync(Expression<Func<ProductEntity, bool>> filter)
        {
			return await _context.Products.FirstOrDefaultAsync(filter);
        }
    }
}

