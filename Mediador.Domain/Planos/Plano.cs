using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes;

namespace Mediador.Domain.Planos
{
    public class Plano : Entity<Guid>
    {
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>(0);
    }
}
