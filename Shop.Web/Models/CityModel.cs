using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Web.Models
{
    public class CityModel
    {
        public CityModel()
        {

        }
        public int Id { get; set; } 
        public string Title { get; set; } 
        public int ProvinceId { get; set; } 
    }
}