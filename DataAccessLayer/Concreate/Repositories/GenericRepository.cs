using DataAccessLayer.Abstract; //IRepository
using System;
using System.Collections.Generic;
using System.Data.Entity;   //DbSet
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context context = new Context();
        DbSet<T> _object;    



        public GenericRepository()
        {
            _object = context.Set<T>();
        }



        public void Delete(T t)
        {
            var silinecekDeger = context.Entry(t);
            silinecekDeger.State = EntityState.Deleted;
            //_object.Remove(t);     //Buranın yerine üstteki 2 satır yazıldı.
            context.SaveChanges();
        }


        public void Insert(T t)
        {
            var eklenecekDeger = context.Entry(t);
            eklenecekDeger.State = EntityState.Added;
            //_object.Add(t);       //Buranın yerine üstteki 2 satır yazıldı.
            context.SaveChanges();
        }


        public void Update(T t)
        {
            var guncellenecekDeger = context.Entry(t);
            guncellenecekDeger.State = EntityState.Modified;
            context.SaveChanges();
        }
        


        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }


        public List<T> Listele()
        {
            return _object.ToList();
        }


        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);     //Sadece 1 adet değer döndürecek. Yani;
            //Index yada List metotları, tablonun tamamını getirirken; Get metodu sadece ilgili ID'ye sahip değeri getirecek.
        }
    }
}
