using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.Abstract
{
    public interface ICommentDal : IGenericDal<Comment>
    {
        public List<Comment> GetListWithUser(int id);
    }
}
