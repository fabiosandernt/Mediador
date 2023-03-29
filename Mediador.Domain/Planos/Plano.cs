using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes;

namespace Mediador.Domain.Planos
{
    public class Plano : Entity<Guid>
    {
        public Plano(string nome, bool ativoOuInativo, string motivoDesativacao, bool pagamentoRealizado)
        {
            Nome = nome;
            AtivoOuInativo = ativoOuInativo;
            MotivoDesativacao = motivoDesativacao;
            PagamentoRealizado = pagamentoRealizado;
        }       
       
        public string Nome { get; private set; }
        public bool AtivoOuInativo { get; private set; }
        public string MotivoDesativacao { get; private set; }
        public bool PagamentoRealizado { get; private set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

        protected Plano() { }

        public Plano(string nome, bool ativoOuInativo, string motivoDesativacao, bool pagamentoRealizado, ICollection<Cliente> clientes) : this(nome, ativoOuInativo, motivoDesativacao, pagamentoRealizado)
        {
            Clientes = clientes;
        }

        public void Ativar()
        {
            AtivoOuInativo = true;
            MotivoDesativacao = null;
        }

        public void DesativarPorMotivo(string motivo)
        {
            AtivoOuInativo = false;
            MotivoDesativacao = motivo;
        }

        public void AtivarOuDesativar(bool ativar)
        {
            this.AtivoOuInativo = ativar;
        }


        public void AdicionarCliente(Cliente cliente)
        {
            Clientes.Add(cliente);
        }

        public void RemoverCliente(Cliente cliente)
        {
            Clientes.Remove(cliente);
        }

       
    }
}
