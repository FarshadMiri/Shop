using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<ProvinceModel> modelList=new List<ProvinceModel>();    
            modelList.Add(new ProvinceModel()
            {
                Id = 1,
                Title = "خراسان شمالی"
            });
            modelList.Add(new ProvinceModel()
            {
                Id = 2,
                Title = "خراسان رضوی"
            }); modelList.Add(new ProvinceModel()
            {
                Id = 3,
                Title = "خراسان جنوبی"
            });
            return View(modelList);
        }
        [HttpGet]
        public ActionResult City(int ProvinceId)
        {
            List<CityModel> modelList=new List<CityModel>();
            modelList.Add(new CityModel()
            {
                Id = 1,
                Title = "قوچان",
                ProvinceId = 2,

            });
            modelList.Add(new CityModel()
            {
                Id = 2,
                Title = "مشهد",
                ProvinceId = 2,

            });
            modelList.Add(new CityModel()
            {
                Id = 3,
                Title = "نیشابور",
                ProvinceId = 2,

            });
            modelList.Add(new CityModel()
            {
                Id = 4,
                Title = "بجنورد",
                ProvinceId = 1,

            });
            modelList.Add(new CityModel()
            {
                Id = 5,
                Title = "شیروان",
                ProvinceId = 1,

            });
            modelList.Add(new CityModel()
            {
                Id = 6,
                Title = "بیرجند",
                ProvinceId = 3,

            });
            modelList.Add(new CityModel()
            {
                Id = 7,
                Title = "قائن",
                ProvinceId = 3,

            });
            modelList.Add(new CityModel()
            {
                Id = 8,
                Title = "سبزوار",
                ProvinceId = 2,

            });

            if (ProvinceId == 0)
            {
                modelList=new List<CityModel>();    
            }
            else
            {
                modelList=modelList.Where(x=> x.ProvinceId==ProvinceId).ToList();

            }

            return PartialView("_City",modelList);
        }

    }
}