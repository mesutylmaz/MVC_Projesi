using EntityLayer.Concreate;    //Category için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {

        //CRUD işlemlerini burada metot olarak tanımlayacağız.

        List<Category> ListCategories();        //Tüm category listesini göster

        void Insert(Category category);     //Girilen veriyi(category) category tabloma ekle
        void Update(Category category);     //Girilen veriyi(category) category tablomda güncelle
        void Delete(Category category);     //Girilen veriyi(category) category tablomdan sil
    }
}
