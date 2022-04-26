using System.Reflection;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Context
{
    public class MPDbContext : DbContext
    {
        public MPDbContext(DbContextOptions<MPDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
    }
}