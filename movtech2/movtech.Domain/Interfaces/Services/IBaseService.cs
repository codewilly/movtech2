using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : class
    {       

        TEntity Get(int id);

        IEnumerable<TEntity> GetAll();

        TEntity Insert(TEntity obj);

        TEntity Update(TEntity obj);

        void Delete(TEntity obj);

    }
}
