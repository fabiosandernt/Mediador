using Mediador.Domain.InstrumentoColetivo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mediador.Infrastructure.Mapping
{
    public class ConvencaoColetivaMapping : IEntityTypeConfiguration<ConvencaoColetiva>
    {
        public void Configure(EntityTypeBuilder<ConvencaoColetiva> builder)
        {
            builder.ToTable("ConvencaoColetiva");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.NumeroProcesso);
            builder.Property(x => x.NumeroRegistro);
            builder.Property(x => x.NomeSindicatoPatronal);
            builder.Property(x => x.NomeSindicatoTrabalhador);

            builder.HasMany(x => x.Sindicatos)
                .WithMany(x => x.ConvencaoColetivas);
               

            builder.HasMany(x => x.Vigencias)
                .WithOne(x => x.ConvencaoColetiva)
                .HasForeignKey(x=>x.ConvencaoColetivaId);
        }
    }
}
