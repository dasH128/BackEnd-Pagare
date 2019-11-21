using Finanzas.Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Finanzas.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Distrito> Distrito { get; set; }
        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Moneda> Moneda { get; set; }
        public DbSet<Letra> Letra { get; set; }
        public DbSet<Girado> Girado { get; set; }
        public DbSet<GiradoEmpresa> GiradoEmpresa { get; set; }
        public DbSet<GiradoPersona> GiradoPersona { get; set; }
        public DbSet<HistorialLetra> HistorialLetra { get; set; }

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e =>e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}