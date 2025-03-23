using Microsoft.EntityFrameworkCore;

namespace estore.Models
{
    public class DataContex :DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options)
        {}
        public DbSet<tblMenu> tblMenus{ get; set; }
    }
}