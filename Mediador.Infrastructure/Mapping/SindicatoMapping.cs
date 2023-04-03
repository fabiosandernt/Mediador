using Mediador.Domain.InstrumentoColetivo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mediador.Infrastructure.Mapping
{
    public class SindicatoMapping : IEntityTypeConfiguration<Sindicato>
    {
        public void Configure(EntityTypeBuilder<Sindicato> builder)
        {
            builder.ToTable("Sindicato");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.RazaoSocial).IsRequired();
            builder.Property(x => x.Cnpj).IsRequired();

            builder.Property(x => x.TipoSindicato).HasConversion(x => x.ToString(),
                        v => (TipoSindicatoEnum)Enum.Parse(typeof(TipoSindicatoEnum), v));

            builder.HasMany(p => p.ConvencaoColetivas).WithMany(p => p.Sindicatos);

            builder.HasMany(p => p.Empresas).WithMany(p => p.Sindicatos);
        }
    }
}
