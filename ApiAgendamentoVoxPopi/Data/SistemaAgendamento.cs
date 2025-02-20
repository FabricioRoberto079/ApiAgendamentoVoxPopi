using ApiAgendamentoVoxPopi.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAgendamentoVoxPopi.Data
{
    public class SistemaAgendamentoDbContext : DbContext
    {
        public SistemaAgendamentoDbContext(DbContextOptions<SistemaAgendamentoDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Agendamento> Agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Agendamento>().ToTable("Agendamento");
        }   
    }

}
