using BusinessLayer.Concreate;      //CategoryManager için
using BusinessLayer.Validation_Rules_or_Fluent_Validation;      //CategoryValidator
using DataAccessLayer.EntityFramework;      //EfCategoryDal
using EntityLayer.Concreate;    //Category için
using FluentValidation.Results;     //ValidationResult
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampi.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult KategorileriListele()
        {
            var categoryValues = categoryManager.CategoryListBusinessLayer();
            return View(categoryValues);
        }




        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }




        [HttpPost]
        public ActionResult KategoriEkle(Category category)
        {
            //categoryManager.CategoryAddBusinessLayer(category);



            CategoryValidator categoryValidator = new CategoryValidator();      
            //Category nesnesine ait Validasyonları,
            //categoryValidator nesnesine atadık.

            ValidationResult results = categoryValidator.Validate(category);    
            //Gönderilen parametrenin(category) validasyonunu kontrol edip(Validate(category)),
            //results nesnesine atadık.


            if(results.IsValid)     //results nesnesi olumluysa, yani validasyon şartlarını sağlıyorsa;
            {
                categoryManager.CategoryAddBusinessLayer(category); //category nesnesini Categorlere ekle,
                return RedirectToAction("KategorileriListele");     //KategorileriListele Action'ını çalıştır.
            }
            else
            {
                foreach (var item in results.Errors) //category parametresinin validasyon sonucundaki Hataları dolaş
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);     
                    //Hatalı Property Adını ve Hata Mesajını Modelimin Hatalarına Ekle
                }
            }

            return View();
        }
    }
}
