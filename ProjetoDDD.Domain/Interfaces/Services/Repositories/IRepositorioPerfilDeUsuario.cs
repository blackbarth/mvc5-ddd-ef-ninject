using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioPerfilDeUsuario : IRepositorioBase<PerfilUsuario>
    {
        List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario);

    }
}