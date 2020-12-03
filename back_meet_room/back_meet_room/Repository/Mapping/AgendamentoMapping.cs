using back_meet_room.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back_meet_room.Repository.Mapping
{
    public class AgendamentoMapping : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.DataReserva).IsRequired();
            builder.Property(x => x.HoraInicio).IsRequired();
            builder.Property(x => x.HoraFim).IsRequired();
            builder.Property(x => x.Computador);
            builder.Property(x => x.Projetor);
            builder.Property(x => x.Video);
        }
    }
}
