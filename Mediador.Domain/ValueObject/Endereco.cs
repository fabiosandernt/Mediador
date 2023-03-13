
namespace Mediador.Domain.ValueObject
{
    public readonly struct Endereco
    {
        public Endereco(string logradouro,
            string numero,
            string complemento,
            string bairro,
            string cidade,
            string estado,
            string cep) => (Logradouro, Numero, Complemento, Bairro, Cidade, Estado, Cep) =
            (logradouro, numero, complemento, bairro, cidade, estado, cep);

        public string Logradouro { get; }
        public string Numero { get; }
        public string Complemento { get; }
        public string Bairro { get; }
        public string Cidade { get; }
        public string Estado { get; }
        public string Cep { get; }

        public static Endereco Create(string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep) =>
        new Endereco(logradouro, numero, complemento, bairro, cidade, estado, cep);

    }
}
