using Mediador.Domain.Empresas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mediador.Infrastructure.Mapping
{
    public class EmpresaMapping : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.RazaoSocial).IsRequired();
            builder.Property(x=>x.Cnpj).IsRequired();
            builder.HasMany(p => p.Sindicatos).WithMany(p => p.Empresas);
        }
    }
}
