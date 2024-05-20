using ECommerce.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICouponService _couponService;

        public DefaultController(ICouponService couponService)
        {
            _couponService = couponService;
        }

        public IActionResult Index()
        {
            ViewBag.username = HttpContext.Session.GetString("username");
            ViewBag.mail = HttpContext.Session.GetString("mail");
            ViewBag.userid = HttpContext.Session.GetInt32("userid");
            return View();
        }
    }
}
