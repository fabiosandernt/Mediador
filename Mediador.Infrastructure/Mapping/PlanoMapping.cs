using Mediador.Domain.Planos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mediador.Infrastructure.Mapping
{
    public class PlanoMapping : IEntityTypeConfiguration<Plano>
    {
        public void Configure(EntityTypeBuilder<Plano> builder)
        {
            builder.ToTable("Plano");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnName("Nome")
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.AtivoOuInativo)
                .HasColumnName("AtivoOuInativo")
                .IsRequired();

            builder.HasMany(x => x.Clientes)
                .WithOne(x => x.Plano)
                .HasForeignKey(x => x.PlanoId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
