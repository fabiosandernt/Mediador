using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Mediador.Domain.ValueObject
{
    public sealed class DocumentoIdentificacao
    {
        private const string TipoCpf = "Cpf";
        private const string TipoCnpj = "Cnpj";

        public string Numero { get; set; }

        [JsonIgnore]
        public bool EhValido;

        [JsonIgnore]
        public string DescricaoTipo;

        public DocumentoIdentificacao(string numero)
        {
            Build(numero);
        }

        private void Build(string numero)
        {
            numero ??= "";
            numero = Regex.Replace(numero, @"[^0-9]", "");

            Numero = numero;

            switch (numero.Length)
            {
                case 14:
                {
                    EhValido = new Cnpj(Numero).IsValid;
                    DescricaoTipo = TipoCnpj;
                    break;
                }
                case 11:
                {
                    EhValido = new Cpf(Numero).IsValid;
                    DescricaoTipo = TipoCpf;
                    break;
                }
                default:
                {
                    EhValido = false;
                    return;
                }   
            }
        }
    

        public static implicit operator DocumentoIdentificacao(string value) => new(value);

        public override string ToString() => Numero;

        public string Formatado
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Numero)) return string.Empty;

                var number = Regex.Replace(Numero, @"[^0-9]", string.Empty);

                switch (number.Length)
                {
                    case 14:
                        return new Cnpj(number).Formatted;
                    case 11:
                        return new Cpf(number).Formatted;
                    default:
                        return string.Empty;
                }
            }
        }

        public DocumentoIdentificacao Editar(string numero)
        {
            if (EhValido && Numero == numero) return this;

            Build(numero);

            return this;
        }
    }
}
