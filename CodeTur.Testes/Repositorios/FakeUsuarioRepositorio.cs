using CodeTur.Dominio;
using CodeTur.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Testes.Repositorios
{
    public class FakeUsuarioRepositorio : IUsuarioRepositorio
    {
        public void Adicionar(Usuario usuario)
        {
            
        }

        public void Alterar(Usuario usuario)
        {
           
        }

        public void AlterarSenha(Usuario usuario)
        {
            
        }

        public Usuario BuscarPorEmail(string email)
        {
            return null;
        }

        public Usuario BuscarPorId(Guid id)
        {
            return new Usuario("Priscila", "pri@email.com", "123456789", CodeTur.Comum.EnTipoUsuario.Admin);
        }

        public ICollection<Usuario> Listar(bool? ativo = null)
        {
            return new List<Usuario>()
            {
                new Usuario("Priscila", "pri@email.com", "123456789", CodeTur.Comum.EnTipoUsuario.Admin),
                new Usuario("matheus", "matheus@email.com", "123456789", CodeTur.Comum.EnTipoUsuario.Admin)
            };
        }
    }
}
