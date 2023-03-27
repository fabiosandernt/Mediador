using Mediador.Domain.Clientes.ValueObject;
using Mediador.Domain.Clientes;
using Mediador.Domain.Usuario.ValueObject;

namespace Mediador.Application.Dtos
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public Documento Documento { get; set; }
        public Email Email { get; set; }
        public Password Password { get; set; }
        public TipoPlanoEnum Plano { get; set; }
        public TipoDocumentoEnum TipoDocumento { get; set; }
        public Guid UsuarioId { get; set; }
        public UsuarioDto Usuario { get; set; }
    }
}
