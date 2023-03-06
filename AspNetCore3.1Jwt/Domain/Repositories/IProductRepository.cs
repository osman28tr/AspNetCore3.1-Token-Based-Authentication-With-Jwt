using AspNetCore3._1Jwt.Domain.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AspNetCore3._1Jwt.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
        Task AddProductAsync(Product product);
        Task RemoveProductAsync(int productId);
        void UpdateProduct(Product product);
        Task<Product> FindByIdAsync(int productId);
    }
}
