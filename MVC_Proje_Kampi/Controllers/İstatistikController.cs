using BusinessLayer.Concreate;      //CategoryManager
using DataAccessLayer.EntityFramework;      //EfCategoryDal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Proje_Kampi.Controllers
{
    public class İstatistikController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // GET: İstatistik
        public ActionResult Index()
        {
            var kategoriListesi = categoryManager.CategoryListBusinessLayer();
            ViewBag.KategoriSayisi = kategoriListesi.ToList().Count;
            return View();
        }


        public ActionResult BaslikTablosundaYazilimKategorisiVarMi()
        {
            var kategoriListesi = categoryManager.CategoryListBusinessLayer();
            return View();
        }
    }
}
