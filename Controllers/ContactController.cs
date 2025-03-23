using Microsoft.AspNetCore.Mvc;

namespace estore.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
