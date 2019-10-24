using movtech.Domain.Interfaces.Repository;
using movtech.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Domain.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {

        #region Config

        protected readonly IBaseRepository<TEntity> _repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            _repository = repository;
        }

        #endregion


        public TEntity Get(int id)
        {
            return _repository.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity Insert(TEntity obj)
        {
            return _repository.Insert(obj);
        }

        public TEntity Update(TEntity obj)
        {
            return _repository.Update(obj);
        }

        public void Delete(TEntity obj)
        {
            _repository.Delete(obj);
        }
               
    }
}
