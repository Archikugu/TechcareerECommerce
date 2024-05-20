using ECommerce.Core.Business.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.Business.Abstract
{
    public interface ICouponService : IGenericService<Coupon>
    {
        public string TCheckCoupon(string couponCode);
    }
}
