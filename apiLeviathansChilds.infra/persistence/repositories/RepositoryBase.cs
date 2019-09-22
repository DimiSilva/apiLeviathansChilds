using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using apiLeviathansChilds.domain.entities;
using apiLeviathansChilds.domain.interfaces.repositories;
using Microsoft.EntityFrameworkCore;

namespace apiLeviathansChilds.infra.persistence.repositories
{
    public class RepositoryBase<TEntity, TId> : IRepositoryBase<TEntity, TId>
        where TEntity : EntityBase
        where TId : struct
    {

        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetBy(Expression<Func<TEntity, bool>> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return GetAll(includeProperties).Where(where);
        }

        public IQueryable<TEntity> GetByAndOrder<TKey>(Expression<Func<TEntity, bool>> where, Expression<Func<TEntity, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return ascendente ? GetBy(where, includeProperties).OrderBy(ordem) : GetBy(where, includeProperties).OrderByDescending(ordem);
        }

        public TEntity GetOneBy(Func<TEntity, bool> where, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return GetAll(includeProperties).FirstOrDefault(where);
        }

        public TEntity GetById(TId id, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            if (includeProperties.Any())
            {
                return GetAll(includeProperties).FirstOrDefault(x => x.id.ToString() == id.ToString());
            }

            return _context.Set<TEntity>().Find(id);
        }

        public IQueryable<TEntity> GetAll(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            if (includeProperties.Any())
            {
                return Include(_context.Set<TEntity>(), includeProperties);
            }

            return query;
        }

        public IQueryable<TEntity> GetAllAndOrder<TKey>(Expression<Func<TEntity, TKey>> ordem, bool ascendente = true, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return ascendente ? GetAll(includeProperties).OrderBy(ordem) : GetAll(includeProperties).OrderByDescending(ordem);
        }

        public TEntity Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            return entity;
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        /// <summary>
        /// Adicionar um coleção de entidades ao contexto do entity framework
        /// </summary>
        /// <param name="entidades">Lista de entidades que deverão ser persistidas</param>
        /// <returns></returns>
        public IEnumerable<TEntity> InsertList(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
            return entities;
        }

        /// <summary>
        /// Verifica se existe algum objeto com a condição informada
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public bool Exist(Func<TEntity, bool> where)
        {
            return _context.Set<TEntity>().Any(where);
        }

        /// <summary>
        /// Realiza include populando o objeto passado por parametro
        /// </summary>
        /// <param name="query">Informe o objeto do tipo IQuerable</param>
        /// <param name="includeProperties">Ínforme o array de expressões que deseja incluir</param>
        /// <returns></returns>
        private IQueryable<TEntity> Include(IQueryable<TEntity> query, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            foreach (var property in includeProperties)
            {
                query = query.Include(property);
            }

            return query;
        }
    }
}