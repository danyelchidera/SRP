using Microsoft.EntityFrameworkCore;
using SRP.Models;

namespace SRP.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

    }
}
