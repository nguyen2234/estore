using Microsoft.AspNetCore.Mvc;
using estore.Areas.Admin.Models;
using estore.Models;
using estore.Utilities;

namespace estore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly DataContex _context;

        public ContactController(DataContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contacts = _context.AdminContacts.OrderByDescending(c => c.ContactID).ToList();
            return View(contacts);
        }

        /*public IActionResult Details(int id)
        {
            var contact = _context.AdminContacts.FirstOrDefault(c => c.ContactID == id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }*/
    }
}
