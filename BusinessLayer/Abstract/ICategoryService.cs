using EntityLayer.Concreate;    //Category
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> CategoryListBusinessLayer();     //Categori Listesi İçin
        void CategoryAddBusinessLayer(Category category);       //Kategori Eklemek İçin
        Category GetByID(int id);   //GenericRepository'deki Get metodu için

        void CategoryDeleteBusinessLayer(Category category);   //Kategori Silmek için
    }
}
