using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using ProjetoDDD.Domain.Entities;

namespace ProjetoDDD.Infrastruture.Data.Initializer
{
    public class UserDatabaseInitializer
    {
        public static List<ModuloAcesso> GetModulosAcesso()
        {
            var modulos = new List<ModuloAcesso>
            {
                new ModuloAcesso
                {
                    IdModulo = 1,
                    FlAtivo = true,
                    NomeMenuAcesso = "Administração",
                    NomeModulo = "Admin",
                    UrlMenu = "#",
                    DataCadastro = DateTime.Now
                },
                new ModuloAcesso
                {
                IdModulo = 2,
                FlAtivo = true,
                NomeMenuAcesso = "Cadastro",
                NomeModulo = "Cadastro",
                UrlMenu = "#",
                DataCadastro = DateTime.Now,
                IdModuloPai = 1
            },
                new ModuloAcesso
                {
                    IdModulo = 3,
                    FlAtivo = true,
                    NomeMenuAcesso = "Perfil de Usuario",
                    NomeModulo = "Perfil de Usuario",
                    UrlMenu = "#",
                    DataCadastro = DateTime.Now,
                    IdModuloPai = 2
                }
            };

            return modulos;
        }

        public static List<PerfilUsuario> GetPerfilUsuarios()
        {
            var perfis = new List<PerfilUsuario>
            {
                new PerfilUsuario
                {
                    IdPerfilUsuario = 1,
                    DataCadastro = DateTime.Now,
                    FlAdminMaster = true,
                    FlAtivo = true,
                    NomePerfil = "Administrador Master",
                    ModulosAcesso = GetModulosAcesso()
                }
            };
            return perfis;
        }
    }
}