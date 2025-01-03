using BaseStructure.Domain.DatabaseModels;
using Microsoft.EntityFrameworkCore;

namespace BaseStructure.Infrastructure.DatabaseModels.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.SetCommandTimeout(TimeSpan.FromSeconds(60));
        }

        public DbSet<User> Users { get; set; }
    }
}
