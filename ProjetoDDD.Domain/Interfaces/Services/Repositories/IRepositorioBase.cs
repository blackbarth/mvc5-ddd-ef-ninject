using System.Collections.Generic;

namespace ProjetoDDD.Domain.Interfaces.Repositories
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        IList<TEntity> RecuperarTodos();
        TEntity RecuperarPorId(int id);
        void Inserir(TEntity obj);
        void Alterar(TEntity obj);
        void Remover(TEntity obj);
        void Remover(int id);
    }
}