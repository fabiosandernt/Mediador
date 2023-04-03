
using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes.ValueObject;
using Mediador.Domain.Comum;
using Mediador.Domain.Empresas;
using Mediador.Domain.Planos;
using Mediador.Domain.Usuarios.ValueObject;
using Mediador.Domain.Usuarios;
using Mediador.Domain.ValueObject;

namespace Mediador.Domain.Clientes
{
    public class Cliente: Entity<Guid>
    {
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Telefone { get; private set; }
        public DocumentoIdentificacao Documento { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public Guid PlanoId { get; private set; }
        public Plano Plano { get; set; }
        public Guid UserId { get; private set; }
        public Usuario Usuario { get; private set; }
        public ICollection<Pagamento> Pagamentos { get; private set; }
        public ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

        //Para O EF
        protected Cliente() { }
        public Cliente(string nome, Endereco endereco, string telefone, DocumentoIdentificacao documento, Email email, Password password,
            Plano plano, Guid userId, Usuario usuario)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Documento = documento;
            Email = email;
            Password = password;
            Plano = plano;           
            UserId = userId;
            Usuario = usuario;
        }

        // Sobrecarga do construtor para permitir que o VO de endereço seja fornecido separadamente
        public Cliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, EstadoEnum estado, 
            string cep, string telefone, DocumentoIdentificacao documento, Email email, Password password,
            Plano plano,  Guid usuarioId, Usuario usuario)
            
            : this(nome, Endereco.Create(logradouro, numero, complemento, bairro, cidade, estado, cep), telefone, documento, email, password, plano,  usuarioId, usuario)
        {

        }
    }
}
