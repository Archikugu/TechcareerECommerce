using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        public List<Order> GetOrderByUser(int id)
        {
            using var context = new Context();
            var result = context.Orders.Include("Product").Where(x => x.UserID == id).ToList();
            return result;
        }
    }
}
