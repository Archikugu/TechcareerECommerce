using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        public List<Order> GetOrderByUser(int id);
    }
}
