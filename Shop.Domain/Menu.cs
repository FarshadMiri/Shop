using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain
{
    public class Menu : BaseEntity
    {
        public Menu()
        {

        }
        public string Title { get; set; }
        public string Link { get; set; }    
        public int? ParentId { get; set; }  
        public virtual Menu Parent { get; set; }
    }
}
