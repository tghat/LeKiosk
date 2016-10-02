using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace services.common
{
    public interface IEntityService<T> : IService
     where T : class
    {
        void Create(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();      
        void Update(T entity);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        T FindById(int id);
    }
}
