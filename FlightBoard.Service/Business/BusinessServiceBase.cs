// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.BusinessServiceBase`1
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Services;
using FlightBoard.Data;
using Lib.Web.Mvc.JQuery.JqGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;

namespace FlightBoard.Service.Business
{
    public class BusinessServiceBase<T> : IDisposable, IBusinessServiceBase<T> where T : class
    {
        public DbContext _dbContext;

        public IRepository<T> _repository { get; set; }

        public BusinessServiceBase()
        {
            this._dbContext = (DbContext)new FlightBoardEntities();
            this._repository = (IRepository<T>)new Repository<T>(this._dbContext);
        }

        public BusinessServiceBase(Repository<T> repository)
        {
            this._dbContext = (DbContext)repository._dbContext;
            this._repository = (IRepository<T>)repository;
        }

        public BusinessServiceBase(DbContext dbContext)
        {
            this._dbContext = dbContext;
            this._repository = (IRepository<T>)new Repository<T>(this._dbContext);
        }

        public T Add(T entity, bool save = true)
        {
            if ((object)entity == null)
                ((Log4NetLoggerService)LoggerService.logger).Error("Entity is null");
            try
            {
                this._repository.Add(entity);
                if (save)
                    this._dbContext.SaveChanges();
                return entity;
            }
            catch (DbEntityValidationException ex)
            {
                string str = string.Empty;
                //using (IEnumerator<DbEntityValidationResult> enumerator1 = ex.get_EntityValidationErrors().GetEnumerator())
                //{
                //    while (((IEnumerator)enumerator1).MoveNext())
                //    {
                //        DbEntityValidationResult current1 = enumerator1.Current;
                //        str += string.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:", (object)current1.get_Entry().get_Entity().GetType().Name, (object)current1.get_Entry().get_State());
                //        using (IEnumerator<DbValidationError> enumerator2 = ((IEnumerable<DbValidationError>)current1.get_ValidationErrors()).GetEnumerator())
                //        {
                //            while (((IEnumerator)enumerator2).MoveNext())
                //            {
                //                DbValidationError current2 = enumerator2.Current;
                //                str += string.Format("- Property: \"{0}\", Error: \"{1}\"", (object)current2.get_PropertyName(), (object)current2.get_ErrorMessage());
                //            }
                //        }
                //    }
                //}
                ((Log4NetLoggerService)LoggerService.logger).Error("[BusinessServiceBase > Add]" + str);
                throw ex;
            }
            catch (DbUpdateException ex)
            {
                ((Log4NetLoggerService)LoggerService.logger).Error((Exception)ex);
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(T entity, bool save = true)
        {
            if ((object)entity == null)
            {
                ((Log4NetLoggerService)LoggerService.logger).Error("Entity is null");
            }
            else
            {
                this._repository.Update(entity);
                if (!save)
                    return;
                this._dbContext.SaveChanges();
            }
        }

        public virtual bool Delete(T entity, bool save = true)
        {
            if ((object)entity == null)
            {
                ((Log4NetLoggerService)LoggerService.logger).Error("Entity is null");
                return false;
            }
            if (!this._repository.Delete(entity))
                return false;
            if (save)
                this._dbContext.SaveChanges();
            return true;
        }

        public IQueryable<T> FindAll()
        {
            return this._repository.FindAll();
        }

        public virtual IEnumerable<T> GetRecordsForGrid(JqGridRequest request, string filter = "", Expression<Func<T, bool>> predicate = null)
        {
            return this._repository.GetRecordsForGrid(request, filter, predicate);
        }

        public virtual int Count(JqGridRequest request, string filter = "", Expression<Func<T, bool>> predicate = null)
        {
            return this._repository.Count(request, filter, predicate);
        }

        public void Dispose()
        {
            GC.SuppressFinalize((object)this);
        }
    }
}
