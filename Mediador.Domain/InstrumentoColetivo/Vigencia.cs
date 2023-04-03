using Mediador.Domain.BaseEntity;

namespace Mediador.Domain.InstrumentoColetivo
{
    public class Vigencia: Entity<Guid>
    {
        public string DataInicio { get; set; }
        public string DataFim { get; set; }
        public ConvencaoColetiva ConvencaoColetivaId { get; set; }
        public ConvencaoColetiva ConvencaoColetiva { get; set; }
        protected Vigencia()
        {

        }
    }
}
