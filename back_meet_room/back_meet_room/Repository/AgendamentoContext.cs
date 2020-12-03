using back_meet_room.Model;
using back_meet_room.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace back_meet_room.Repository
{
    public class AgendamentoContext : DbContext
    {
        public DbSet<Sala> Salas { get; set; }

        public DbSet<Agendamento> Agendamentos { get; set; }

        public AgendamentoContext(DbContextOptions<AgendamentoContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SalaMapping());
            modelBuilder.ApplyConfiguration(new AgendamentoMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ILoggerFactory Logger = LoggerFactory.Create(x => x.AddConsole());
            optionsBuilder.UseLoggerFactory(Logger);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
