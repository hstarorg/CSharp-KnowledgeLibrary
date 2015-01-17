using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Hstar.KnowledgeLibrary.DataAccess
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        private readonly KnowledgeDbContext db;

        public BaseRepository()
        {
            db=new KnowledgeDbContext();
        }
        public TEntity GetById(int entityId)
        {
            return db.Set<TEntity>().Find(entityId);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> expression)
        {
            return db.Set<TEntity>().FirstOrDefault(expression);
        }

        public IQueryable<TEntity> QueryList(Expression<Func<TEntity, bool>> expression)
        {
            return db.Set<TEntity>().Where(expression);
        }

        public TEntity Add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
            db.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            db.SaveChanges();
            return entity;
        }

        public bool Delete(int entityId)
        {
            var entity=db.Set<TEntity>().Find(entityId);
            db.Set<TEntity>().Remove(entity);
            return true;
        }
    }
}