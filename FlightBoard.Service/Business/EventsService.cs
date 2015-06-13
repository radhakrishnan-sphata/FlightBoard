// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.EventsService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Service.Business
{
  public class EventsService : BusinessServiceBase<fb_Events>
  {
    //private static EventsService defaultInstance = new EventsService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static EventsService Default
    //{
    //  get
    //  {
    //    return EventsService.defaultInstance;
    //  }
    //}

    //public EventsService()
    //{
    //}

    //public EventsService(Repository<fb_Events> repository)
    //  : base(repository)
    //{
    //}

    //public EventsService(DbContext dbContext)
    //  : base(dbContext)
    //{
    //}

    //public IEnumerable<fb_Events> GetEvents()
    //{
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  return (IEnumerable<fb_Events>) Queryable.OrderByDescending<fb_Events, DateTime?>(this.FindAll(), Expression.Lambda<Func<fb_Events, DateTime?>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_EventDate))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }));
    //}

    //public fb_Events getFirstEvent()
    //{
    //  return Queryable.FirstOrDefault<fb_Events>(this.FindAll());
    //}

    //public fb_Events getEventByItemEventID(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  EventsService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new EventsService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.id = id;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Queryable.FirstOrDefault<fb_Events>(Queryable.Where<fb_Events>(this.FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (EventsService.\u003C\u003Ec__DisplayClass0.id))), typeof (int?))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public List<fb_Events> GetEvent()
    //{
    //  return Enumerable.ToList<fb_Events>((IEnumerable<fb_Events>) Queryable.Select<fb_Events, fb_Events>((IQueryable<fb_Events>) new FlightBoardEntities().get_fb_Events(), (Expression<Func<fb_Events, fb_Events>>) (d => d)));
    //}
  }
}
