using Microsoft.AspNetCore.Mvc;

namespace estore.Areas.Admin.Controllers;

    [Area("Admin")]
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
    }