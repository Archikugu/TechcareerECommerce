using ECommerce.Core.Business.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.Business.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetListWithUser(int id);
    }
}
