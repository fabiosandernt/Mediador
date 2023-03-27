using Mediador.Domain.Clientes;
using Mediador.Domain.Clientes.Repository;
using Mediador.Infrastructure.Context;
using Mediador.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Mediador.Infrastructure.Repositories
{
    public class ClienteRepositor : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepositor(DataContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Cliente>> ObterTodosClientes()
        {
           return await this.Query.ToListAsync();
        }

        public async Task<IEnumerable<Cliente>> ObterTodosClientesPorDocumento(string documento)
        {
            return await this.Query.Where(c => c.Documento.Valor == documento).ToListAsync();
        }
    }
    
}

