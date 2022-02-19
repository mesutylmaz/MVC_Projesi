using EntityLayer.Concreate;    //Writer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> WriterListBusinessLayer();     //Writer Listesi İçin
        void WriterAddBusinessLayer(Writer writer);       //Writer Eklemek İçin
        Writer GetByID(int id);   //GenericRepository'deki Get metodu için
        void WriterDeleteBusinessLayer(Writer writer);   //Writer Silmek için
        void WriterUpdateBusinessLayer(Writer writer);    //Writer Güncellemek için
    }
}
