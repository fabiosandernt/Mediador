using FluentValidation;
using Mediador.Domain.BaseEntity;
using Mediador.Domain.Contrato;
using Mediador.Domain.Utils;
using Mediador.Domain.Validator;
using Mediador.Domain.ValueObject;

namespace Mediador.Domain.Usuario
{
    public class User: Entity<Guid>
    {
        public string Nome { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public TipoUsuarioEnum TipoUsuario { get; private set; }
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
        public User(string nome, Email email, Password password, TipoUsuarioEnum tipoUsuario)
        {
            Nome = nome;
            Email = email;
            Password = password;
            TipoUsuario = tipoUsuario;
        }

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
