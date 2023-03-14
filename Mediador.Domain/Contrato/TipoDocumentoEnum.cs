using System.ComponentModel;

namespace Mediador.Domain.Contrato
{
    public enum TipoDocumentoEnum
    {
        [Description("Pessoa Física")]
        Física = 0,

        [Description("Pessoa Jurídica")]
        Jurídica = 1,
    }
}
