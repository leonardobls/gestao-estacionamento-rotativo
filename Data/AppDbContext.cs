

using GestaoEstacionamentoRotativo.Models;
using Microsoft.EntityFrameworkCore;

namespace GestaoEstacionamentoRotativo.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Rotativo> Rotativo { get; set; }

        public DbSet<Veiculo> Veiculo { get; set; }

        public DbSet<VeiculoCategoria> VeiculoCategoria { get; set; }

        public DbSet<Precos> Precos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseNpgsql("Server=localhost;Port=5432;Database=EstacionamentoGestor;User Id=postgres;Password=1788;");
    }
}