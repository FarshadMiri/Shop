using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.Accounting
{
    public class Coding: BaseEntity
    {
        public Coding()
        {
            PayUsers = new List<Coding>();
            GetUsers = new List<Coding>();


        }
        [InverseProperty("PayUserId")]
        public List<Coding> PayUsers { get; set; }
        [InverseProperty("GayUserId")]

        public List<Coding> GetUsers { get; set; }

    }
}
