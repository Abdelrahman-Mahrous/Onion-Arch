using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OA.Data;

namespace OA.Repo
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private DbSet<T> _entites;
        public Repository(ApplicationContext context)
        {
            _context = context;
            _entites = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entites.AsEnumerable();
        }
        public T Get(int id)
        {
            return _entites.SingleOrDefault(x => x.ID == id);
        }
        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity can't be null");
            }
             _entites.Remove(entity);
           // entity.IsDeleted = true;
            _context.SaveChanges();
        }  

        public void Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity can't be null");
            }
            _entites.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Entity can't be null");
            }      
            _context.SaveChanges();
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

      
    }
}
