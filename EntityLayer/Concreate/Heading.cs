using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    //DataAnnotation'ları Kullanabilmek İçin Bu Kütüphaneyi Ekledik.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }


        [StringLength(50)]
        public string HeadingName { get; set; }


        public DateTime HeadingDate { get; set; }


        public int CategoryID { get; set; }     //Category class'ından bilgi almak için bu Foreign Key propery'sini kullanacak.
        public virtual Category Category { get; set; }      //1 Heading(Başlık)'in 1 Category'si olabilir. => 1
                                                            //1 Category'nin 1'den fazla Heading(Başlığı)'i olabilir. => Çok
                                                            //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.



        public int WriterID { get; set; }     //Writer class'ından bilgi almak için bu Foreign Key propery'sini kullanacak.
        public virtual Writer Writer { get; set; }      //1 Heading(Başlık)'in 1 Writer'ı olabilir. => 1
                                                        //1 Writer'ın 1'den fazla Heading(Başlığı)'i olabilir. => Çok
                                                        //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.



        public ICollection<Content> Contents { get; set; }      //1 Heading(Başlık)'in 1 Content(İçerik)'i olabilir. => 1
                                                                //1 Content(İçerik)'in 1'den fazla Heading(Başlığı)'i olabilir. => Çok
                                                                //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.
    }
}
