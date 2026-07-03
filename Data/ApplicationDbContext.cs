using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
