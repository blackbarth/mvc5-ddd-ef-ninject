using CommonServiceLocator;
using CommonServiceLocator.SimpleInjectorAdapter;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Infrastruture.Data.Configuration;
using ProjetoDDD.Infrastruture.Data.Repositories;
using SimpleInjector;

namespace ProjetoDDD.Infrastruture.IoC
{
    /*
     * Instalar alguns pacotes nuget
     * Install-Package SimpleInjector
     * Install-Package CommonServiceLocator
     * Install-Package CommonServiceLocator.SimpleInjectorAdapter
     */
    public class Bindings
    {
        public static void Start(Container container)
        {
            //Infraestrutura
            container.Register<IGerenciadorDeRepositorio, GerenciadorDeRepositorio>();
            container.Register<IUnidadeDeTrabalho, UnidadeDeTrabalho>();
            container.Register(typeof(IRepositorioBase<>),typeof(RepositorioBase<>), Lifestyle.Scoped);
            container.Register(typeof(IRepositorioPerfilDeUsuario),typeof(RepositorioDePerfilDeUsuario), Lifestyle.Scoped);
            container.Register(typeof(IRepositorioPerfilDeUsuario),typeof(RepositorioDePerfilDeUsuario), Lifestyle.Scoped);

            //Dominio
            container.Register(typeof(IServicePerfilUsuarioDomain),typeof(IServicePerfilUsuarioDomain),Lifestyle.Scoped);


            //Aplicacao
            //todo

            //Service Locator
            //ServiceLocator.SetLocatorProvider(() => new SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}