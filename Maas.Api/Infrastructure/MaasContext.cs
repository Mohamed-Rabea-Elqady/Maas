using Maas.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Maas.Api.Infrastructure
{
    public class MaasContext : DbContext
    {
        public DbSet <Employee> Employees { get; set; }

       public MaasContext(DbContextOptions options) : base (options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Asp\\Applications\\Maas\\DB\\Maas.mdf;Integrated Security=True;Connect Timeout=30");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
