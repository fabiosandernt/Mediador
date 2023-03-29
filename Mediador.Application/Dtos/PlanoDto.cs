using Mediador.Domain.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Application.Dtos
{
    public class PlanoDto
    {
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }
        public ICollection<ClienteDto> Clientes { get; set; } = new List<ClienteDto>(0);
    }
}
