using Mediador.Domain.Clientes;

namespace Mediador.Domain.Planos
{
    public class Pagamento
    {
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; private set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
