using Mediador.Application.Dtos;
using Mediador.Domain.Clientes;
using Mediador.Domain.Usuario;
using AutoMapper;

namespace Mediador.Application.Profile
{
    internal class MediadorProfile: Profile
    {
        public MediadorAutoMapperConfig()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
