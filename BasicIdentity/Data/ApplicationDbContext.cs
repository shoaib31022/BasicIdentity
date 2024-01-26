using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BasicIdentity.Models;

namespace BasicIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BasicIdentity.Models.YtDetail>? ytdetail { get; set; }
        public DbSet<BasicIdentity.Models.Post>? postpoetry { get; set; }
        public DbSet<BasicIdentity.Models.Category>? category { get; set; }
    }
}