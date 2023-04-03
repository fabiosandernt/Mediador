using Mediador.Domain.Clientes;
using Mediador.Domain.Comum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

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
                e.Property(x => x.Logradouro).HasColumnName("Logradouro").IsRequired().HasMaxLength(200);
                e.Property(x => x.Numero).HasColumnName("Numero").IsRequired().HasMaxLength(10);
                e.Property(x => x.Complemento).HasColumnName("Complemento").HasMaxLength(200);
                e.Property(x => x.Bairro).HasColumnName("Bairro").IsRequired().HasMaxLength(100);
                e.Property(x => x.Cidade).HasColumnName("Cidade").IsRequired().HasMaxLength(100);
                e.Property(x => x.Estado).HasColumnName("Estado").IsRequired().HasMaxLength(2)
                    .HasConversion(
                        v => v.ToString(),
                        v => (EstadoEnum)Enum.Parse(typeof(EstadoEnum), v)
                    );
                e.Property(x => x.Cep).HasColumnName("Cep").IsRequired().HasMaxLength(8);
            }).Navigation(x => x.Endereco);

            builder.OwnsOne(x => x.Documento, ba =>
            {
                ba.Property(c => c.Numero)
                    .HasColumnName("Documento")
                    .HasColumnType("varchar")
                    .HasMaxLength(14)
                    .IsRequired(true);

                ba.HasIndex(x => x.Numero)
                    .IsUnique(false);
            }).Navigation(x => x.Documento).IsRequired();
          
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

            builder.HasMany(p => p.Empresas).WithOne(p => p.Cliente);

            builder.HasMany(x => x.Pagamentos).WithOne(x => x.Cliente);

        }
    }
}
