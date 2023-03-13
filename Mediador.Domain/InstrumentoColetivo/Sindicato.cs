using Mediador.Domain.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.InstrumentoColetivo
{
    public class Sindicatos : Entity<Guid>
    {
        public TipoSindicatoEnum TipoSindicato { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
    }
}
