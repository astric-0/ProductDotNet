using ProductDotNet.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDotNet.Service.ProductDotNetService
{
    public static class Collection
    {
        static List<ProductEntity> data = new List<ProductEntity>();

        public static bool AddProduct(ProductEntity model)
        {
            data.Add(model);
            return true;
        }

        public static bool DeleteProduct(int productId)
        {
            int lenBefore = data.Count;
            data = data.Where(d => d.Id != productId).ToList();
            int lenAfter = data.Count;
            return lenBefore != lenAfter;
        }

        public static List<ProductEntity> GetAll()
        {
            return data;
        }

        public static bool UpdateProduct(int id, ProductEntity product)
        {
            int len = data.Count();
            for (int i = 0; i < len; i++)
            {
                if (data[i].Id == id)
                {
                    data[i] = product;
                    break;
                }
            }
            return true;
        }
    }
}
