using repositories.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace services.common
{
    public abstract class EntityService<T> : IEntityService<T> where T : class
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }     


        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Add(entity);
            _repository.Save();
            //TODO: Check why The UnitOfWork.Commit() does not save changes!
            //_unitOfWork.Commit();         
        }


        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Edit(entity);
            _repository.Save();
            //TODO: Check why The UnitOfWork.Commit() does not save changes!
            //_unitOfWork.Commit();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _repository.Delete(entity);
            _repository.Save();
            //TODO: Check why The UnitOfWork.Commit() does not save changes!
            //_unitOfWork.Commit();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _repository.FindBy(predicate);
        }

        public virtual T FindById(int id)
        {
            return _repository.FindById(id);
        }
    }
}
