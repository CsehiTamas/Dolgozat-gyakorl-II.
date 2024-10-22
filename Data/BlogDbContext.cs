using Dolgozat_gyakorló_II_.Models;
using Microsoft.EntityFrameworkCore;

namespace Dolgozat_gyakorló_II_.Models
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }

        public DbSet<BlogUser> blogUsers { get; set; }
    }
}