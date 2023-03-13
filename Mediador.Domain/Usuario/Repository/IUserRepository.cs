

using Mediador.Domain.Interfaces;

namespace Mediador.Domain.Usuario.Repository
{
    public interface IUserRepository: IRepository<User>
    {
        Task<IEnumerable<User>> ObterTodosUsuarios();
        Task<IEnumerable<User>> ObterUsuarioPorId(Guid id);
    }
}
