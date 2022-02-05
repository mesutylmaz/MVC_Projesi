using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;    //DataAnnotation'ları Kullanabilmek İçin Bu Kütüphaneyi Ekledik.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Contact        //İletişim class'ı
    {
        [Key]
        public int ContactID { get; set; }


        [StringLength(50)]
        public string UserName { get; set; }


        [StringLength(50)]
        public string UserMail { get; set; }


        [StringLength(50)]
        public string Subject { get; set; }     //İletişim Konusu


        //[StringLength(1000)]
        public string Message { get; set; }     //İletişim Metni
    }
}
