using Mediador.Domain.Interfaces;

namespace Mediador.Domain.Clientes.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> ObterTodosClientes();
        Task<IEnumerable<Cliente>> ObterTodosClientesPorDocumento(string parametro);
        
    }
}
