using DataAccessLayer.Abstract;     //ICategoryDal
using DataAccessLayer.Concreate.Repositories;   //GenericRepository
using EntityLayer.Concreate;    //Category
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {

    }
}
