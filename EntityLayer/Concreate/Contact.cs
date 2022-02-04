using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Contact        //İletişim class'ı
    {
        public int ContactID { get; set; }
        public string UserName { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }     //İletişim Konusu
        public string Message { get; set; }     //İletişim Metni
    }
}
