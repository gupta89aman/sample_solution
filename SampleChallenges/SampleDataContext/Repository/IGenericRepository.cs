using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SampleDataContext.Repository
{
    public interface IGenericRepository<TEntity>
    {
        //Get all operations
        List<TEntity> Get(Expression<Func<TEntity,bool>> filter = null,
            Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy = null,
            params Expression<Func<TEntity,object>>[] includes);
        //Get specific record item
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        IQueryable<TEntity> Query(Expression<Func<TEntity,bool>> filter=null,Func<IQueryable<TEntity>,IOrderedQueryable<TEntity>> orderBy = null);
    }
}
