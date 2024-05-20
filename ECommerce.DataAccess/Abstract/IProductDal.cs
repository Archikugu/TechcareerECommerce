using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        public List<Product> GetProductByCategory(int id);
    }
}
