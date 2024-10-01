using Microsoft.EntityFrameworkCore;
using BaragaMemberApp.Models;

namespace BaragaMemberApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
    }
}
