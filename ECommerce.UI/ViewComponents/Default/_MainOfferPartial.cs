using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.ViewComponents.Default
{
    public class _MainOfferPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
