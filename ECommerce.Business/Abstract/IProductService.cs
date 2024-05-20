using ECommerce.Core.Business.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        public List<Product> TGetProductByCategory(int id);
    }
}
