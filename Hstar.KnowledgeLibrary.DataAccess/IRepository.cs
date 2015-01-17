using System;
using System.Linq;
using System.Linq.Expressions;

namespace Hstar.KnowledgeLibrary.DataAccess
{
    public interface IRepository<TEntity> where TEntity : class ,new()
    {
        TEntity GetById(int entityId);

        TEntity GetSingle(Expression<Func<TEntity, bool>> expression);

        IQueryable<TEntity> QueryList(Expression<Func<TEntity, bool>> expression);

        TEntity Add(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(int entityId);
    }
}
