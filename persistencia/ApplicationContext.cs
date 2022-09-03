using System;
using Microsoft.EntityFrameworkCore;
using dominio;

namespace persistencia
{
    public class ApplicationContext : DbContext
    {
        private const string connectionString = @"Data Source=localhost;Initial Catalog=vehiculoDB;Integrated Security=True;";
        
          public DbSet<Clientes> clientes {get; set;}
        
        public ApplicationContext() { }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
