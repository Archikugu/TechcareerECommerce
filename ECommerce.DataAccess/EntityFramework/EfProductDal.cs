using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Product> GetProductByCategory(int id)
        {
            using var context = new Context();
            var result = context.Products.Include("Category").Where(x => x.CategoryID == id).ToList();
            return result;
        }
    }
}
