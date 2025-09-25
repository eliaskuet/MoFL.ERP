using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAL.Repositories.BaseRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        T Insert(T entity);
        void InsertRange(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        IEnumerable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
    }
}
