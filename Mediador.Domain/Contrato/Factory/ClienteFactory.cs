using Mediador.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.Contrato.Factory
{
    public class ClienteFactory : IClienteFactory
    {
        public Cliente CriarCliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, Email email, Password password, PlanoEnum plano, Guid usuarioId, Usuario usuario)
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

            if (string.IsNullOrEmpty(estado))
                throw new ArgumentException("O estado do endereço do cliente é obrigatório.", nameof(estado));

            if (string.IsNullOrEmpty(telefone))
                throw new ArgumentException("O telefone do cliente é obrigatório.", nameof(telefone));

            if (email == null)
                throw new ArgumentNullException(nameof(email));

            if (password == null)
                throw new ArgumentNullException(nameof(password));

            if (usuario == null)
                throw new ArgumentNullException(nameof(usuario));


            var endereco = Endereco.Create(logradouro, numero, complemento, bairro, cidade, estado, cep);


            return new Cliente(nome, endereco, telefone, email, password, plano, usuarioId, usuario);
        }
    }
}