using Demo.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class ApplicationDbContext: IdentityDbContext<Users>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
    }
}
