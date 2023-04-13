using System;
using backend.Data;
using System.Linq.Expressions;
using backend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace backend.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
        protected DataContext dataContext;

        public RepositoryBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(T entity)
        {
            dataContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            dataContext.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return !trackChanges ? dataContext.Set<T>().AsNoTracking() : dataContext.Set<T>();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return !trackChanges ? dataContext.Set<T>().Where(expression).AsNoTracking() : dataContext.Set<T>().Where(expression);

        }
    }
}

