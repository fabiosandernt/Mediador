using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes;

namespace Mediador.Domain.Planos
{
    public class Pagamento: Entity<Pagamento>
    {
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; private set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        protected Pagamento()
        {

        }
    }
}
