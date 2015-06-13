// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.FlightBoardConfigService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using FlightBoard.Service.Business.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Service.Business
{
  public class FlightBoardConfigService : BusinessServiceBase<fb_FlightBoardConfig>
  {
    //private static FlightBoardConfigService defaultInstance = new FlightBoardConfigService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static FlightBoardConfigService Default
    //{
    //  get
    //  {
    //    return FlightBoardConfigService.defaultInstance;
    //  }
    //}

    //public FlightBoardConfigService()
    //{
    //}

    //public FlightBoardConfigService(Repository<fb_FlightBoardConfig> repository)
    //  : base(repository)
    //{
    //}

    public FlightBoardConfigService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public IEnumerable<FlighBoardConfigureListModel> GetAllFlightBoardConfig()
    //{
    //  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    //  ItemsService itemsService = new ItemsService(this._dbContext);
    //  EventsService eventsService = new EventsService(this._dbContext);
    //  DeviceUnitsService deviceUnitsService = new DeviceUnitsService();
    //  ParameterExpression parameterExpression1;
    //  ParameterExpression parameterExpression2;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  List<\u003C\u003Ef__AnonymousType8<int?, string>> prepAreaList = Enumerable.ToList(Queryable.Distinct(Queryable.Select(Queryable.Where<fb_Items>(itemsService.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.NotEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_PrepAreaId))), (Expression) Expression.Constant((object) new int?(), typeof (int?))), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  })), Expression.Lambda<Func<fb_Items, \u003C\u003Ef__AnonymousType8<int?, string>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType8<int?, string>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType8<int?, string>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_PrepAreaId))),
    //    (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_PrepAreaName)))
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType8<int?, string>.get_PrepAreaId), __typeref (\u003C\u003Ef__AnonymousType8<int?, string>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType8<int?, string>.get_PrepAreaName), __typeref (\u003C\u003Ef__AnonymousType8<int?, string>))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  }))));
    //  List<fb_FlightBoardConfig> list1 = Enumerable.ToList<fb_FlightBoardConfig>((IEnumerable<fb_FlightBoardConfig>) this.FindAll());
    //  List<fb_Events> eventsList = Enumerable.ToList<fb_Events>((IEnumerable<fb_Events>) eventsService.FindAll());
    //  List<fb_DeviceUnits> list2 = Enumerable.ToList<fb_DeviceUnits>((IEnumerable<fb_DeviceUnits>) deviceUnitsService.FindAll());
    //  return Enumerable.Join<fb_FlightBoardConfig, fb_DeviceUnits, int, FlighBoardConfigureListModel>((IEnumerable<fb_FlightBoardConfig>) list1, (IEnumerable<fb_DeviceUnits>) list2, (Func<fb_FlightBoardConfig, int>) (d => d.get_DeviceUnitID()), (Func<fb_DeviceUnits, int>) (v => v.get_ID()), (Func<fb_FlightBoardConfig, fb_DeviceUnits, FlighBoardConfigureListModel>) ((d, v) => new FlighBoardConfigureListModel()
    //  {
    //    ID = d.get_ID(),
    //    DeviceID = d.get_DeviceUnitID(),
    //    DeviceName = v.get_DeviceUnitName(),
    //    EventEndDate = d.get_EventEndDate(),
    //    EventStartDate = d.get_EventStartDate(),
    //    PrepAreaId = d.get_PrepAreaId(),
    //    PrepAreaName = !d.get_PrepAreaId().HasValue ? "" : Enumerable.FirstOrDefault<string>(Enumerable.Select(Enumerable.Where(prepAreaList, x => x.PrepAreaId.Equals((object) d.get_PrepAreaId())), x => x.PrepAreaName)),
    //    ProductionFrom = d.get_ProductionFrom(),
    //    ProductionTo = d.get_ProductionTo(),
    //    EventId = d.get_EventID(),
    //    EventName = !d.get_EventID().HasValue ? "" : Enumerable.FirstOrDefault<string>(Enumerable.Select<fb_Events, string>(Enumerable.Where<fb_Events>((IEnumerable<fb_Events>) eventsList, (Func<fb_Events, bool>) (x =>
    //    {
    //      int? fsSeventlistIntid = x.get_FSSeventlist_intid();
    //      int? eventId = d.get_EventID();
    //      if (fsSeventlistIntid.GetValueOrDefault() == eventId.GetValueOrDefault())
    //        return fsSeventlistIntid.HasValue == eventId.HasValue;
    //      return false;
    //    })), (Func<fb_Events, string>) (x => x.get_EventName()))),
    //    TemplateID = d.get_TemplateID(),
    //    TransitionTime = d.get_TransitionTime() + "s"
    //  }));
    //}

    //public List<fb_SchedulerTemplates> GetAllSchedulerTemplates()
    //{
    //  return Enumerable.ToList<fb_SchedulerTemplates>((IEnumerable<fb_SchedulerTemplates>) Queryable.Select<fb_SchedulerTemplates, fb_SchedulerTemplates>((IQueryable<fb_SchedulerTemplates>) new FlightBoardEntities().get_fb_SchedulerTemplates(), (Expression<Func<fb_SchedulerTemplates, fb_SchedulerTemplates>>) (d => d)));
    //}

    //public fb_FlightBoardConfig FindByDeviceId(int deviceId, int TemplateId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  FlightBoardConfigService.\u003C\u003Ec__DisplayClass11 cDisplayClass11 = new FlightBoardConfigService.\u003C\u003Ec__DisplayClass11();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass11.deviceId = deviceId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass11.TemplateId = TemplateId;
    //  try
    //  {
    //    ParameterExpression parameterExpression;
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    return Queryable.SingleOrDefault<fb_FlightBoardConfig>(Queryable.Where<fb_FlightBoardConfig>(this.FindAll(), Expression.Lambda<Func<fb_FlightBoardConfig, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_FlightBoardConfig.get_DeviceUnitID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (FlightBoardConfigService.\u003C\u003Ec__DisplayClass11.deviceId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_FlightBoardConfig.get_TemplateID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (FlightBoardConfigService.\u003C\u003Ec__DisplayClass11.TemplateId))))), new ParameterExpression[1]
    //    {
    //      parameterExpression
    //    })));
    //  }
    //  catch (Exception ex)
    //  {
    //  }
    //  return (fb_FlightBoardConfig) null;
    //}

    //public fb_FlightBoardConfig FindByID(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  FlightBoardConfigService.\u003C\u003Ec__DisplayClass13 cDisplayClass13 = new FlightBoardConfigService.\u003C\u003Ec__DisplayClass13();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass13.id = id;
    //  try
    //  {
    //    ParameterExpression parameterExpression;
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    return Queryable.FirstOrDefault<fb_FlightBoardConfig>(Queryable.Where<fb_FlightBoardConfig>(this.FindAll(), Expression.Lambda<Func<fb_FlightBoardConfig, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_FlightBoardConfig.get_ID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass13), FieldInfo.GetFieldFromHandle(__fieldref (FlightBoardConfigService.\u003C\u003Ec__DisplayClass13.id)))), new ParameterExpression[1]
    //    {
    //      parameterExpression
    //    })));
    //  }
    //  catch (Exception ex)
    //  {
    //  }
    //  return (fb_FlightBoardConfig) null;
    //}
  }
}
