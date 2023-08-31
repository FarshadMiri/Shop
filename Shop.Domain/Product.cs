using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class Product : BaseEntity
    {
        public Product()
        {
            ProductComments = new List<ProductComment>();
        }


        public int ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; } 
        public virtual List<ProductComment> ProductComments { get; set; }


    }
}
