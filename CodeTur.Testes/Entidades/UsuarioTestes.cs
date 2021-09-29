using CodeTur.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeTur.Testes
{
    
    public class UsuarioTestes
    {
        [Fact]
        public void DeveRetornarSeUsuarioForValido()
        {
            Usuario usuario = new Usuario(
                "Matheus",
                "Matheus@gmail.com",
                "123456789",
                CodeTur.Comum.EnTipoUsuario.Admin
            );

            Assert.True(usuario.IsValid, "Usuario valido");
        }

        [Fact]
        public void DeveRetornarSeUsuarioForInvalido()
        {
            Usuario usuario = new Usuario(
                "Matheus",
                "Matheus",
                "123456789",
                CodeTur.Comum.EnTipoUsuario.Admin
            );

            Assert.True(!usuario.IsValid, "Usuario invalido sem email");
        }

        [Fact]
        public void DeveRetornarSeUsuarioForInvalidoComSenhaFraca()
        {
            Usuario usuario = new Usuario(
                "Matheus",
                "Matheus@gmail.com",
                "123",
                CodeTur.Comum.EnTipoUsuario.Admin
            );

            Assert.True(!usuario.IsValid, "Usuario invalido com senha fraca");
        }

    }
}
