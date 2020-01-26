using System.Collections.Generic;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;

namespace ProjetoDDD.Infrastruture.Data.Repositories
{
    public class RepositorioDePerfilDeUsuario : RepositorioBase<PerfilUsuario>, IRepositorioPerfilDeUsuario
    {
        public List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario)
        {
            var perfil = _context.PerfilUsuario.Where(p => p.IdPerfilUsuario == idPerfilUsuario).FirstOrDefault();
            return perfil.Usuarios.ToList();
        }
    }
}