using Mediador.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.InstrumentoColetivo
{
    public class ConvencaoColetiva: Entity<Guid>
    {
        public string NumeroRegistro { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroSolicitacao { get; set; }
        public string SindicatoTrabalhador { get; set; }
        public string SindicatoPatronal { get; set; }
        public string TipoInstrumentoColetivo { get; set; }
        public ICollection<Vigencia> Vigencias { get; set; }
    }
}
