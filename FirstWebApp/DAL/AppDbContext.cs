using FirstWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Registration> Registrations{ get; set; }



    }
}
