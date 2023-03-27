using Mediador.Domain.Comum;
using Mediador.Domain.Planos;
using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.ValueObject;
using Mediador.Domain.ValueObject;

namespace Mediador.Domain.Clientes.Factory
{
    public interface IClienteFactory
    {
        Cliente CriarCliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade,
            EstadoEnum estado, string cep, string telefone, DocumentoIdentificacao documento, Email email, Password password, Plano plano, 
            Guid userId, Usuario user);
    }
}
