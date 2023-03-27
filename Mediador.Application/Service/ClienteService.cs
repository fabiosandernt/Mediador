using AutoMapper;
using Mediador.Domain.Clientes.Repository;


namespace Mediador.Application.Service
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IMapper mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            this.clienteRepository = clienteRepository;
            this.mapper = mapper;
        }
    }
}
