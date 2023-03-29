using Mediador.Application.Dtos;
using Mediador.Domain.Clientes;
using Mediador.Domain.Usuarios;


namespace Mediador.Application.Profile
{
    public class MediadorProfile: AutoMapper.Profile
    {
        public MediadorProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
            CreateMap<Cliente, ClienteDto>();
        }
    }
}
