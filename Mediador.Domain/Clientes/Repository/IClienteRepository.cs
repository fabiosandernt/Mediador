using Mediador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.Clientes.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> ObterTodosClientes();
        Task<IEnumerable<Cliente>> ObterTodosClientesPorDocumento(string parametro);
        
    }
}
