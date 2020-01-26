using System;
using System.Linq;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Infrastruture.Data.Security;

namespace ProjetoDDD.Infrastruture.Data.Repositories
{
    public class RepositorioDeUsuario : RepositorioBase<Usuario>, IRepositorioDeUsuario
    {
        public Usuario RecuperaUsuarioPorEmail(string email)
        {
            try
            {
                var usuario = _context.Usuarios.Where(p => p.Email == email).FirstOrDefault();
                return usuario;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Usuario LogaUsuario(string email, string senha)
        {
            try
            {
                var usuario = _context.Usuarios.Where(p => p.Email == email).FirstOrDefault();

                if (usuario == null)
                    return null;

                string passDecrypt = Crypto.DecryptStringAES(usuario.Senha, usuario.SenhaKey);


                if (passDecrypt == senha)
                    return usuario;
                else
                    return null;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}