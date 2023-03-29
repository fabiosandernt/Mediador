

namespace Mediador.Domain.Planos.Factory
{
    public class PlanoFactory : IPlanoFactory
    {
        public static Plano Criar(string nome, bool ativoOuInativo, string motivoDesativacao, bool pagamentoRealizado)
        {
            var plano = new Plano(nome, ativoOuInativo, motivoDesativacao, pagamentoRealizado);

            //Adicionar Logica de criação de plano

            if (!plano.PagamentoRealizado)
            {
                return null;
            }

            return plano;
        }
    }
}
