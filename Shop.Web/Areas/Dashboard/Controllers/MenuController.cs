using Shop.Domain;
using Shop.Service;
using Shop.Web.Areas.Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Areas.Dashboard.Controllers
{
    public class MenuController : Controller
    {

        //private IMenuService _menuService { get; }
        //public MenuController(IMenuService menuService)
        //{
        //    _menuService = menuService;

        //}
        //GET: Dashboard/Menu
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]

        public ActionResult Create()
        {
            MenuModel model = new MenuModel();  
            return View(model);
        }
       
        [HttpPost]
        public ActionResult Create(MenuModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");

                }


            }
            catch (Exception ex)
            {

                
            }
            
            return View(model);
        }



        //public ActionResult List()
        //{
        //    List<Menu> entities = _menuService.List();
        //    List<MenuModel> models = new List<MenuModel>();

        //    foreach (Menu entity in entities)
        //    {
        //        MenuModel model = new MenuModel();

        //        model.Id = entity.Id;
        //        model.Title = entity.Title;
        //        model.Link = entity.Link;
        //        model.ParentTitle = entity.Parent.Title;

        //        models.Add(model);  

        //    }
        //    return View(models);
        //}
        //[HttpGet]
        //public ActionResult Create()
        //{
        //    MenuModel model = new MenuModel();
        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult Create(MenuModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            Menu entity = new Menu();
        //            entity.Title = model.Title;
        //            entity.Link = model.Link;
        //            //عملیات ثبت درمنو سرویس

        //            _menuService.Create(entity);



        //            return RedirectToAction("Index");


        //        }
        //        catch (Exception ex)
        //        {
        //            return RedirectToAction("Error");


        //        }

        //    }
        //    return View(model);

        //}
        //public ActionResult Update(int id = 0)
        //{
        //    Menu entity = _menuService.Find(id);
        //    MenuModel model = new MenuModel();
        //    model.Title = entity.Title;
        //    model.Link = entity.Link;
        //    model.Id = entity.Id;

        //    return View(model);
        //}

        //        [HttpPost]
        //        public ActionResult Update(MenuModel model)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    Menu entity = _menuService.Find(model.Id.GetValueOrDefault());

        //                    entity.Title = model.Title;
        //                    entity.Link = model.Link;
        //                    entity.Id = model.Id.GetValueOrDefault();

        //                    _menuService.Update(entity);
        //                    return RedirectToAction("Index");

        //                }
        //                catch (Exception ex)
        //                {
        //                    return RedirectToAction("Error");
        //                }

        //            }
        //            return View(model);
        //        }

        //        public ActionResult Delete(int id)
        //        {
        //            Menu entity= _menuService.Find(id);
        //            _menuService.Delete(entity);

        //            return RedirectToAction("Index");
        //        }


    }
}