using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioDeUsuario : IRepositorioBase<Usuario>
    {
        Usuario RecuperaUsuarioPorEmail(string email);
        Usuario LogaUsuario(string email, string senha);
    }
}