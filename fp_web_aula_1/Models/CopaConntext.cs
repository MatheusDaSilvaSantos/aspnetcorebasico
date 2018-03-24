using Microsoft.EntityFrameworkCore;

namespace fp_web_aula_1.Models
{
    public class CopaContext : DbContext
    {
        public CopaContext(DbContextOptions<CopaContext> options)
            : base(options)
        {
            
        }

        public DbSet<Time> Times { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }

    }
}
