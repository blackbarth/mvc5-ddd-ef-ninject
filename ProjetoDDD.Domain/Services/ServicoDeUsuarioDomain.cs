using System;
using System.Collections.Generic;
using ProjetoDDD.Domain.Entities;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;

namespace ProjetoDDD.Domain.Services
{
    public class ServicoDeUsuarioDomain : IServicoDeUsuarioDomain
    {
        private readonly IRepositorioDeUsuario _repopositorioUsuario;
        private readonly IRepositorioPerfilDeUsuario _repositorioPerfilDeUsuario;

        public ServicoDeUsuarioDomain(IRepositorioDeUsuario repopositorioUsuario, IRepositorioPerfilDeUsuario repositorioPerfilDeUsuario)
        {
            _repopositorioUsuario = repopositorioUsuario;
            _repositorioPerfilDeUsuario = repositorioPerfilDeUsuario;

        }
        public Usuario LogaUsuario(string email, string senha)
        {

            try
            {
                //implementar regras aqui
                var usuarioRetorno = _repopositorioUsuario.LogaUsuario(email, senha);
                return usuarioRetorno;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Usuario RecuperaUsuarioPorEmail(string email)
        {
            try
            {
                //regras aqui
                var usuarioRetorno = _repopositorioUsuario.RecuperaUsuarioPorEmail(email);
                return usuarioRetorno;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<Usuario> RecuperaUsuariosDoPerfil(int IdPerfilUsuario)
        {
            try
            {
                var listUsuario = _repositorioPerfilDeUsuario.RetornaUsuariosDoPerfil(IdPerfilUsuario);
                return listUsuario;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}