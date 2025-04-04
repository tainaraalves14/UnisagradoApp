using Microsoft.EntityFrameworkCore;
using AvaliacaoSatisfacaoUnisagrado.Models;

namespace AvaliacaoSatisfacaoUnisagrado.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Avaliacao> Avaliacoes { get; set; }
    }
}
