using System;
using System.Collections.Generic;
using System.Data.Entity;
using Boomer.Server.Core.Contract;
using Boomer.Server.Core.Contract.Helpers;

namespace Boomer.Server.Core.Data
{
    public class EFRepository<T> : IEFRepository<T> where T : class
    {
        public EFRepository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }


        protected DbContext DbContext { get; set; }

        protected DbSet<T> DbSet { get; set; }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public T GetById(long id)
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetMany(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public PagedList.IPagedList<T> GetPage<TOrder>(Page page, System.Linq.Expressions.Expression<Func<T, bool>> where, System.Linq.Expressions.Expression<Func<T, TOrder>> order)
        {
            throw new NotImplementedException();
        }
    }
}
