using Microsoft.EntityFrameworkCore;
using Pcp.Domain.Entities;
using System.Reflection;

namespace Pcp.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<OrdemProducao> OrdensProducao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
    
    }  
