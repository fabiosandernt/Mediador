using AutoMapper;
using Mediador.Application.Dtos;
using Mediador.Domain.JwtService.Contracts;
using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.Repository;

namespace Mediador.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper mapper;
        private readonly IJwtService _jwtService;

        public UsuarioService(
              IUsuarioRepository usuarioRepository,
              IMapper mapper,
              IJwtService jwtService
          )
        {
            this._usuarioRepository = usuarioRepository;
            this.mapper = mapper;
            _jwtService = jwtService;
        }

      
        public async Task<UsuarioDto> Atualizar(UsuarioDto dto)
        {
            if (dto.Id == null || dto.Id == Guid.Empty)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            var usuario = await _usuarioRepository.GetbyExpressionAsync(x => x.Id == dto.Id);
            if (usuario == null)
            {
                throw new Exception("Já existe um usuário cadastrado com o email informado");
            }

            if (await _usuarioRepository.AnyAsync(x => x.Email.Valor == dto.Email.Valor && x.Id != dto.Id))
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            usuario.Update(dto.Nome, dto.Email, dto.Password, dto.TipoUsuario);

            await _usuarioRepository.Update(usuario);

            return this.mapper.Map<UsuarioDto>(usuario);
        }


        public async Task<UsuarioDto> Criar(UsuarioDto dto)
        {
            if (await _usuarioRepository.AnyAsync(x => x.Email.Valor == dto.Email.Valor))
                throw new Exception("Já existe um usuário cadastrado com o email informado");

            var usuario = this.mapper.Map<Usuario>(dto);

            usuario.Validate();
            usuario.SetPassword();

            usuario.Id = Guid.NewGuid();

            await _usuarioRepository.Save(usuario);

            return this.mapper.Map<UsuarioDto>(usuario);
        }

        public async Task<UsuarioDto> Deletar(UsuarioDto dto)
        {
            var usuario = this.mapper.Map<Usuario>(dto);

            await this._usuarioRepository.Delete(usuario);

            return this.mapper.Map<UsuarioDto>(usuario);
        }

        public Task<UsuarioDto> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UsuarioDto>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task<string> ObterTokenJwtAsync(LoginDto dto)
        {
            throw new NotImplementedException();
        }
    }
}

        