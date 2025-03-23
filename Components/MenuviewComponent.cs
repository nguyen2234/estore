using Microsoft.AspNetCore.Mvc;
using estore.Models;

namespace Web.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuviewComponent : ViewComponent
    {
        private readonly DataContex _context;
        public MenuviewComponent(DataContex context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var ListOfMenu = (from m in _context.tblMenus
            where (m.IsActive == true) select m).ToList();
            return await Task.FromResult((IViewComponentResult)View("Default", ListOfMenu));
        }
    }
}