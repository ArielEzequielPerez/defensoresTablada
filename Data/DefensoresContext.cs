using defensoresTablada.Models.BBDD;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace defensoresTablada.Data
{
    public class DefensoresContext : IdentityDbContext
    {
        public DefensoresContext(DbContextOptions<DefensoresContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        
    }
}
