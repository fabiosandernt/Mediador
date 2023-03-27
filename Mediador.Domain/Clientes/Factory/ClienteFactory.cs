using Mediador.Domain.Clientes.ValueObject;
using Mediador.Domain.Comum;
using Mediador.Domain.Planos;
using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.ValueObject;
using Mediador.Domain.ValueObject;

namespace Mediador.Domain.Clientes.Factory
{
    public class ClienteFactory : IClienteFactory
    {
        public Cliente CriarCliente(string nome, string logradouro, string numero, string complemento, string bairro,
            string cidade, EstadoEnum estado, string cep, string telefone, DocumentoIdentificacao documento, Email email, Password password, Plano plano, Guid userId, Usuario user)
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

            return new Cliente(nome, endereco, telefone, documento, email, password, plano, userId, user);
        }
    }
}
