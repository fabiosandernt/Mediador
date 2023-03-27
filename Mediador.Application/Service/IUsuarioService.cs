using Mediador.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
