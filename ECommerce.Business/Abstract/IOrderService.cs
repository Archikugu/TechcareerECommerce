using ECommerce.Core.Business.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.Business.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        public List<Order> TGetOrderByUser(int id);
    }
}
