using Mediador.Application.Dtos;
using Mediador.Application.Service;
using Mediador.Domain.Usuarios;
using Mediador.Domain.Usuarios.ValueObject;
using Mediador.Domain.Utils;

namespace Mediador.Tests
{
    public class UsuarioTests
    {
        private readonly UsuarioService _usuarioService;

        public UsuarioTests()
        {
            // Cria uma instância do serviço de usuário com as dependências injetadas
            _usuarioService = new UsuarioService();
        }

        [Fact]
        public async Task CriarUsuario_ComSucesso()
        {
            // Arrange
            var nome = "João";
            var email = new Email("joao@teste.com");
            var password = new Password("123456");
            var tipoUsuario = TipoUsuarioEnum.Cliente;
            var usuarioDto = new UsuarioDto { Nome = nome, Email = email, Password = password, TipoUsuario = tipoUsuario };

            // Act
            var usuarioCriado = await _usuarioService.Criar(usuarioDto);

            // Assert
            Assert.NotNull(usuarioCriado);
            Assert.Equal(nome, usuarioCriado.Nome);
            Assert.Equal(email.Valor, usuarioCriado.Email.Valor);
            Assert.Equal(SecurityUtils.HashSHA1(password.Valor), usuarioCriado.Password.Valor);
            Assert.Equal(tipoUsuario, usuarioCriado.TipoUsuario);
        }

        [Fact]
        public async Task AtualizarUsuario_ComSucesso()
        {
            // Arrange
            var nome = "João";
            var email = new Email("joao@teste.com");
            var password = new Password("123456");
            var tipoUsuario = TipoUsuarioEnum.Cliente;
            var usuarioDto = new UsuarioDto { Nome = nome, Email = email, Password = password, TipoUsuario = tipoUsuario };
            var usuarioCriado = await _usuarioService.Criar(usuarioDto);

            var novoNome = "João da Silva";
            var novoEmail = new Email("joaosilva@teste.com");
            var novoPassword = new Password("654321");
            var novoTipoUsuario = TipoUsuarioEnum.Cliente;
            usuarioCriado.Nome = novoNome;
            usuarioCriado.Email = novoEmail;
            usuarioCriado.Password = novoPassword;
            usuarioCriado.TipoUsuario = novoTipoUsuario;

            // Act
            var usuarioAtualizado = await _usuarioService.Atualizar(usuarioCriado);

            // Assert
            Assert.NotNull(usuarioAtualizado);
            Assert.Equal(novoNome, usuarioAtualizado.Nome);
            Assert.Equal(novoEmail.Valor, usuarioAtualizado.Email.Valor);
            Assert.Equal(SecurityUtils.HashSHA1(novoPassword.Valor), usuarioAtualizado.Password.Valor);
            Assert.Equal(novoTipoUsuario, usuarioAtualizado.TipoUsuario);
        }

    }
}
