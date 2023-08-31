using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Areas.Dashboard.Models
{
    public class MenuModel
    {
        public MenuModel()
        {
            Provinces = new List<SelectListItem>();

            Provinces.Add(new SelectListItem() { Text = "خراسان", Value = "1" });
            Provinces.Add(new SelectListItem() { Text = "تهران", Value = "2" });
        }
        public int? Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا{0} را وارد کنید")]
        [MaxLength(30, ErrorMessage = "{0} باید{1} کاراکتر باشد")]
        public string Title { get; set; }
        [Display(Name ="لینک")]
        public string Link { get; set; }
        public string ParentTitle { get; set; } 


        public List<SelectListItem> Provinces { get; set; }
        //
        public int ProvinceId { get; set; } 
    }
}