using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PojisteniApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PojisteniApp.Models.Customer>? Customer { get; set; }
        public DbSet<PojisteniApp.Models.Insurance>? Insurance { get; set; }
    }
}