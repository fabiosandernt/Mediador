using FluentValidation;
using Mediador.Domain.Usuario;

namespace Mediador.Domain.Validator
{
    public class UsuarioValidator : AbstractValidator<User>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Nome).NotEmpty();
            RuleFor(x => x.Email).SetValidator(new EmailValidator());
            RuleFor(x => x.Password).SetValidator(new PasswordValidator());

        }
    }
}
