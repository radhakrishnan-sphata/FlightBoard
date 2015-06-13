// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.RefreshService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Service.Business
{
    public class RefreshService : BusinessServiceBase<fb_RefreshTime>
    {
        //private static RefreshService defaultInstance = new RefreshService((DbContext)ServiceFactory<FlightBoardEntities>.get_Instance());

        //public static RefreshService Default
        //{
        //    get
        //    {
        //        return RefreshService.defaultInstance;
        //    }
        //}

        //public RefreshService()
        //{
        //}

        //public RefreshService(Repository<fb_RefreshTime> repository)
        //    : base(repository)
        //{
        //}

      //  public RefreshService(DbContext dbContext)
      //      : base(dbContext)
      //  {
      //  }

      //  public fb_RefreshTime getFirstEvent()
      //  {
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      return Queryable.FirstOrDefault<fb_RefreshTime>((IQueryable<fb_RefreshTime>)Queryable.OrderByDescending<fb_RefreshTime, DateTime>(this.FindAll(), Expression.Lambda<Func<fb_RefreshTime, DateTime>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_RefreshTime.get_RefreshTime))), new ParameterExpression[1]
      //{
      //  parameterExpression
      //})));
      //  }
    }
}
