using Mediador.Application.Dtos;
using Mediador.Domain.Utils;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Mediador.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Token([FromBody] LoginDto dto)
        {
            if (dto is null) return UnprocessableEntity();

            try
            {
                var result = await _mediator.Send(dto);

                if (string.IsNullOrWhiteSpace(result))
                    return Unauthorized("Usuário ou senha inválidos");

                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(new ApiResponseError(e.Message));
            }
        }
    }

}
