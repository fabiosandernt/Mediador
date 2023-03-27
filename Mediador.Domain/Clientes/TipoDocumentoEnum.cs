using System.ComponentModel;

namespace Mediador.Domain.Clientes
{
    public enum TipoDocumentoEnum
    {
        [Description("Pessoa Física")]
        Física = 0,

        [Description("Pessoa Jurídica")]
        Jurídica = 1,
    }
}
