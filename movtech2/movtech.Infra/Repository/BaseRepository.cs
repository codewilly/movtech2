using movtech.Domain.Interfaces.Repository;
using movtech.Infra.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Infra.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        #region Config

        protected readonly MovtechContext _context;

        public BaseRepository(MovtechContext context)
        {
            _context = context;
        }

        #endregion

        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();

            return obj;
        }

        public T Update(T obj)
        {
            _context.Set<T>().Update(obj);
            _context.SaveChanges();

            return obj;
        }

        public void Delete(T obj)
        {
            _context.Set<T>().Remove(obj);
            _context.SaveChanges();
        }

    }
}
