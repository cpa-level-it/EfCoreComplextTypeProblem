using Microsoft.EntityFrameworkCore;

namespace EfCore8Tests.Models
{
    public class ComplexTypeDbContext : DbContext
    {
        public DbSet<UserContext> UserContexts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLazyLoadingProxies()
                .UseSqlServer($"Data Source=localhost;Initial Catalog=EFCoreProxies;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<UserContext>()
                .ComplexProperty(
                x => x.CompanyIdentificationData,
                b => b.ComplexProperty(x => x.Belgium));


        }
    }
}
