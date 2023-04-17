using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAula.Domain.Models;
using WebAula.Infra.Database.Configurations;

namespace WebAula.Infra.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }


        protected override void OnModelCreating(ModelBuilder builder) {  
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ClienteConfiguration());
        }
    }
}
