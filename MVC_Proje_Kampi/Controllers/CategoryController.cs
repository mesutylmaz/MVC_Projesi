using BusinessLayer.Concreate;      //CategoryManager için
using EntityLayer.Concreate;    //Category için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampi.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = categoryManager.GetAllBusinessLayer();
            return View(categoryValues);
        }

        public ActionResult AddCategory(Category category)
        {
            categoryManager.CategoryAddBusinessLayer(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}
