using ProductDotNet.Service.Entity;
using System.Collections.Generic;

namespace ProductDotNet.Service.ProductDotNetService
{
    public interface IProductService
    {
        bool AddProduct(ProductEntity entity);
        bool DeleteProduct(int productId);
        List<ProductEntity> GetAll();
        bool UpdateProduct(int id, ProductEntity entity);
    }
}
