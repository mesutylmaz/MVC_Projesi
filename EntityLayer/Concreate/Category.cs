using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Category   //Başlıkları kategorize eden classs
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }      //Aktif/Pasif için bu özellik kullanılacak.


        public ICollection<Heading> Headings { get; set; }      //1 Category'nin 1'den fazla Heading(Başlığı)'i olabilir. => Çok
                                                                //1 Heading(Başlık)'in 1 Category'si olabilir. =>1
                                                                //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.
    }
}
