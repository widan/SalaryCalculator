using Microsoft.EntityFrameworkCore;
using SalaryCalculator.Entities;
using System.Reflection.Metadata;

namespace SalaryCalculator.Data
{
    public class SalaryCalculatorContext : DbContext
    {
        public DbSet<TypeOfContractEntity> TypesOfContract { get; set; }
        public DbSet<SalaryEntity> SalaryEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TypeOfContractEntity>()
                .HasData(
                new TypeOfContractEntity { Id = 1, FullName = "Umowa o pracę", Shortcut = "UoP" },
                new TypeOfContractEntity { Id = 2, FullName = "Business to business", Shortcut = "B2B" },
                new TypeOfContractEntity { Id = 3, FullName = "Umowa zlecenie", Shortcut = "UZ" }
                );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("SalaryDB"));
        }
    }
}
