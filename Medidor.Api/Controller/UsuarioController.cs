using AutoMapper;
using Mediador.Application.Dtos;
using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.Repository;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mediador.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public UsuarioController(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }


        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entidade = await _usuarioRepository.GetAll();
            return Ok(entidade);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entidade = await _usuarioRepository.Get(id);
            if (entidade == null)
            {
                return NotFound();
            }
            var dto = mapper.Map<UsuarioDto>(entidade);
            return Ok(dto);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UsuarioDto dto)
        {
            if (dto == null)
            {
                return BadRequest();
            }

            var entidade = mapper.Map<Usuario>(dto);

            await _usuarioRepository.Save(entidade);

            var responseDto = mapper.Map<UsuarioDto>(entidade);
            return CreatedAtAction(nameof(Get), new { id = entidade.Id }, responseDto);
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] UsuarioDto dto)
        {
            if (id == null || dto == null || id != dto.Id)
            {
                return BadRequest();
            }

            var entidade = await _usuarioRepository.Get(id);
            if (entidade == null)
            {
                return NotFound();
            }

            mapper.Map(dto, entidade);

            await _usuarioRepository.Update(entidade);

            return NoContent();
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entidade = await _usuarioRepository.Get(id);
            if (entidade == null)
            {
                return NotFound();
            }

            await _usuarioRepository.Delete(entidade);

            return NoContent();
        }
    }
}
