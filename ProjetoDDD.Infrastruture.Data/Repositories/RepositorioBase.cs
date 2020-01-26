using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CommonServiceLocator;
using ProjetoDDD.Domain.Interfaces;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Infrastruture.Data.Configuration;
using ProjetoDDD.Infrastruture.Data.Context;

/*  Intalar pacote nuget
 *  CommonServiceLocator
 */
namespace ProjetoDDD.Infrastruture.Data.Repositories
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        protected readonly ContextoBanco _context;

        public RepositorioBase()
        {
            //Instalar pacote nuget CommonServiceLocator
            var gerenciador =
                (GerenciadorDeRepositorio)ServiceLocator.Current.GetInstance<IGerenciadorDeRepositorio>();
            _context = gerenciador.Contexto;
        }
        public IList<TEntity> RecuperarTodos()
        {
            try
            {
                return _context.Set<TEntity>().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public TEntity RecuperarPorId(int id)
        {
            try
            {
                return _context.Set<TEntity>().Find(id);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Inserir(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Add(obj);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Alterar(TEntity obj)
        {
            try
            {
                _context.Entry(obj).State = EntityState.Modified;
            }
            catch (Exception e)
            {
                throw e;
            }
            throw new System.NotImplementedException();
        }

        public void Remover(TEntity obj)
        {
            try
            {
                _context.Set<TEntity>().Remove(obj);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Remover(int id)
        {
            try
            {
                TEntity obj = RecuperarPorId(id);
                Remover(obj);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
