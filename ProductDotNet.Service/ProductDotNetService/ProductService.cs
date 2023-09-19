using ProductDotNet.Service.Entity;
using System.Collections.Generic;

namespace ProductDotNet.Service.ProductDotNetService
{
    public class ProductService : IProductService
    {
        public bool AddProduct(ProductEntity productInfo)
        {
            return Collection.AddProduct(productInfo);
        }

        public bool DeleteProduct(int productId)
        {
            return Collection.DeleteProduct(productId);
        }

        public List<ProductEntity> GetAll()
        {
            return Collection.GetAll();
        }

        public bool UpdateProduct(int id, ProductEntity product)
        {
            return Collection.UpdateProduct(id, product);
        }
    }
}
