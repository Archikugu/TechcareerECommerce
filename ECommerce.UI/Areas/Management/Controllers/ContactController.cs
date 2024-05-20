using ECommerce.Business.Abstract;
using ECommerce.DataAccess.Concrete;
using ECommerce.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Areas.Management.Controllers
{
    [Area("Management")]
    public class ContactController : Controller
    {

        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var contacts = _contactService.TGetList();
            return View(contacts);
        }

        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return RedirectToAction("Contact", "Management");
        }
    }
}
