using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Areas.Management.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
