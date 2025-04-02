using estore.Models;
using Microsoft.AspNetCore.Mvc;

namespace estore.Controllers
{

    public class ProductController : Controller
    {
        private readonly DataContex _contex;
        public ProductController(DataContex contex)
        {
            _contex = contex;
        }
        public IActionResult Index()
        {
            var pd = _contex.tblProducts.OrderBy(m=>m.IsActive).ToList();
            return View(pd);
        }

    }
}
