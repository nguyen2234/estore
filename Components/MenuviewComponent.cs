using Microsoft.AspNetCore.Mvc;
using estore.Models;

namespace estore.Components
{
    [ViewComponent(Name = "MenuView")]
    public class MenuViewComponent : ViewComponent
    {
        private readonly DataContex _context;
        public MenuViewComponent(DataContex context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
           var ListOfMenu = (from m in _context.tblMenus 
                             where (m.IsActive==true) select m).ToList(); 
            return await Task.FromResult((IViewComponentResult)View("Default", ListOfMenu));
        }
    }
}