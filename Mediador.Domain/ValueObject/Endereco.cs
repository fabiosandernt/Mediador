
namespace Mediador.Domain.ValueObject
{
    public class Endereco
    {
        public Endereco(string logradouro,
            string numero,
            string complemento,
            string bairro,
            string cidade,
            Estado estado,
            string cep) => (Logradouro, Numero, Complemento, Bairro, Cidade, Estado, Cep) =
            (logradouro, numero, complemento, bairro, cidade, estado, cep);

        public string Logradouro { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public Estado Estado { get; }
        public string Cep { get; }

        public static Endereco Create(string logradouro, string numero, string complemento, string bairro, string cidade, Estado estado, string cep) =>
        new Endereco(logradouro, numero, complemento, bairro, cidade, estado, cep);
                
    }

    public enum Estado
    {
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MT,
        MS,
        MG,
        PA,
        PB,
        PR,
        PE,
        PI,
        RJ,
        RN,
        RS,
        RO,
        RR,
        SC,
        SP,
        SE,
        TO
    }
}
