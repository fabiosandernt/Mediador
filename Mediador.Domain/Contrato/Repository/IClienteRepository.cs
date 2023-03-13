using Mediador.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.Contrato.Repository
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        Task<IEnumerable<Cliente>> ObterTodasClientes();
        Task<IEnumerable<Cliente>> ObterTodasClientesPorCnpj(string parametro);
        Task<IEnumerable<Cliente>> ObterTodasClientesPorCpf(string parametro);
    }
}
