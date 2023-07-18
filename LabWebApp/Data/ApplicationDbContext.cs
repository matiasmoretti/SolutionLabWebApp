using LabWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LabWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
    }
}
