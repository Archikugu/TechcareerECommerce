using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete
{
    public class BasketList : IEntity
    {
        public int BasketListID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int ProductCount { get; set; }
    }
}
