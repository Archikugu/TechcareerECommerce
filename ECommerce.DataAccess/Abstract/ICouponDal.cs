﻿using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.Abstract
{
    public interface ICouponDal : IGenericDal<Coupon>
    {
        public string CheckCoupon(string couponCode);
    }
}
