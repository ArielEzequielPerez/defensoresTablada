using defensoresTablada.Models.BBDD;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace defensoresTablada.Data
{
    public class DefensoresContext : IdentityDbContext<ApplicationUser>
    {
        public DefensoresContext(DbContextOptions<DefensoresContext> options)
            : base(options)
        {
        }
        

        public DbSet<MaximaRepeticion> MaximasRepeticiones { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        
    }
}
