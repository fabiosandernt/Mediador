using System.ComponentModel.DataAnnotations;

namespace Mediador.Domain.Clientes.ValueObject
{
    public class Documento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Valor
        {
            get => _valor;
            private set => _valor = value;
        }

        private string _valor;

        public bool IsValidCPF { get; private set; }
        public bool IsValidCNPJ { get; private set; }

        protected Documento() { }
        public Documento(string valor)
        {
            Valor = valor;
            IsValidCPF = ValidateCPF(valor);
            IsValidCNPJ = ValidateCNPJ(valor);
        }

        private bool ValidateCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || cpf.Distinct().Count() == 1)
            {
                return false;
            }

            string tempCPF = cpf.Substring(0, 9);
            int sum = 0;

            for (int i = 0; i < 9; i++)
            {
                sum += int.Parse(tempCPF[i].ToString()) * (10 - i);
            }

            int remainder = sum % 11;

            if (remainder < 2)
            {
                remainder = 0;
            }
            else
            {
                remainder = 11 - remainder;
            }

            if (remainder != int.Parse(cpf[9].ToString()))
            {
                return false;
            }

            tempCPF += remainder.ToString();
            sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum += int.Parse(tempCPF[i].ToString()) * (11 - i);
            }

            remainder = sum % 11;

            if (remainder < 2)
            {
                remainder = 0;
            }
            else
            {
                remainder = 11 - remainder;
            }

            if (remainder != int.Parse(cpf[10].ToString()))
            {
                return false;
            }

            return true;
        }

        private bool ValidateCNPJ(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14 || cnpj.Distinct().Count() == 1)
            {
                return false;
            }

            string tempCNPJ = cnpj.Substring(0, 12);
            int[] multipliers = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum = 0;

            for (int i = 0; i < 12; i++)
            {
                sum += int.Parse(tempCNPJ[i].ToString()) * multipliers[i];
            }

            int remainder = sum % 11;

            if (remainder < 2)
            {
                remainder = 0;
            }
            else
            {
                remainder = 11 - remainder;
            }

            if (remainder != int.Parse(cnpj[12].ToString()))
            {
                return false;
            }

            tempCNPJ += remainder.ToString();
            multipliers = new int[] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            sum = 0;

            for (int i = 0; i < 13; i++)
            {
                sum += int.Parse(tempCNPJ[i].ToString()) * multipliers[i];
            }

            remainder = sum % 11;

            if (remainder < 2)
            {
                remainder = 0;
            }
            else
            {
                remainder = 11 - remainder;
            }
            if (remainder != int.Parse(cnpj[13].ToString()))
            {
                return false;
            }

            return true;
        }
    }
}
