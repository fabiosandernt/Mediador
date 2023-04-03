using Mediador.Domain.BaseEntity;

namespace Mediador.Domain.InstrumentoColetivo
{
    public class ConvencaoColetiva: Entity<Guid>
    {
        public ConvencaoColetiva(string numeroRegistro, string numeroProcesso, string numeroSolicitacao, string nomeSindicatoTrabalhador, string nomeSindicatoPatronal, string tipoConvencaoColetivo)
        {
            NumeroRegistro = numeroRegistro;
            NumeroProcesso = numeroProcesso;
            NumeroSolicitacao = numeroSolicitacao;
            NomeSindicatoTrabalhador = nomeSindicatoTrabalhador;
            NomeSindicatoPatronal = nomeSindicatoPatronal;
            DefinirTipoConvencaoColetivo(tipoConvencaoColetivo);
        }

        public string NumeroRegistro { get; set; }
        public string NumeroProcesso { get; set; }
        public string NumeroSolicitacao { get; set; }
        public string NomeSindicatoTrabalhador { get; set; }
        public string NomeSindicatoPatronal { get; set; }
        public string TipoConvencaoColetivo { get; set; }
        public ICollection<Vigencia> Vigencias { get; set; }
        public ICollection<Sindicato> Sindicatos { get;set; }

        public void DefinirTipoConvencaoColetivo(string tipoConvencaoColetivo)
        {
            if (tipoConvencaoColetivo == "TipoPatronal" || tipoConvencaoColetivo == "TipoEmpregados")
            {
                TipoConvencaoColetivo = tipoConvencaoColetivo;
            }
            else
            {
                throw new ArgumentException("O tipo de convenção coletiva deve ser TipoPatronal ou TipoEmpregados");
            }
        }
        protected ConvencaoColetiva()
        {

        }
    }
}
