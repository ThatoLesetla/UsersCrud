using System;
using backend.Data;
using System.Linq.Expressions;
using backend.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
using System.Collections.Generic;
using backend.Models;

namespace backend.Repository
{
	public class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
        protected DataContext dataContext;
        private readonly string _xmlFilePath = $"{Directory.GetCurrentDirectory()}/Data/users.xml";

        public RepositoryBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void Create(T entity)
        {
            dataContext.Set<T>().Add(entity);
        }

        public void SaveUserToXML(T entity)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

           if (File.Exists(_xmlFilePath))
            {
                using (StreamWriter writer = new StreamWriter(_xmlFilePath))
                {
                    serializer.Serialize(writer, entity);
                }
            }
        }

        public List<T> LoadUsersFromXML()
        {
            if (File.Exists(_xmlFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));

                using (StreamReader reader = new StreamReader(_xmlFilePath))
                {
                    List<T> entities = (List<T>)serializer.Deserialize(reader);

                    return entities;
                }
            } else
            {
                return new List<T>();
            }
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

