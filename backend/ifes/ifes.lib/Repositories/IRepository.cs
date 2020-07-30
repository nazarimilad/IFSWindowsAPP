using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ifes.lib.Repositories {
    public interface IRepository<T> : IDisposable where T : class {
        T Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetList(Expression<Func<T, bool>> predicate);
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(T Entity);
        void RemoveRange(IEnumerable<T> entities);
        void Update(T entity);
        int SaveChanges();
    }
}
