using estore.Models;
using Microsoft.AspNetCore.Mvc;
using NuGet.Common;

namespace estore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        private readonly DataContex _context;
        public MenuController(DataContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var mnlist = _context.tblMenus.OrderBy(m => m.MenuId).ToList();
            return View(mnlist);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();
            var mn = _context.tblMenus.Find(id);
            if(mn ==null)
            
                return NotFound();
            return View(mn);
            
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var delmn = _context.tblMenus.Find(id);
            if (delmn == null)
                return NotFound();
            _context.tblMenus.Remove(delmn);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
