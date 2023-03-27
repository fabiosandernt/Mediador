using Mediador.Domain.JwtService.Dto;
using Mediador.Domain.JwtService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediador.Domain.JwtService.Contracts
{
    public interface IJwtService
    {
        ValueTask<string> GenerateToken(JwtDto jwtDto);
        ValueTask<JwtTokenViewModel> ReadTokenAsync(string token);
    }
}
