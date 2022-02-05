using EntityLayer.Concreate;    //About-Category-Writer-Heading-Content-Contact 
using System;
using System.Collections.Generic;
using System.Data.Entity;       //DbContext
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concreate
{
    public class Context: DbContext
    {
        public DbSet<Writer>Writers { get; set; }   //Writers Veritabanındaki Tablo Adımızdır.
        public DbSet<About> Abouts { get; set; }    //Abouts Veritabanındaki Tablo Adımızdır.
        public DbSet<Contact> Contacts { get; set; }    //Contacts Veritabanındaki Tablo Adımızdır.
        public DbSet<Content> Contents { get; set; }    //Contents Veritabanındaki Tablo Adımızdır.
        public DbSet<Category> Categories { get; set; }  //Categories Veritabanındaki Tablo Adımızdır.
        public DbSet<Heading> Headings { get; set; }    //Headings Veritabanındaki Tablo Adımızdır.
    }
}
