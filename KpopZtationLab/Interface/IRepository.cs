using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KpopZtationLab.Interface
{
    internal interface IRepository<T>
    {
        void Remove(T entity);

        void RemoveRange(List<T> entities);

        void Add(T entity);

        void AddRange(List<T> entities);

        void Update(T entity); 

        IEnumerable<T> Find(Expression<Func<T,bool>> predicate);

  
    }
}
