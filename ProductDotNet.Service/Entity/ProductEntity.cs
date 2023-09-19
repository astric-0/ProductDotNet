using System.Collections.Generic;
using System.Linq;

namespace ProductDotNet.Service.Entity
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Size { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
    }
}
