using BusinessLayer.Concreate;      //WriterManager
using BusinessLayer.Validation_Rules_or_Fluent_Validation;      //WriterValidator
using DataAccessLayer.EntityFramework;      //EfWriterDal
using EntityLayer.Concreate;    //Writer
using FluentValidation.Results;     //ValidationResult
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampi.Controllers
{
    public class AdminWriterController : Controller
    {

        WriterManager writerManager = new WriterManager(new EfWriterDal());


        public ActionResult Index()
        {
            var yazarListesi = writerManager.WriterListBusinessLayer();
            return View(yazarListesi);
        }


        [HttpGet]
        public ActionResult YazarEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult YazarEkle(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult result = writerValidator.Validate(writer);

            if (result.IsValid)
            {
                writerManager.WriterAddBusinessLayer(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }



        //public ActionResult YazarSil(int id)
        //{
        //    var yazar = writerManager.GetByID(id);
        //    writerManager.WriterDeleteBusinessLayer(yazar);
        //    return RedirectToAction("Index");
        //}


        //[HttpGet]
        //public ActionResult YazarGüncelle(int id)
        //{
        //    var yazar = writerManager.GetByID(id);
        //    return View(yazar);
        //}



        //[HttpPost]
        //public ActionResult YazarGüncelle(Writer writer)
        //{
        //    writerManager.WriterUpdateBusinessLayer(writer);
        //    return RedirectToAction("Index");
        //}
    }
}
