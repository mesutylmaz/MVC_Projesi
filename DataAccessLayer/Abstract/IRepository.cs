using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>     //Her Tablo tipi için ortak bir Interface tanımladık. 
    {

        //CRUD işlemlerini burada metot olarak tanımlayacağız.

        //T burada Category, Writer vb. Entity Class'larını temsil ediyor.
        //Yani CRUD işlemi yapılması istenen Class(Tablo) ne ise ona göre CRUD işlemlerinde,
        //aşağıdaki ortak 4 metodu kullanabileceğiz.
        //Böylece aynı metotları tekrar tekrar yazmak yada
        //Interface olarak yazıp impleent etmek zorunda kalmayacağız.

        List<T> ListCategories();        //Tüm category listesini göster

        void Insert(T t);     //Girilen veriyi(t) T tipindeki tabloma ekle
        void Update(T t);     //Girilen veriyi(t) T tipindeki tablomda güncelle
        void Delete(T t);     //Girilen veriyi(t) T tipindeki tablomdan sil

        
    }
}
