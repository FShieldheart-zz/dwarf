using System.IO;
using DWARF.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DWARF.Repository.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        public MainDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MainDbContext>();

            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            builder.UseNpgsql(configurationBuilder.Build().GetConnectionString("DataConnection"));

            return new MainDbContext(builder.Options);
        }
    }
    public class MainDbContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
