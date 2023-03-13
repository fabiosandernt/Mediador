using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
