﻿using FluentValidation;
using Mediador.Domain.Usuario.ValueObject;
using System.Text.RegularExpressions;

namespace Mediador.Domain.Validator
{
    public class PasswordValidator : AbstractValidator<Password>
    {
        private const string Pattern = @"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$";

        public PasswordValidator()
        {
            RuleFor(x => x.Valor)
                .NotEmpty()
                .Must(BeValidPassword).WithMessage("A Senha deve ter no mínimo 8 caracteres, uma letra, um caracter especial e um número");
        }

        private bool BeValidPassword(string valor) => Regex.IsMatch(valor, Pattern);
    }
}
