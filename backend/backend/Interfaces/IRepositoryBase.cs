﻿using backend.Models;
using System;
using System.Linq.Expressions;

namespace backend.Interfaces
{
	public interface IRepositoryBase<T>
	{
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        void SaveUserToXML(T entity);

        List<T> LoadUsersFromXML();
    }
}

