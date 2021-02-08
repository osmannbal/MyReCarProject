using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<V> where V:class,IEntity,new()
    {
        List<V> GetAll(Expression<Func<V, bool>> filter = null);
        V Get(Expression<Func<V, bool>> filter);
        void Add(V entity);
        void Delete(V entity);
        void Update(V entity);

    }
}
