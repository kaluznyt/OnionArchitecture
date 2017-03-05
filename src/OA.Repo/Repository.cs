using Microsoft.EntityFrameworkCore;
using OA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> _entities;
        private string _errorMessage = string.Empty;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public T Get(long id)
        {
            return _entities.SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            _context.SaveChanges();
        }
    }
}
