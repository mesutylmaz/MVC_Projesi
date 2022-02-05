using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    //DataAnnotation'ları Kullanabilmek İçin Bu Kütüphaneyi Ekledik.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }


        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }


        public ICollection<Heading> Headings { get; set; }      //1 Writer'ın 1'den fazla Heading(Başlığı)'i olabilir. => Çok
                                                                //1 Heading(Başlık)'in 1 Writer'ı olabilir. =>1
                                                                //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.

        public ICollection<Content> Contents { get; set; }      //1 Writer'ın 1'den fazla Content(İçerik)'i olabilir. => Çok
                                                                //1 Content(İçerik)'in 1 Writer'ı olabilir. =>1
                                                                //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.
    }
}
