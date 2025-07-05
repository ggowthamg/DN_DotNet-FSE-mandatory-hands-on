using Microsoft.EntityFrameworkCore;
using _3CreateandApplyMigrations.Models;

namespace _3CreateandApplyMigrations.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}
