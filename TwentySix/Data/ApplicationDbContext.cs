using Microsoft.EntityFrameworkCore;
using TwentySix.Models;

namespace TwentySix.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Colours> Colours { get; set; }

    }
}
