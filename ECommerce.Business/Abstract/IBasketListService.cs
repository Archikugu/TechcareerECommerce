using ECommerce.Core.Business.Abstract;
using ECommerce.Entities.Concrete;

namespace ECommerce.Business.Abstract
{
    public interface IBasketListService : IGenericService<BasketList>
    {
        bool TBasketControl(int id, int userid);
        public List<BasketList> TGetBasketWithProduct(int userid);
        public int TBasketSumPrice(int userid);
        void TUpdateCount(int basketid, int count);
        void TDeleteBasket(int basketid);
        public bool TCardNumberControl(string cardNumber);
        void TDeleteBaskets(int userid);
    }
}
