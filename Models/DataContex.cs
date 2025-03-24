using Microsoft.EntityFrameworkCore;
using estore.Areas.Admin.Models;
namespace estore.Models
{
    public class DataContex :DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options)
        {}
        public DbSet<TblMenu> tblMenus{ get; set; }
        public DbSet<AdminMenu> adminMenus{ get; set; }
    }
}