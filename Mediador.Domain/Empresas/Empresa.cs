using Mediador.Domain.BaseEntity;
using Mediador.Domain.Clientes;
using Mediador.Domain.Usuarios;

namespace Mediador.Domain.Empresas
{
    public class Empresa : Entity<Guid>
    {

        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }    
        
    }
}
