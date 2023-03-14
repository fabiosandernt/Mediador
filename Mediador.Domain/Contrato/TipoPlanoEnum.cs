using System.ComponentModel;

namespace Mediador.Domain.Contrato
{
    public enum TipoPlanoEnum
    {
        [Description("Basico")]
        Basico = 0,

        [Description("Premium")]
        Premium = 1,

        [Description("Vip")]
        Vip = 2,
    }
}
