using AutoMapper;
using Mediador.Application.Dtos;
using Mediador.Domain.JwtService.Contracts;
using Mediador.Domain.JwtService.Dto;
using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.Repository;

namespace Mediador.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IMapper _mapper;
        private readonly IJwtService _jwtService;

        public UsuarioService(
              IUsuarioRepository usuarioRepository,
              IMapper mapper,
              IJwtService jwtService
          )
        {
            _usuarioRepository = usuarioRepository;
            _mapper = mapper;
            _jwtService = jwtService;
        }

      
        public async Task<UsuarioDto> Atualizar(UsuarioDto dto)
        {
            if (dto.Id == null || dto.Id == Guid.Empty)
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            var usuario = await _usuarioRepository.GetByIdAsync(dto.Id);
            if (usuario == null)
            {
                throw new Exception("Já existe um usuário cadastrado com o email informado");
            }

            if (await _usuarioRepository.AnyAsync(x => x.Email.Valor == dto.Email.Valor && x.Id != dto.Id))
            {
                throw new ArgumentException("Usuário não encontrado.");
            }

            usuario.Update(dto.Nome, dto.Email, dto.Password, dto.TipoUsuario);

            await _usuarioRepository.UpdateAsync(usuario);

            return this._mapper.Map<UsuarioDto>(usuario);
        }


        public async Task<UsuarioDto> Criar(UsuarioDto dto)
        {
            if (await _usuarioRepository.AnyAsync(x => x.Email.Valor == dto.Email.Valor))
                throw new Exception("Já existe um usuário cadastrado com o email informado");

            var usuario = this._mapper.Map<Usuario>(dto);

            usuario.Validate();
            usuario.SetPassword();

            usuario.Id = Guid.NewGuid();

            await _usuarioRepository.AddAsync(usuario);

            return this._mapper.Map<UsuarioDto>(usuario);
        }

        public async Task<UsuarioDto> Deletar(UsuarioDto dto)
        {
            var usuario = this._mapper.Map<Usuario>(dto);

            await this._usuarioRepository.RemoveAsync(usuario);

            return this._mapper.Map<UsuarioDto>(usuario);
        }

        public async Task<UsuarioDto> ObterPorId(Guid id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);
            return this._mapper.Map<UsuarioDto>(usuario);
        }

        public async Task<List<UsuarioDto>> ObterTodos()
        {
            var usuario = await this._usuarioRepository.GetAllAsync();

            return this._mapper.Map<List<UsuarioDto>>(usuario);
        }

        public async Task<string> ObterTokenJwtAsync(LoginDto dto)
        {
            var usuario = await _usuarioRepository.GetSingleAsync(x => x.Email.Valor == dto.Email && x.Password.Valor == dto.Password);
            if (usuario is null) throw new Exception("Usuário não encontrado");

            return await _jwtService.GenerateToken(new JwtDto(usuario.Id, usuario.Email?.Valor));
        }
    }
}

        