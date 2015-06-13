// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.Repository`1
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using FlightBoard.Core.Services;
using Lib.Web.Mvc.JQuery.JqGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;

namespace FlightBoard.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbContext _dbContext;
        public IDbSet<T> _entities;

        public virtual IQueryable<T> Table
        {
            get
            {
                return (IQueryable<T>)this.Entities;
            }
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (this._entities == null)
                    this._entities = (IDbSet<T>)this._dbContext.Set<T>();
                return this._entities;
            }
        }

        public Repository()
        {
            this._dbContext = (DbContext)new FlightBoardEntities();
        }

        public Repository(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add(T entity)
        {
            try
            {
                if ((object)entity == null)
                    LoggerService.logger.Info("Entity is null");
                else
                    this.Entities.Add(entity);
            }
            catch (DbEntityValidationException ex)
            {
                string message = string.Empty;
                //using (IEnumerator<DbEntityValidationResult> enumerator1 = ex.get_EntityValidationErrors().GetEnumerator())
                //{
                //    while (((IEnumerator)enumerator1).MoveNext())
                //    {
                //        using (IEnumerator<DbValidationError> enumerator2 = ((IEnumerable<DbValidationError>)enumerator1.Current.get_ValidationErrors()).GetEnumerator())
                //        {
                //            while (((IEnumerator)enumerator2).MoveNext())
                //            {
                //                DbValidationError current = enumerator2.Current;
                //                message = message + string.Format("Property: {0} Error: {1}", (object)current.get_PropertyName(), (object)current.get_ErrorMessage()) + Environment.NewLine;
                //            }
                //        }
                //    }
                //}
                throw new Exception(message, (Exception)ex);
            }
        }

        public void Update(T entity)
        {
            try
            {
                if ((object)entity == null)
                    LoggerService.logger.Info("Entity is null");
                //else
                //    ((DbEntityEntry<T>)this._dbContext.Entry<T>((M0)entity)).set_State((EntityState)16);
            }
            catch (DbEntityValidationException ex)
            {
                LoggerService.logger.Error("Entity not updated " + ((Exception)ex).Message);
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                this.Entities.Remove(entity);
                return true;
            }
            catch (DbEntityValidationException ex)
            {
                LoggerService.logger.Error("Entity not deleted " + ((Exception)ex).Message);
            }
            return false;
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Queryable.Where<T>(this.Table, predicate);
        }

        public IQueryable<T> FindAll()
        {
            return this.Table;
        }

        public virtual IQueryable<T> Get(string filter = "", Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> includeProperties = null, int? page = null, int? pageSize = null, Expression<Func<T, bool>> predicate = null)
        {
            IQueryable<T> query = (IQueryable<T>)this._entities;
            //if (includeProperties != null)
            //    includeProperties.ForEach((Action<Expression<Func<T, object>>>)(i => query = (IQueryable<T>)QueryableExtensions.Include<T, object>((IQueryable<M0>)query, (Expression<Func<M0, M1>>)i)));
            if (filter != "")
                query = DynamicQueryable.Where<T>(query, filter);
            if (predicate != null)
                query = Queryable.Where<T>(query, predicate);
            if (orderBy != null)
                query = (IQueryable<T>)orderBy(query);
            if (page.HasValue && pageSize.HasValue)
                query = Queryable.Take<T>(Queryable.Skip<T>(query, (page.Value - 1) * pageSize.Value), pageSize.Value);
            return query;
        }

        public virtual IEnumerable<T> GetRecordsForGrid(JqGridRequest request, string filter = "", Expression<Func<T, bool>> predicate = null)
        {
            string ordering = "";// string.Format("{0} {1}", (object)request.get_SortingName(), (object)request.get_SortingOrder());
            int count = 1;// request.get_PageIndex() * request.get_RecordsCount();
            int recordsCount = 1;// request.get_RecordsCount();
            if (filter != null)
                return (IEnumerable<T>)Queryable.Take<T>(Queryable.Skip<T>(DynamicQueryable.OrderBy<T>(this.Get(filter, (Func<IQueryable<T>, IOrderedQueryable<T>>)null, (List<Expression<Func<T, object>>>)null, new int?(), new int?(), predicate), ordering), count), recordsCount);
            return (IEnumerable<T>)Queryable.Take<T>(Queryable.Skip<T>(DynamicQueryable.OrderBy<T>((IQueryable<T>)this._entities, ordering), count), recordsCount);
        }

        public virtual int Count(JqGridRequest request, string filter = "", Expression<Func<T, bool>> predicate = null)
        {
            string ordering = "";// string.Format("{0} {1}", (object)request.get_SortingName(), (object)request.get_SortingOrder());
            int count = 1;// request.get_PageIndex() * request.get_RecordsCount();
            int recordsCount = 1; // request.get_RecordsCount();
            if (filter != null)
                return Queryable.Count<T>(Queryable.Take<T>(Queryable.Skip<T>(DynamicQueryable.OrderBy<T>(this.Get(filter, (Func<IQueryable<T>, IOrderedQueryable<T>>)null, (List<Expression<Func<T, object>>>)null, new int?(), new int?(), predicate), ordering), count), recordsCount));
            return Queryable.Count<T>(Queryable.Take<T>(Queryable.Skip<T>(DynamicQueryable.OrderBy<T>((IQueryable<T>)this._entities, ordering), count), recordsCount));
        }
    }
}
