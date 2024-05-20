using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public string Address { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public int ProductID { get; set; }
        public int ProductCount { get; set; }
        public virtual Product Product { get; set; }
        public bool Status { get; set; }
    }
}
