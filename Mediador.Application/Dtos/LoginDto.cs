using MediatR;

namespace Mediador.Application.Dtos
{
    public class LoginDto : IRequest<string>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
