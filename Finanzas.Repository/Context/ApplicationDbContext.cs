using Finanzas.Entity;
using Microsoft.EntityFrameworkCore;

namespace Finanzas.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Distrito> Distrito { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options){

        }
    }
}