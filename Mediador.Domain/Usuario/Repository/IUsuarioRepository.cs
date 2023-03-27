

using Mediador.Domain.Interfaces;

namespace Mediador.Domain.Usuario.Repository
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> ObterTodosUsuarios();
        Task<IEnumerable<Usuario>> ObterUsuarioPorId(Guid id);
    }
}
