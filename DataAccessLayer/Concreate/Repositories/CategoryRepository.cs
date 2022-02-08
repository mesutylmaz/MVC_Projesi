using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccessLayer.Abstract;     //ICategoryDal için
using EntityLayer.Concreate;
using System.Data.Entity;       //DbSet için
using System.Linq;
using System.Linq.Expressions;

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

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListCategories()
        {
            return categories.ToList();
        }

        public List<Category> Listele()
        {
            throw new NotImplementedException();
        }

        public void Update(Category category)
        {
            context.SaveChanges();
        }
    }
}
