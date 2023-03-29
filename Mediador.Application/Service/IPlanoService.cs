using Mediador.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Application.Service
{
    public interface IPlanoService
    {
        Task<PlanoDto> Criar(PlanoDto dto);
        Task<List<PlanoDto>> ObterTodos();
        Task<PlanoDto> Atualizar(PlanoDto dto);
        Task<PlanoDto> Deletar(PlanoDto dto);
        Task<PlanoDto> ObterPorId(Guid id);
    }
}
