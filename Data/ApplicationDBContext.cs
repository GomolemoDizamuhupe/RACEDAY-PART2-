using Microsoft.EntityFrameworkCore;
using RACEDAY_PART2_.Models;

namespace RACEDAY_PART2_.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }

        public DbSet<Users> users { get; set; }
        public DbSet<UserResults> results { get; set; }
        public DbSet<RaceRoutes> raceRoutes { get; set; }
        public DbSet<Events> events { get; set; }
        public DbSet<Entries> entries { get; set; }
        public DbSet<Category> categories { get; set; }


    }
}
