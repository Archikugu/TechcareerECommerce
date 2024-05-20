using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetListWithUser(int id)
        {
            using var context = new Context();
            var result = context.Comments.Include("User").Where(x => x.Status == true && x.ProductID == id).ToList();
            return result;
        }
    }
}
