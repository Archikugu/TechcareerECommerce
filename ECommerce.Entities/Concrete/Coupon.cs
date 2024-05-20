using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete
{
    public class Coupon : IEntity
    {
        public int CouponID { get; set; }
        public string CouponCode { get; set; }
        public DateTime Date { get; set; }
    }
}
