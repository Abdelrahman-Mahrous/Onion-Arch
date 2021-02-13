using System;
using System.Collections.Generic;
using System.Text;
using OA.Data;

namespace OA.Repo
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
