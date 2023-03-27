
using System.ComponentModel;


namespace Mediador.Domain.Usuarios 
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
