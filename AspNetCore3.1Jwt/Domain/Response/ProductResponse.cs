using AspNetCore3._1Jwt.Domain.Models;

namespace AspNetCore3._1Jwt.Domain.Response
{
    public class ProductResponse:BaseResponse
    {
        public Product Product { get; set; }
        public ProductResponse(bool success,string message,Product product):base(success,message)
        {
            this.Product = product;
        }
        //başarılı
        public ProductResponse(Product product):this(true,string.Empty,product) { }
        //başarısız
        public ProductResponse(string message):this(false,message,null)
        {
            
        }

    }
}
