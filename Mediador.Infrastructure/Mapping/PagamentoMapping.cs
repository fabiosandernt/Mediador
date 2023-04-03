using Mediador.Domain.Planos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Mediador.Infrastructure.Mapping
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.ToTable("Pagamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("Id")
                .IsRequired();
            builder.Property(x=>x.Valor).HasColumnName("Valor").IsRequired();
            builder.Property(x=>x.DataPagamento).HasColumnName("DataPagamento").IsRequired();
        }  
    }
}
