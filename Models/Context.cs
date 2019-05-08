using Microsoft.EntityFrameworkCore;

namespace MakeupProject.Models
{
    public class MakeupProjectDbContext : DbContext
    {
        public MakeupProjectDbContext(DbContextOptions<MakeupProjectDbContext> options)
            : base(options)
            {
            }

            public DbSet<MakeupProject.Models.Products> Product {get; set;}
            public DbSet<MakeupProject.Models.Review> Review {get; set;}
    }
}