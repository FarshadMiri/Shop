using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class ProductComment : BaseEntity
    {
        public ProductComment()
        {

        }
        public int ProductId { get; set; }  
        public virtual Product Product { get; set; }
    }
}
