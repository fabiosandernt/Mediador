using Mediador.Domain.BaseEntity;
using Mediador.Domain.Empresas;

namespace Mediador.Domain.InstrumentoColetivo
{
    public class Sindicato : Entity<Guid>
    {
        public TipoSindicatoEnum TipoSindicato { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public ICollection<ConvencaoColetiva> ConvencaoColetivas { get; set;}
        public ICollection<Empresa> Empresas { get; set; }
        protected Sindicato()
        {

        }
    }
}
