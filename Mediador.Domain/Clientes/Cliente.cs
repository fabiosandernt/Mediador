
using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes.ValueObject;
using Mediador.Domain.Usuario;
using Mediador.Domain.Usuario.ValueObject;

namespace Mediador.Domain.Clientes
{
    public class Cliente: Entity<Guid>
    {
        public string Nome { get; private set; }
        public Endereco Endereco { get; }
        public string Telefone { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public TipoPlanoEnum Plano { get; set; }
        public TipoDocumentoEnum TipoDocumento { get; set; }
        public Guid UserId { get; set; }
        public Usuario.Usuario Usuario { get; set; }

        //Para O EF
        protected Cliente() { }
        public Cliente(string nome, Endereco endereco, string telefone, Documento documento, Email email, Password password,
            TipoPlanoEnum plano, TipoDocumentoEnum tipoDocumento, Guid userId, Usuario.Usuario usuario)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Documento = documento;
            Email = email;
            Password = password;
            Plano = plano;
            TipoDocumento = tipoDocumento;
            UserId = userId;
            Usuario = usuario;
        }

        // Sobrecarga do construtor para permitir que o VO de endereço seja fornecido separadamente
        public Cliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, Estado estado, 
            string cep, string telefone, Documento documento, Email email, Password password,
            TipoPlanoEnum plano, TipoDocumentoEnum tipoDocumento, Guid usuarioId, Usuario.Usuario usuario)
            
            : this(nome, Endereco.Create(logradouro, numero, complemento, bairro, cidade, estado, cep), telefone, documento, email, password, plano, tipoDocumento, usuarioId, usuario)
        {

        }
    }
}
