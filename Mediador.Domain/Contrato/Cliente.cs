﻿using Mediador.Domain.BaseEntity;
using Mediador.Domain.Usuario;
using Mediador.Domain.ValueObject;

namespace Mediador.Domain.Contrato
{
    public class Cliente: Entity<Guid>
    {
        public string Nome { get; private set; }
        public Endereco Endereco { get; }
        public string Telefone { get; private set; }
        public Email Email { get; private set; }
        public Password Password { get; private set; }
        public TipoPlanoEnum Plano { get; set; }
        public TipoDocumentoEnum Documento { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Cliente(string nome, Endereco endereco, string telefone, Email email, Password password, TipoPlanoEnum plano, TipoDocumentoEnum documento, Guid userId, User user)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
            Password = password;
            Plano = plano;
            Documento = documento;
            UserId = userId;
            User = user;
        }

        // Sobrecarga do construtor para permitir que o VO de endereço seja fornecido separadamente
        public Cliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, 
            string cep, string telefone, Email email, Password password, TipoPlanoEnum plano, TipoDocumentoEnum documento, Guid userId, User user)
            
            : this(nome, Endereco.Create(logradouro, numero, complemento, bairro, cidade, estado, cep), telefone, email, password, plano, documento, userId, user)
        {

        }
    }
}
