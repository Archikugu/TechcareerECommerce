using Microsoft.AspNetCore.Mvc;
using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities.Concrete;

namespace ECommerce.Areas.Management.Controllers
{
    [Area("Management")]
    public class LoginController : Controller
    {
        private readonly IAdminService _adminService;

        public LoginController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Admin model)
        {
            var values = _adminService.TGetList();
            var admin = values.FirstOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);

            if (admin != null)
            {
                return RedirectToAction("Category", "Management");
            }

            return RedirectToAction("Login", "Management");

        }

    }
}

