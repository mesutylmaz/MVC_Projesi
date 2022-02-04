using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Writer
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }




        public ICollection<Heading> Headings { get; set; }      //1 Writer'ın 1'den fazla Heading(Başlığı)'i olabilir. => Çok
                                                                //1 Heading(Başlık)'in 1 Writer'ı olabilir. =>1
                                                                //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.

        public ICollection<Content> Contents { get; set; }      //1 Writer'ın 1'den fazla Content(İçerik)'i olabilir. => Çok
                                                                //1 Content(İçerik)'in 1 Writer'ı olabilir. =>1
                                                                //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.
    }
}
