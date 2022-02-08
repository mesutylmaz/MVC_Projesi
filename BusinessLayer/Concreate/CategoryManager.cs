using DataAccessLayer.Concreate.Repositories;   //GenericRepository
using EntityLayer.Concreate;    //Category
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category>GetAllBusinessLayer()
        {
            return repo.Listele();
        }

        public void CategoryAddBusinessLayer(Category category)
        {
            if(category.CategoryName==null || category.CategoryName.Length<=3 ||category.CategoryDescription==""||category.CategoryName.Length>=51)
            {
                //Hata Mesajı
            }
            else
            {
                repo.Insert(category);
            }
        }
    }
}
