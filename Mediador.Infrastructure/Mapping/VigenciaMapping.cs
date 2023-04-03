using Mediador.Domain.InstrumentoColetivo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mediador.Infrastructure.Mapping
{
    public class VigenciaMapping : IEntityTypeConfiguration<Vigencia>
    {
        public void Configure(EntityTypeBuilder<Vigencia> builder)
        {
            builder.ToTable("Vigencia");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
