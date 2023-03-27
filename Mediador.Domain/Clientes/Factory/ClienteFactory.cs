using Mediador.Domain.Clientes.ValueObject;
using Mediador.Domain.Usuario;
using Mediador.Domain.Usuario.ValueObject;

namespace Mediador.Domain.Clientes.Factory
{
    public class ClienteFactory : IClienteFactory
    {
        public Cliente CriarCliente(string nome, string logradouro, string numero, string complemento, string bairro,
            string cidade, Estado estado, string cep, string telefone, Documento documento, Email email, Password password, TipoPlanoEnum plano, TipoDocumentoEnum tipoDocumento, Guid userId, Usuario.Usuario user)
        {

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("O nome do cliente é obrigatório.", nameof(nome));

            if (string.IsNullOrEmpty(logradouro))
                throw new ArgumentException("O logradouro do endereço do cliente é obrigatório.", nameof(logradouro));

            if (string.IsNullOrEmpty(numero))
                throw new ArgumentException("O número do endereço do cliente é obrigatório.", nameof(numero));

            if (string.IsNullOrEmpty(bairro))
                throw new ArgumentException("O bairro do endereço do cliente é obrigatório.", nameof(bairro));

            if (string.IsNullOrEmpty(cidade))
                throw new ArgumentException("A cidade do endereço do cliente é obrigatória.", nameof(cidade));

            if (string.IsNullOrEmpty(cep))
                throw new ArgumentException("O CEP do endereço do cliente é obrigatório.", nameof(cep));

            if (string.IsNullOrEmpty(telefone))
                throw new ArgumentException("O telefone do cliente é obrigatório.", nameof(telefone));

            if (email == null)
                throw new ArgumentNullException(nameof(email));

            if (email == null)
                throw new ArgumentNullException(nameof(documento));

            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var endereco = new Endereco(logradouro, numero, complemento, bairro, cidade, estado, cep);

            return new Cliente(nome, endereco, telefone, documento, email, password, plano, tipoDocumento, userId, user);
        }
    }
}
