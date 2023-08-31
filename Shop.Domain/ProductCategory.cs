using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class ProductCategory : BaseEntity
    {
        public ProductCategory()
        {
            Products = new List<Product>();
        }
        public int? ParentId { get; set; }  
        public virtual ProductCategory Parent { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
