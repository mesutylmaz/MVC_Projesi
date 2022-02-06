using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    //DataAnnotation'ları Kullanabilmek İçin Bu Kütüphaneyi Ekledik.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Content   //İçerik class'ı
    {
        [Key]
        public int ContentID { get; set; }


        [StringLength(1000)]
        public string ContentValue { get; set; }    //İçerik metni


        public DateTime ContentDate { get; set; }
        //Content Yazarı
        //Content Ana Başlığı



        public int HeadingID { get; set; }     //Heading class'ından bilgi almak için bu Foreign Key propery'sini kullanacak.
        public virtual Heading Heading { get; set; }      //1 Content(İçerik)'in 1 Heading(Başlık)'i olabilir. => 1
                                                            //1 Heading(Başlık)'in 1'den fazla Content(İçerik)'i olabilir. => Çok
                                                            //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.



        public int? WriterID { get; set; }     //Writer class'ından bilgi almak için bu Foreign Key propery'sini kullanacak.
                                               //2 tane Forign Key olduğundan migration'da sorun olmaması için burayı nullable(?) 
                                               //Yani boş bırakılabilir yaptık.
        public virtual Writer Writer { get; set; }      //1 Content(İçerik)'in 1 Writer'ı olabilir. => 1
                                                        //1 Writer'ın 1'den fazla Content(İçerik)'i olabilir. => Çok
                                                        //Bu sebeple 2 class arasındaki ilişki 1'e çoktur.
    }
}
