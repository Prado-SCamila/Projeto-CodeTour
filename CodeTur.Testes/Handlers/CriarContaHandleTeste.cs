using CodeTur.Comum.Commands;
using CodeTur.Dominio.Commands.Usuario;
using CodeTur.Dominio.Handlers.Usuarios;
using CodeTur.Testes.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes.Handlers
{
    public class CriarContaHandleTeste
    {
        [Fact]
        public void DeveRetornarCadoDadosDoHandleSejamValidos()
        {
            var command = new CriarContaCommand();
            command.Nome = "Matheus";
            command.Email = "matheus@gmail.com";
            command.Senha = "123456789";
            command.TipoUsuario = CodeTur.Comum.EnTipoUsuario.Admin;

            var handle = new CriarContaHandle(new FakeUsuarioRepositorio() );

            var resultado =  (GenericCommandResult)handle.Handler(command);

            Assert.True(resultado.Sucesso, "Usuario valido");
        }
    }
}
