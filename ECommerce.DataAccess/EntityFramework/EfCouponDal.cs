using ECommerce.DataAccess.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.DataAccess.Repositories;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.EntityFramework
{
    public class EfCouponDal : GenericRepository<Coupon>, ICouponDal
    {
        public string CheckCoupon(string couponCode)
        {
            using var context = new Context();
            var today = DateTime.Now.Date;
            var coupon = context.Coupons.FirstOrDefault(x => x.CouponCode == couponCode &&
                                                              x.Date.Year == today.Year &&
                                                              x.Date.Month == today.Month &&
                                                              x.Date.Day == today.Day);

            if (coupon == null)
            {
                var havecoupon = context.Coupons.Where(x => x.CouponCode == couponCode && (x.Date.Month < today.Month ||
                                                              x.Date.Day < today.Day)).FirstOrDefault();
                if (havecoupon == null)
                {
                    return "kuponyok";
                }
                else
                {
                    return "tarihigeçmiş";
                }
            }
            else
            {
                return "uygunkupon";
            }
        }
    }
}
