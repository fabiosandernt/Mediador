using FluentValidation;
using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes;
using Mediador.Domain.Usuario.Rules;
using Mediador.Domain.Usuario.ValueObject;
using Mediador.Domain.Utils;

namespace Mediador.Domain.Usuario
{
    public class Usuario: Entity<Guid>
    {
        public string Nome { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public TipoUsuarioEnum TipoUsuario { get; private set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
        public Usuario(string nome, Email email, Password password, TipoUsuarioEnum tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Password = password;
            TipoUsuario = tipoUsuario;
        }
        //Para o EF
        protected Usuario() { }

        public void SetPassword()
        {
            Password.Valor = SecurityUtils.HashSHA1(Password.Valor);
        }

        public void Validate() =>
            new UsuarioValidator().ValidateAndThrow(this);

        public void Update(string nome, Email email, Password password, TipoUsuarioEnum tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Password = password;
            TipoUsuario = tipoUsuario;
        }        
        
    }
}
