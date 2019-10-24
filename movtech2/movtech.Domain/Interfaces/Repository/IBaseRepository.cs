using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T Get(int id);

        IEnumerable<T> GetAll();

        T Insert(T obj);

        T Update(T obj);

        void Delete(T obj);
    }
}
