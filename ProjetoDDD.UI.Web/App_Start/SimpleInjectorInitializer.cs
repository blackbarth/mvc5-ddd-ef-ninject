

using System.Reflection;
using System.Web.Mvc;
using ProjetoDDD.Infrastruture.IoC;
using ProjetoDDD.UI.Web;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using WebActivator;

[assembly: PostApplicationStartMethod(typeof(SimpleInjectorInitializer), "Initialize")]
namespace ProjetoDDD.UI.Web
{
    /*
     * Nuget
     * Install-Package SimpleInjector
     * Install-Package SimpleInjector.Integration.Web
     * Install-Package Simpleinjector.Integration.Web.Mvc
     * Install-Package WebActivator -version 1.5.3
     */
    public class SimpleInjectorInitializer
    {
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            //chamada dos modulos do simple Injector
            InitializeContainer(container);
            container.RegisterMvcControllers((Assembly.GetExecutingAssembly()));
            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));

        }

        private static void InitializeContainer(Container container)
        {
            Bindings.Start(container);
        }
    }
}