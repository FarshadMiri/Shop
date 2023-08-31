using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Accounting
{
    public class Transaction : BaseEntity
    {
        public Transaction()
        {

        }
        public int PayUserId { get; set; }
        [ForeignKey("PayUserId")]
        public virtual Coding PayUser { get; set; }

        public int GetUserId { get; set; }
        [ForeignKey("GetUserId")]

        public virtual Coding GetUser { get; set; }

    }
}
