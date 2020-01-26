using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Domain.Interfaces.Services
{
    public interface IServicePerfilUsuarioDomain
    {
        List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario);
    }
}