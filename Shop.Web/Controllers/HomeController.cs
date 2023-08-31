using Shop.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Test(int numOne,int numTwo,int act)
        {
            CalculatorModel model = new CalculatorModel();  
            switch (act)
            {
                case 1:
                    model.Result = numOne + numTwo;
                    break;
                   
                case 2:
                    model.Result = numTwo - numOne;
                    break;
                case 3:
                    model.Result = numOne * numTwo;
                    break;
                case 4:
                    model.Result = numTwo / numOne;
                    break ;
                case 5:
                    model.Result = numOne % numTwo; 
                    break ;
               
                default:
                    break;

            }
            return View(model);
        }

    }
}