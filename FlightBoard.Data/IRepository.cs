using Lib.Web.Mvc.JQuery.JqGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FlightBoard.Data
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Update(T entity);

        bool Delete(T entity);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> FindAll();

        IEnumerable<T> GetRecordsForGrid(JqGridRequest request, string filter = "", Expression<Func<T, bool>> predicate = null);

        int Count(JqGridRequest request, string filter = "", Expression<Func<T, bool>> predicate = null);
    }
}
