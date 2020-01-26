using System;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;

namespace ProjetoDDD.Domain.Services
{
    public class ServicePerfilUsuarioDomain : IServicePerfilUsuarioDomain
    {
        private readonly IRepositorioPerfilDeUsuario _repositorioPerfilDeUsuario;

        public ServicePerfilUsuarioDomain(IRepositorioPerfilDeUsuario repositorioPerfilDeUsuario)
        {
            _repositorioPerfilDeUsuario = repositorioPerfilDeUsuario;
        }
        public List<Usuario> RetornaUsuariosDoPerfil(int idPerfilUsuario)
        {
            try
            {
                var usuariosDoPerfil = _repositorioPerfilDeUsuario.RetornaUsuariosDoPerfil(idPerfilUsuario);
                return usuariosDoPerfil;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}