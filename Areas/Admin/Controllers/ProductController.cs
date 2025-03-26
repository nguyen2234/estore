using estore.Models;
using Microsoft.AspNetCore.Mvc;

namespace estore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController :Controller
    {
        private readonly DataContex _context;
        public ProductController (DataContex contex)
        {
            _context = contex;
        }

        public IActionResult Index()
        {
            var productlist = _context.tblProducts.OrderBy(p => p.Id).ToList();
            return View(productlist);
        }
    }
}
