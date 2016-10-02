using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace repositories.common
{
    public interface IGenericRepository<T> where T : class
    {

        IQueryable<T> GetAll();
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        T Add(T entity);
        T Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
