using Mediador.Domain.Usuario;
using Mediador.Domain.ValueObject;

namespace Mediador.Domain.Contrato.Factory
{
    public interface IClienteFactory
    {
        Cliente CriarCliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade,
            Estado estado, string cep, string telefone, Documento documento, Email email, Password password, TipoPlanoEnum plano, 
            TipoDocumentoEnum tipoDocumento, Guid userId, User user);
    }
}
