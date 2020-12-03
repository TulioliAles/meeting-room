using back_meet_room.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace back_meet_room.Repository.Mapping
{
    public class SalaMapping : IEntityTypeConfiguration<Sala>
    {
        public void Configure(EntityTypeBuilder<Sala> builder)
        {
            builder.ToTable("Sala");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Quantidade).IsRequired();
            builder.Property(x => x.Computador).IsRequired();
            builder.Property(x => x.Projetor).IsRequired();
            builder.Property(x => x.VideoConferencia).IsRequired();
        }
    }
}
