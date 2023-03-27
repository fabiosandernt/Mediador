using Mediador.Domain.Clientes;
using Mediador.Domain.Clientes.ValueObject;
using Mediador.Domain.Comum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mediador.Infrastructure.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).IsRequired();

            builder.OwnsOne(x => x.Endereco, e =>
            {
                e.Property(x => x.Logradouro).IsRequired().HasMaxLength(200);
                e.Property(x => x.Numero).IsRequired().HasMaxLength(10);
                e.Property(x => x.Complemento).HasMaxLength(200);
                e.Property(x => x.Bairro).IsRequired().HasMaxLength(100);
                e.Property(x => x.Cidade).IsRequired().HasMaxLength(100);
                e.Property(x => x.Estado).IsRequired().HasMaxLength(2)
                    .HasConversion(
                        v => v.ToString(),
                        v => (EstadoEnum)Enum.Parse(typeof(EstadoEnum), v)
                    );
                e.Property(x => x.Cep).IsRequired().HasMaxLength(8);
            });
            builder.OwnsOne(x => x.Email, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Email").IsRequired().HasMaxLength(1024);
            });

            builder.OwnsOne(x => x.Email, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Email").IsRequired().HasMaxLength(1024);
            });

            builder.OwnsOne(x => x.Password, p =>
            {
                p.Property(f => f.Valor).HasColumnName("Password").IsRequired();
            });
            builder.Property(x => x.Plano)
                    .IsRequired()
                    .HasColumnName("TipoPlano")
                    .HasColumnType("int")
                    .HasConversion<int>();

            builder.Property(x => x.TipoDocumento)
                    .IsRequired()
                    .HasColumnName("TipoDocumento")
                    .HasColumnType("int")
                    .HasConversion<int>();      

        }
    }
}
