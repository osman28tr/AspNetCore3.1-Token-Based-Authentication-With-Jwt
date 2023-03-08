using AspNetCore3._1Jwt.Domain.Models;
using AspNetCore3._1Jwt.Domain.Response;
using System.Threading.Tasks;

namespace AspNetCore3._1Jwt.Domain.Service
{
    public interface IProductService
    {
        Task<ProductListResponse> ListAsync();
        Task<ProductResponse> AddProduct();
        Task<ProductResponse> UpdateProduct(int productId, Product product);
        Task<ProductResponse> DeleteProduct(int productId);
        Task<Product> FindByIdAsync(int productId);
    }
}
