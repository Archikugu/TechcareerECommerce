
using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ECommerce.Areas.Management.Controllers
{
    [Area("Management")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        private readonly Context _context;

        public AdminController(IAdminService adminService, Context context)
        {
            _adminService = adminService;
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _adminService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAdmin(Admin admin)
        {
            admin.Status = true;
            _adminService.TInsert(admin);
            return RedirectToAction("Admin", "Management");
        }

        [HttpGet]
        public IActionResult UpdateAdmin(int id)
        {
            var value = _adminService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateAdmin(Admin admin)
        {
            admin.Status = true;
            _adminService.TUpdate(admin);
            return RedirectToAction("Admin", "Management");
        }

        public IActionResult DeleteAdmin(int id)
        {
            var value = _adminService.TGetByID(id);
            _adminService.TDelete(value);
            return RedirectToAction("Admin", "Management");
        }

    }
}
