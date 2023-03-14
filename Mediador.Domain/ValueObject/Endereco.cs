
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (Endereco)obj;

            return Logradouro == other.Logradouro
                && Numero == other.Numero
                && Complemento == other.Complemento
                && Bairro == other.Bairro
                && Cidade == other.Cidade
                && Estado == other.Estado
                && Cep == other.Cep;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = hash * 16777619 ^ Logradouro?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ Numero?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ Complemento?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ Bairro?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ Cidade?.GetHashCode() ?? 0;
                hash = hash * 16777619 ^ Estado.GetHashCode();
                hash = hash * 16777619 ^ Cep?.GetHashCode() ?? 0;
                return hash;
            }
        }
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
