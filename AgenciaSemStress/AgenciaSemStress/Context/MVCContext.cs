using AgenciaSemStress.Models;
using Microsoft.EntityFrameworkCore;

namespace AgenciaSemStress.Context
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<AnunciosModel> Anuncios { get; set; }
        public DbSet<DestinosModel> Destinos { get; set; }
        public DbSet<ClientesModel> Clientes { get; set; }
        public DbSet<ReservasModel> Reservas { get; set; }
        public DbSet<Contato> Contato { get; set; }
       

    }
}
