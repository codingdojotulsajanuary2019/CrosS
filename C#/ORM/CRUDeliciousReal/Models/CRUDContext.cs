using Microsoft.EntityFrameworkCore;

namespace CRUDeliciousReal.Models
{
    public class CRUDContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public CRUDContext(DbContextOptions options) : base(options) { }

        public DbSet<User> dishes {get;set;}
    }
}