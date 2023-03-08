using AspNetCore3._1Jwt.Domain.Models;
using System.Collections;
using System.Collections.Generic;

namespace AspNetCore3._1Jwt.Domain.Response
{
    public class ProductListResponse:BaseResponse
    {
        public IEnumerable<Product> ProductList { get; set; }
        public ProductListResponse(bool success, string message,IEnumerable<Product> products) : base(success, message)
        {
            ProductList = products;
        }

        //başarılı
        public ProductListResponse(IEnumerable<Product> products):this(true,string.Empty,products)
        {
            
        }
        //başarısız
        public ProductListResponse(string message):this(false,message,null) { }
    }
}
