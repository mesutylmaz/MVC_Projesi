using BusinessLayer.Abstract;   //IWriterService 
using DataAccessLayer.Abstract;     //IWriterDal
using EntityLayer.Concreate;    //Writer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal iWriterDal)   //ctor
        {
            _writerDal = iWriterDal;
        }

        public void WriterAddBusinessLayer(Writer writer) //IWriterService içindeki metot, implement edilerek geldi.
        {
            _writerDal.Insert(writer);
        }


        public List<Writer> WriterListBusinessLayer()     //IWriterService içindeki metot, implement edilerek geldi.
        {
            return _writerDal.Listele();
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.WriterID == id);
        }


        public void WriterDeleteBusinessLayer(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdateBusinessLayer(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
