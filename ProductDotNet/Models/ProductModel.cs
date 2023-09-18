using System.Collections.Generic;

namespace ProductDotNet.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Size { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
    }
}