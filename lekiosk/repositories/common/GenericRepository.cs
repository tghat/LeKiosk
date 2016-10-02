using entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace repositories.common
{
    public abstract class GenericRepository<C, T> : IGenericRepository<T>
        where T : class
        where C : LekioskEntities, new()
    {
        private C _entities = new C();
        protected C Context
        {
            get { return _entities; }
            set { _entities = value; }
        }

        public virtual IQueryable<T> GetAll()
        {
            return _entities.Set<T>();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {

            IQueryable<T> query = _entities.Set<T>().Where(predicate);
            return query;
        }

        public virtual T FindById(int id)
        {
            return _entities.Set<T>().Find(id);
        }

        public virtual T Add(T entity)
        {
            return _entities.Set<T>().Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _entities.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _entities.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }
    }
}
