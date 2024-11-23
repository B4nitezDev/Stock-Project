using Domain;
using Domain.Interfaces.Repositories;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public class Repositories<T> : IRepository<T> where T : class
    {
        protected readonly DbContextStockManagement _context;  
        public IQueryable<T> AsQueryable()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public int ExecuteSqlCommand(string query, params dynamic[] parameters)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Filter(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public T? Find(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void PartialUpdate(T t, params Expression<Func<T, object>>[] properties)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> SqlQuery(string query, params dynamic[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
