using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace apiLeviathansChilds.domain.interfaces.repositories
{
    public interface IRepositoryBase<TEntity, TId>
        where TEntity : class
        where TId : struct
    {
        IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> GetByAndOrder<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> order, bool ascending = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetOneBy(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties);

        bool Exist(Func<TEntity, bool> where);

        IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties);

        IQueryable<TEntity> GetAllAndOrder<TKey>(Expression<Func<TEntity, TKey>> order, bool ascending = true, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity GetById(TId id, params Expression<Func<TEntity, object>>[] includeProperties);

        TEntity Insert(TEntity entity);

        TEntity Update(TEntity entity);

        void Remove(TEntity entity);

        IEnumerable<TEntity> InsertList(IEnumerable<TEntity> entities);
    }
}