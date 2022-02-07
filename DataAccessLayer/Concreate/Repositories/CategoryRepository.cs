using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccessLayer.Abstract;     //ICategoryDal için
using EntityLayer.Concreate;
using System.Data.Entity;       //DbSet için
using System.Linq;


namespace DataAccessLayer.Concreate.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context context = new Context();
        DbSet<Category> categories;

        public void Delete(Category category)
        {
            categories.Remove(category);
            context.SaveChanges();
        }
        public void Insert(Category category)
        {
            categories.Add(category);
            context.SaveChanges();
        }
        public List<Category> ListCategories()
        {
            return categories.ToList();
        }
        public void Update(Category category)
        {
            context.SaveChanges();
        }
    }
}
