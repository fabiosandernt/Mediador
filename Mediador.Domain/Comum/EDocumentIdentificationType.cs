
using System.ComponentModel;

namespace Mediador.Domain.Comum
{
    public enum EDocumentIdentificationType
    {
        [Description("CPF")]
        Cpf = 1,

        [Description("CNPJ")]
        Cnpj = 2
    }
}
