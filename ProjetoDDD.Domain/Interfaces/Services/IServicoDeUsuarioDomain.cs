using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Domain.Interfaces.Services
{
    public interface IServicoDeUsuarioDomain
    {
        Usuario LogaUsuario(string email, string senha);
        Usuario RecuperaUsuarioPorEmail(string email);
        List<Usuario> RecuperaUsuariosDoPerfil(int IdPerfilUsuario);
    }
}