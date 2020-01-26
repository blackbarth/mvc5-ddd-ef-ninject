using CommonServiceLocator;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Infrastruture.Data.Context;

namespace ProjetoDDD.Infrastruture.Data.Configuration
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private ContextoBanco _contexto;
        public void Iniciar()
        {
            var gerenciador = ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>()
                as GerenciadorDeRepositorio;

            _contexto = gerenciador.Contexto;
        }

        public void Persistir()
        {
            _contexto.SaveChanges();
        }
    }
}