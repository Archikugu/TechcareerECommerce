using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
    }
}
