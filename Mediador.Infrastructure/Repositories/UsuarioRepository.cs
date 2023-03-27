using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.Repository;
using Mediador.Infrastructure.Context;
using Mediador.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;

namespace Mediador.Infrastructure.Repositories
{
    public class UsuarioRepository : Repository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(DataContext context) : base(context)
        {

        }
        public async Task<IEnumerable<Usuario>> ObterTodosUsuarios()
        {
            return await this.Query.ToListAsync(); 
        }

        public async Task<IEnumerable<Usuario>> ObterUsuarioPorId(Guid id)
        {
            return await this.Query.Where(x => x.Id == id).ToListAsync();
        }
    }
}
