using Microsoft.EntityFrameworkCore;

namespace RACEDAY_PART2_.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { }
    }
}
