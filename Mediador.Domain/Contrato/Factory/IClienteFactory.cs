using Mediador.Domain.Usuario;
using Mediador.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.Contrato.Factory
{
    public interface IClienteFactory
    {
        Cliente CriarCliente(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, Email email, Password password, TipoPlanoEnum plano, TipoDocumentoEnum documento, 
            Guid userId, User user);
    }
}
