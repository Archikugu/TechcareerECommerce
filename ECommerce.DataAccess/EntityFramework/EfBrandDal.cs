using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfBrandDal : GenericRepository<Brand>, IBrandDal
    {
    }
}
