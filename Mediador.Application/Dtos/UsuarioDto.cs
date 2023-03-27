using Mediador.Domain.Usuario;
using Mediador.Domain.Usuario.ValueObject;

namespace Mediador.Application.Dtos
{
    public class UsuarioDto
    {
        public string Nome { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public TipoUsuarioEnum TipoUsuario { get; set; }
    }
}
