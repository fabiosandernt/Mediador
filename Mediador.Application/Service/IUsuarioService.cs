using Mediador.Application.Dtos;

namespace Mediador.Application.Service
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Criar(UsuarioDto dto);
        Task<List<UsuarioDto>> ObterTodos();
        Task<UsuarioDto> Atualizar(UsuarioDto dto);
        Task<UsuarioDto> Deletar(UsuarioDto dto);
        Task<UsuarioDto> ObterPorId(Guid id);
        Task<string> ObterTokenJwtAsync(LoginDto dto);
    }
}
