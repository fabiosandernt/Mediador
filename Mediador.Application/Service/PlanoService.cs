using AutoMapper;
using Mediador.Application.Dtos;
using Mediador.Domain.Planos.Repository;

namespace Mediador.Application.Service
{
    public class PlanoService : IPlanoService
    {
        private readonly IPlanoRepository _planoRepository;
        private readonly IMapper _mapper;

        public PlanoService(IPlanoRepository planoRepository, IMapper mapper)
        {
            _planoRepository = planoRepository;
            _mapper = mapper;
        }

        public Task<PlanoDto> Atualizar(PlanoDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<PlanoDto> Criar(PlanoDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<PlanoDto> Deletar(PlanoDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<PlanoDto> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<PlanoDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
