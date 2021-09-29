using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        /// <summary>
        /// Cadastra um novo usuario
        /// </summary>
        /// <param name="usuario">dados do usuario</param>
        void Adicionar(Usuario usuario);

        /// <summary>
        /// Atualiza um usuario
        /// </summary>
        /// <param name="usuario">dados do usuario atualizado</param>
        void Alterar(Usuario usuario);

        /// <summary>
        /// Altera somente a senha do usuario
        /// </summary>
        /// <param name="usuario">senha nova do usuario</param>
        void AlterarSenha(Usuario usuario);

        /// <summary>
        /// Busca um usuario por email
        /// </summary>
        /// <param name="email">email do usuario buscado</param>
        /// <returns>dados desse usuario</returns>
        Usuario BuscarPorEmail(string email);

        /// <summary>
        /// busca um usuario por Id
        /// </summary>
        /// <param name="id">Id do usuario buscado</param>
        /// <returns>Dados do usuario buscado</returns>
        Usuario BuscarPorId(Guid id);

        /// <summary>
        /// lista de usuarios ativos
        /// </summary>
        /// <param name="ativo"></param>
        /// <returns></returns>
        ICollection<Usuario> Listar(bool? ativo = null);
    }
}
