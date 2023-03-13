using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.Usuario
{
    public enum TipoUsuarioEnum : int
    {
        [Description("Administrador")]
        Administrador = 1,

        [Description("Funcionário")]
        Funcionário = 2,

        [Description("Cliente")]
        Cliente = 3,
    }
}
