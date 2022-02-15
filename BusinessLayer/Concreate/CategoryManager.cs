using BusinessLayer.Abstract;   //ICategoryService 
using DataAccessLayer.Abstract;     //ICategoryDal
using EntityLayer.Concreate;    //Category
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal iCategoryDal)   //ctor
        {
            _categoryDal = iCategoryDal;
        }

        public void CategoryAddBusinessLayer(Category category) //ICategoryService içindeki metot, implement edilerek geldi.
        {
            _categoryDal.Insert(category);
        }

        public List<Category> CategoryListBusinessLayer()     //ICategoryService içindeki metot, implement edilerek geldi.
        {
            return _categoryDal.Listele();
        }
    }
}
