using BusinessLayer.Concreate;      //CategoryManager
using BusinessLayer.Validation_Rules_or_Fluent_Validation;      //CategoryValidator
using DataAccessLayer.EntityFramework;      //EfCategoryDal
using EntityLayer.Concreate;    //Category
using FluentValidation.Results;     //ValidationResult
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampi.Controllers
{
    public class AdminCategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


        public ActionResult Index()
        {
            var kategoriListesi = categoryManager.CategoryListBusinessLayer();
            return View(kategoriListesi);
        }


        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult KategoriEkle(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult result = categoryValidator.Validate(category);

            if(result.IsValid)
            {
                categoryManager.CategoryAddBusinessLayer(category);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
            }
            return View();
        }



        public ActionResult KategoriSil(int id)
        {
            var kategori = categoryManager.GetByID(id);
            categoryManager.CategoryDeleteBusinessLayer(kategori);
            return RedirectToAction("Index");
        }
    }
}
