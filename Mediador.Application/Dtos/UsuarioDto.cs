using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.ValueObject;

namespace Mediador.Application.Dtos
{
    public class UsuarioDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
    }
}
