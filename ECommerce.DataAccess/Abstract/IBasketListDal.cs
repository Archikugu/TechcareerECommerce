using ECommerce.Core.DataAccess.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.DataAccess.Abstract
{
    public interface IBasketListDal : IGenericDal<BasketList>
    {
        public bool BasketControl(int id, int userid);
        public List<BasketList> GetBasketWithProduct(int userid);
        public int BasketSumPrice(int userid);
        void UpdateCount(int basketid, int count);
        void DeleteBasket(int basketid);
        public bool CardNumberControl(string cardNumber);
        void DeleteBaskets(int userid);
    }
}
