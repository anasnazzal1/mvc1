using Microsoft.EntityFrameworkCore; 
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                optionsBuilder.UseSqlServer(
                    "Server=(localdb)\\MSSQLLocalDB;Database=MVC13;Trusted_Connection=True;TrustServerCertificate=True"
                );
            }
        }
    }
}
