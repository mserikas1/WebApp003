using Microsoft.EntityFrameworkCore;

namespace WebApp003
{
    public class WebApp003DbContext : DbContext
    {
        public WebApp003DbContext(DbContextOptions<WebApp003DbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
