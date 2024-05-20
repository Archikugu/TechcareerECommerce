using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TDelete(Brand t)
        {
            _brandDal.Delete(t);
        }

        public Brand TGetByID(int id)
        {
           return _brandDal.GetByID(id);
        }

        public List<Brand> TGetList()
        {
            return _brandDal.GetList();
        }

        public void TInsert(Brand t)
        {
            _brandDal.Insert(t);
        }

        public void TUpdate(Brand t)
        {
            _brandDal.Update(t);
        }
    }
}
