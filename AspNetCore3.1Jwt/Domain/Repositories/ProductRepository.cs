using AspNetCore3._1Jwt.Domain.Contexts;
using AspNetCore3._1Jwt.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCore3._1Jwt.Domain.Repositories
{
    public class ProductRepository : BaseRepository,IProductRepository
    {
        public ProductRepository(UdemyApiWithTokenDBContext context):base(context)
        {
            
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Product.AddAsync(product);
        }

        public async Task<Product> FindByIdAsync(int productId)
        {
            return await _context.Product.FindAsync(productId);
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Product.ToListAsync();
        }

        public async Task RemoveProductAsync(int productId)
        {
            var product = await FindByIdAsync(productId);

            _context.Product.Remove(product);
        }

        public void UpdateProduct(Product product)
        {
            _context.Product.Update(product);
        }
    }
}
