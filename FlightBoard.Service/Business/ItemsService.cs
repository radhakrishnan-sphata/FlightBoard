// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.ItemsService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using FlightBoard.Service.Business.DataModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Service.Business
{
  public class ItemsService : BusinessServiceBase<fb_Items>
  {
    //private static ItemsService defaultInstance = new ItemsService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static ItemsService Default
    //{
    //  get
    //  {
    //    return ItemsService.defaultInstance;
    //  }
    //}

    //public ItemsService()
    //{
    //}

    //public ItemsService(Repository<fb_Items> repository)
    //  : base(repository)
    //{
    //}

    //public ItemsService(DbContext dbContext)
    //  : base(dbContext)
    //{
    //}

    //public IEnumerable<fb_Items> GetItems()
    //{
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  return (IEnumerable<fb_Items>) Queryable.OrderByDescending<fb_Items, int>(this.FindAll(), Expression.Lambda<Func<fb_Items, int>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }));
    //}

    //public fb_Items GetItemByID(int ItemID)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ItemsService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new ItemsService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.ItemID = ItemID;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Queryable.FirstOrDefault<fb_Items>(Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass0.ItemID)))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public List<fb_Items> GetItemsByEventListId(int eventListId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ItemsService.\u003C\u003Ec__DisplayClass2 cDisplayClass2 = new ItemsService.\u003C\u003Ec__DisplayClass2();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass2.eventListId = eventListId;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  return Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass2), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass2.eventListId)))
    //  }), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_IsSubItem))), (Expression) Expression.Constant((object) false, typeof (bool)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public List<fb_Items> GetSubItemsByMainItemIdAndEventID(string eventListId)
    //{
    //  //// ISSUE: object of a compiler-generated type is created
    //  //// ISSUE: variable of a compiler-generated type
    //  //ItemsService.\u003C\u003Ec__DisplayClass4 cDisplayClass4 = new ItemsService.\u003C\u003Ec__DisplayClass4();
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass4.eventListId = eventListId;
    //  //ParameterExpression parameterExpression;
    //  //// ISSUE: method reference
    //  //// ISSUE: method reference
    //  //// ISSUE: field reference
    //  //// ISSUE: method reference
    //  //return Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_UniQueItemIds))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), new Expression[1]
    //  //{
    //  //  (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass4.eventListId)))
    //  //}), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_HasSubItem))), (Expression) Expression.Convert((Expression) Expression.Constant((object) true, typeof (bool)), typeof (bool?)))), new ParameterExpression[1]
    //  //{
    //  //  parameterExpression
    //  //})));

    //    return null;
    //}

    //public List<int> GetEventsByItemId(int itemId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ItemsService.\u003C\u003Ec__DisplayClass6 cDisplayClass6 = new ItemsService.\u003C\u003Ec__DisplayClass6();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass6.itemId = itemId;
    //  ParameterExpression parameterExpression1;
    //  ParameterExpression parameterExpression2;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  return Enumerable.ToList<int>((IEnumerable<int>) Queryable.Select<fb_Items, int>(Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass6), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass6.itemId)))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  })), Expression.Lambda<Func<fb_Items, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  })));
    //}

    //public List<fb_Items> GetDistinctItemNames(string itemName)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ItemsService.\u003C\u003Ec__DisplayClassd cDisplayClassd = new ItemsService.\u003C\u003Ec__DisplayClassd();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassd.itemName = itemName;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Enumerable.ToList<fb_Items>(Enumerable.Select<IGrouping<\u003C\u003Ef__AnonymousTypec<int, string>, fb_Items>, fb_Items>(Enumerable.GroupBy((IEnumerable<fb_Items>) Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClassd.itemName)))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }))), im => new
    //  {
    //    Item_intid = im.get_Item_intid(),
    //    ItemName = im.get_ItemName()
    //  }), g =>
    //  {
    //    fb_Items fbItems = new fb_Items();
    //    fbItems.set_Item_intid(g.Key.Item_intid);
    //    fbItems.set_ItemName(g.Key.ItemName);
    //    return fbItems;
    //  }));
    //}

    //public List<fb_Items> GetItemsByItemNameOrderByEventID(string itemName, int eventId, string eventDate, string eventendDate, string contractId, int show, string fromdate, string todate)
    //{
    //  //// ISSUE: object of a compiler-generated type is created
    //  //// ISSUE: variable of a compiler-generated type
    //  //ItemsService.\u003C\u003Ec__DisplayClass34 cDisplayClass34 = new ItemsService.\u003C\u003Ec__DisplayClass34();
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass34.itemName = itemName;
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass34.eventId = eventId;
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass34.contractId = contractId;
    //  //EventsService eventsService = new EventsService(this._dbContext);
    //  //ProductionDateService productionDateService = new ProductionDateService(this._dbContext);
    //  //List<fb_Items> list1 = new List<fb_Items>();
    //  //List<fb_ProductionDates> list2 = new List<fb_ProductionDates>();
    //  //List<fb_ProductionDates> list3 = new List<fb_ProductionDates>();
    //  //List<fb_Items> list4 = new List<fb_Items>();
    //  //ParameterExpression parameterExpression1;
    //  //// ISSUE: method reference
    //  //List<fb_Items> list5 = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_IsSubItem))), (Expression) Expression.Constant((object) false, typeof (bool))), new ParameterExpression[1]
    //  //{
    //  //  parameterExpression1
    //  //})));
    //  //// ISSUE: reference to a compiler-generated field
    //  //if (cDisplayClass34.itemName != "")
    //  //{
    //  //  // ISSUE: reference to a compiler-generated method
    //  //  list5 = Enumerable.ToList<fb_Items>(Enumerable.Where<fb_Items>((IEnumerable<fb_Items>) list5, new Func<fb_Items, bool>(cDisplayClass34.\u003CGetItemsByItemNameOrderByEventID\u003Eb__13)));
    //  //}
    //  //// ISSUE: reference to a compiler-generated field
    //  //if (cDisplayClass34.eventId > 0)
    //  //{
    //  //  // ISSUE: reference to a compiler-generated method
    //  //  list5 = Enumerable.ToList<fb_Items>(Enumerable.Where<fb_Items>((IEnumerable<fb_Items>) list5, new Func<fb_Items, bool>(cDisplayClass34.\u003CGetItemsByItemNameOrderByEventID\u003Eb__14)));
    //  //}
    //  //// ISSUE: reference to a compiler-generated field
    //  //if (cDisplayClass34.contractId != "")
    //  //{
    //  //  ParameterExpression parameterExpression2;
    //  //  // ISSUE: method reference
    //  //  // ISSUE: method reference
    //  //  // ISSUE: method reference
    //  //  // ISSUE: field reference
    //  //  list5 = Enumerable.ToList<fb_Items>(Enumerable.Join<fb_Events, fb_Items, int?, fb_Items>(Enumerable.AsEnumerable<fb_Events>((IEnumerable<fb_Events>) Enumerable.ToList<fb_Events>((IEnumerable<fb_Events>) Queryable.Where<fb_Events>(eventsService.FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Call((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_Contract))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.ToLower)), new Expression[0]), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), new Expression[1]
    //  //  {
    //  //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass34), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass34.contractId)))
    //  //  }), new ParameterExpression[1]
    //  //  {
    //  //    parameterExpression2
    //  //  })))), Enumerable.AsEnumerable<fb_Items>((IEnumerable<fb_Items>) list5), (Func<fb_Events, int?>) (ev => ev.get_FSSeventlist_intid()), (Func<fb_Items, int?>) (it => new int?(it.get_ItemEvent_intid())), (Func<fb_Events, fb_Items, fb_Items>) ((ev, it) => it)));
    //  //}
    //  //else if (eventDate != "" && eventendDate != "")
    //  //{
    //  //  DateTime changedEventDate = DateTime.ParseExact(eventDate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
    //  //  DateTime changedEventEndDate = DateTime.ParseExact(eventendDate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
    //  //  list5 = Enumerable.ToList<fb_Items>(Enumerable.Join<fb_Events, fb_Items, int?, fb_Items>(Enumerable.AsEnumerable<fb_Events>((IEnumerable<fb_Events>) Enumerable.ToList<fb_Events>(Enumerable.Where<fb_Events>((IEnumerable<fb_Events>) Enumerable.ToList<fb_Events>((IEnumerable<fb_Events>) eventsService.FindAll()), (Func<fb_Events, bool>) (x =>
    //  //  {
    //  //    DateTime? eventDate1 = x.get_EventDate();
    //  //    DateTime dateTime1 = changedEventDate;
    //  //    if ((eventDate1.HasValue ? (eventDate1.GetValueOrDefault() >= dateTime1 ? 1 : 0) : 0) == 0)
    //  //      return false;
    //  //    DateTime? eventDate2 = x.get_EventDate();
    //  //    DateTime dateTime2 = changedEventEndDate;
    //  //    if (!eventDate2.HasValue)
    //  //      return false;
    //  //    return eventDate2.GetValueOrDefault() <= dateTime2;
    //  //  })))), Enumerable.AsEnumerable<fb_Items>((IEnumerable<fb_Items>) list5), (Func<fb_Events, int?>) (ev => ev.get_FSSeventlist_intid()), (Func<fb_Items, int?>) (it => new int?(it.get_ItemEvent_intid())), (Func<fb_Events, fb_Items, fb_Items>) ((ev, it) => it)));
    //  //}
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass34.fromproddate = new DateTime();
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass34.fromtodate = new DateTime();
    //  //if (fromdate != "" && todate != "")
    //  //{
    //  //  // ISSUE: reference to a compiler-generated field
    //  //  cDisplayClass34.fromproddate = DateTime.ParseExact(fromdate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
    //  //  // ISSUE: reference to a compiler-generated field
    //  //  cDisplayClass34.fromtodate = DateTime.ParseExact(todate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
    //  //  ParameterExpression parameterExpression2;
    //  //  // ISSUE: method reference
    //  //  // ISSUE: field reference
    //  //  // ISSUE: method reference
    //  //  // ISSUE: method reference
    //  //  // ISSUE: field reference
    //  //  // ISSUE: method reference
    //  //  list5 = Enumerable.ToList<fb_Items>(Enumerable.Distinct<fb_Items>(Enumerable.Join(Enumerable.AsEnumerable<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Queryable.Distinct<fb_ProductionDates>(Queryable.Where<fb_ProductionDates>(productionDateService.FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass34), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass34.fromproddate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass34), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass34.fromtodate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual)))), new ParameterExpression[1]
    //  //  {
    //  //    parameterExpression2
    //  //  }))))), Enumerable.AsEnumerable<fb_Items>((IEnumerable<fb_Items>) list5), ev => new
    //  //  {
    //  //    a = ev.get_ItemId(),
    //  //    b = ev.get_EventID()
    //  //  }, it => new
    //  //  {
    //  //    a = it.get_Item_intid(),
    //  //    b = it.get_ItemEvent_intid()
    //  //  }, (Func<fb_ProductionDates, fb_Items, fb_Items>) ((ev, it) => it))));
    //  //}
    //  //if (show == 1)
    //  //{
    //  //  using (List<fb_Items>.Enumerator enumerator1 = list5.GetEnumerator())
    //  //  {
    //  //    while (enumerator1.MoveNext())
    //  //    {
    //  //      fb_Items current1 = enumerator1.Current;
    //  //      if (fromdate != "" && todate != "")
    //  //      {
    //  //        list1.Add(current1);
    //  //        // ISSUE: reference to a compiler-generated field
    //  //        cDisplayClass34.fromproddate = DateTime.ParseExact(fromdate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
    //  //        // ISSUE: reference to a compiler-generated field
    //  //        cDisplayClass34.fromtodate = DateTime.ParseExact(todate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
    //  //        // ISSUE: reference to a compiler-generated method
    //  //        using (List<fb_Items>.Enumerator enumerator2 = Enumerable.ToList<fb_Items>(Enumerable.Distinct<fb_Items>(Enumerable.Select(Enumerable.Where(Enumerable.Join(Enumerable.AsEnumerable<fb_Items>((IEnumerable<fb_Items>) this.GetSubItemsByMainItemIdAndEventID((string) (object) current1.get_ItemEvent_intid() + (object) "_" + (string) (object) current1.get_Item_intid())), Enumerable.AsEnumerable<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) productionDateService.FindAll()), sb => new
    //  //        {
    //  //          a = sb.get_Item_intid(),
    //  //          b = sb.get_ItemEvent_intid()
    //  //        }, pd => new
    //  //        {
    //  //          a = pd.get_ItemId(),
    //  //          b = pd.get_EventID()
    //  //        }, (sb, pd) => new
    //  //        {
    //  //          sb = sb,
    //  //          pd = pd
    //  //        }), new Func<\u003C\u003Ef__AnonymousTyped<fb_Items, fb_ProductionDates>, bool>(cDisplayClass34.\u003CGetItemsByItemNameOrderByEventID\u003Eb__22)), param0 => param0.sb))).GetEnumerator())
    //  //        {
    //  //          while (enumerator2.MoveNext())
    //  //          {
    //  //            fb_Items current2 = enumerator2.Current;
    //  //            list1.Add(current2);
    //  //          }
    //  //        }
    //  //      }
    //  //      else
    //  //      {
    //  //        List<fb_Items> itemIdAndEventId = this.GetSubItemsByMainItemIdAndEventID((string) (object) current1.get_ItemEvent_intid() + (object) "_" + (string) (object) current1.get_Item_intid());
    //  //        list1.Add(current1);
    //  //        using (List<fb_Items>.Enumerator enumerator2 = itemIdAndEventId.GetEnumerator())
    //  //        {
    //  //          while (enumerator2.MoveNext())
    //  //          {
    //  //            fb_Items current2 = enumerator2.Current;
    //  //            list1.Add(current2);
    //  //          }
    //  //        }
    //  //      }
    //  //    }
    //  //  }
    //  //}
    //  //else
    //  //  list1 = list5;
    //  //return list1;
    //    return null;
    //}

    ////public List<fb_ItemsStatusList> GetItemsListByTeamLeadandMemeber(int TeamID, int MemberID, DateTime ProductionDate)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  ItemsService.\u003C\u003Ec__DisplayClass3c cDisplayClass3c = new ItemsService.\u003C\u003Ec__DisplayClass3c();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass3c.TeamID = TeamID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass3c.MemberID = MemberID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass3c.ProductionDate = ProductionDate;
    ////  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    ////  ParameterExpression parameterExpression1;
    ////  ParameterExpression parameterExpression2;
    ////  ParameterExpression parameterExpression3;
    ////  ParameterExpression parameterExpression4;
    ////  ParameterExpression parameterExpression5;
    ////  ParameterExpression parameterExpression6;
    ////  ParameterExpression parameterExpression7;
    ////  ParameterExpression parameterExpression8;
    ////  ParameterExpression parameterExpression9;
    ////  ParameterExpression parameterExpression10;
    ////  ParameterExpression parameterExpression11;
    ////  ParameterExpression parameterExpression12;
    ////  ParameterExpression parameterExpression13;
    ////  ParameterExpression parameterExpression14;
    ////  ParameterExpression parameterExpression15;
    ////  ParameterExpression parameterExpression16;
    ////  ParameterExpression parameterExpression17;
    ////  ParameterExpression parameterExpression18;
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  return Enumerable.ToList<fb_ItemsStatusList>((IEnumerable<fb_ItemsStatusList>) Queryable.Select(Queryable.Where(Queryable.Join(Queryable.Join(Queryable.Join(Queryable.Join((IQueryable<fb_AssignedTeam>) flightBoardEntities.get_fb_AssignedTeam(), (IEnumerable<AssignItem>) flightBoardEntities.get_AssignItems(), Expression.Lambda<Func<fb_AssignedTeam, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression1
    ////  }), Expression.Lambda<Func<AssignItem, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_Id))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression2
    ////  }), Expression.Lambda<Func<fb_AssignedTeam, AssignItem, \u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression3,
    ////    (Expression) parameterExpression4
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_at), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_ai), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression3,
    ////    parameterExpression4
    ////  })), (IEnumerable<fb_ProductionDates>) flightBoardEntities.get_fb_ProductionDates(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, int>>((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_at), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression5
    ////  }), Expression.Lambda<Func<fb_ProductionDates, int>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_AssignItemID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression6
    ////  }), Expression.Lambda<Func<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates, \u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression7,
    ////    (Expression) parameterExpression8
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_pd), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression7,
    ////    parameterExpression8
    ////  })), (IEnumerable<fb_Items>) flightBoardEntities.get_fb_Items(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, int>>((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression9, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_ai), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression9
    ////  }), Expression.Lambda<Func<fb_Items, int>>((Expression) Expression.Property((Expression) parameterExpression10, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression10
    ////  }), Expression.Lambda<Func<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items, \u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression11,
    ////    (Expression) parameterExpression12
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_it), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression11,
    ////    parameterExpression12
    ////  })), (IEnumerable<fb_Events>) flightBoardEntities.get_fb_Events(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, int?>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression13, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_ai), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), typeof (int?)), new ParameterExpression[1]
    ////  {
    ////    parameterExpression13
    ////  }), Expression.Lambda<Func<fb_Events, int?>>((Expression) Expression.Property((Expression) parameterExpression14, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression14
    ////  }), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events, \u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression15,
    ////    (Expression) parameterExpression16
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_ev), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression15,
    ////    parameterExpression16
    ////  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_pd), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass3c.ProductionDate)))
    ////  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_at), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_TeamID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (object.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass3c.TeamID))), typeof (object))
    ////  })), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_at), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (object.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass3c.MemberID))), typeof (object))
    ////  })), new ParameterExpression[1]
    ////  {
    ////    parameterExpression17
    ////  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>, fb_ItemsStatusList>>((Expression) Expression.MemberInit(new fb_ItemsStatusList(), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_Contract)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_ev), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_Contract)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_EventID)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_ev), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_ItemID)), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_ai), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_ItemName)), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_it), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_Quantity)), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_it), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Quantity)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_Status)), (Expression) Expression.Constant((object) 0, typeof (int))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_TeamLeadID)), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_at), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_LeadID)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_TeamMemberID)), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>.get_\u003C\u003Eh__TransparentIdentifier3a), __typeref (\u003C\u003Ef__AnonymousType11<\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>, fb_Events>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>.get_\u003C\u003Eh__TransparentIdentifier39), __typeref (\u003C\u003Ef__AnonymousType10<\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier38), __typeref (\u003C\u003Ef__AnonymousTypef<\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>.get_at), __typeref (\u003C\u003Ef__AnonymousTypee<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatusList.set_Vessel)), (Expression) Expression.Constant((object) "", typeof (string)))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression18
    ////  })));
    ////}

    ////public fb_Items UpdateNotes(int itemId, int eventId, string notes)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  ItemsService.\u003C\u003Ec__DisplayClass3e cDisplayClass3e = new ItemsService.\u003C\u003Ec__DisplayClass3e();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass3e.itemId = itemId;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass3e.eventId = eventId;
    ////  ParameterExpression parameterExpression;
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  fb_Items entity = Queryable.FirstOrDefault<fb_Items>(Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass3e.itemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass3e.eventId))))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression
    ////  })));
    ////  if (entity == null)
    ////    return (fb_Items) null;
    ////  entity.set_Notes(notes);
    ////  this.Update(entity, true);
    ////  return entity;
    ////}

    ////public fb_Items GetNotesByEventItemBYId(int ItemID, int EventId)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  ItemsService.\u003C\u003Ec__DisplayClass40 cDisplayClass40 = new ItemsService.\u003C\u003Ec__DisplayClass40();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass40.ItemID = ItemID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass40.EventId = EventId;
    ////  ParameterExpression parameterExpression;
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  return Queryable.FirstOrDefault<fb_Items>(Queryable.Where<fb_Items>(this.FindAll(), Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass40.ItemID)))
    ////  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass40.EventId)))
    ////  })), new ParameterExpression[1]
    ////  {
    ////    parameterExpression
    ////  })));
    ////}

    ////public List<fb_Items> DeleteItems(List<fb_Items> deleteItemsList)
    ////{
    ////  using (List<fb_Items>.Enumerator enumerator1 = deleteItemsList.GetEnumerator())
    ////  {
    ////    while (enumerator1.MoveNext())
    ////    {
    ////      // ISSUE: object of a compiler-generated type is created
    ////      // ISSUE: variable of a compiler-generated type
    ////      ItemsService.\u003C\u003Ec__DisplayClass42 cDisplayClass42 = new ItemsService.\u003C\u003Ec__DisplayClass42();
    ////      // ISSUE: reference to a compiler-generated field
    ////      cDisplayClass42.item = enumerator1.Current;
    ////      // ISSUE: object of a compiler-generated type is created
    ////      // ISSUE: variable of a compiler-generated type
    ////      ItemsService.\u003C\u003Ec__DisplayClass44 cDisplayClass44 = new ItemsService.\u003C\u003Ec__DisplayClass44();
    ////      // ISSUE: reference to a compiler-generated field
    ////      cDisplayClass44.CS\u0024\u003C\u003E8__locals43 = cDisplayClass42;
    ////      // ISSUE: reference to a compiler-generated field
    ////      // ISSUE: reference to a compiler-generated field
    ////      cDisplayClass44.strItemId = Convert.ToString(cDisplayClass42.item.get_Item_intid());
    ////      IQueryable<fb_Items> all1 = this.FindAll();
    ////      ParameterExpression parameterExpression1;
    ////      // ISSUE: method reference
    ////      // ISSUE: field reference
    ////      // ISSUE: method reference
    ////      // ISSUE: method reference
    ////      // ISSUE: method reference
    ////      // ISSUE: field reference
    ////      Expression<Func<fb_Items, bool>> predicate1 = Expression.Lambda<Func<fb_Items, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass42), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass42.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid)))), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_UniQueItemIds))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), new Expression[1]
    ////      {
    ////        (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass44), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass44.strItemId)))
    ////      })), new ParameterExpression[1]
    ////      {
    ////        parameterExpression1
    ////      });
    ////      using (List<fb_Items>.Enumerator enumerator2 = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) Queryable.Where<fb_Items>(all1, predicate1)).GetEnumerator())
    ////      {
    ////        while (enumerator2.MoveNext())
    ////        {
    ////          // ISSUE: object of a compiler-generated type is created
    ////          // ISSUE: variable of a compiler-generated type
    ////          ItemsService.\u003C\u003Ec__DisplayClass46 cDisplayClass46 = new ItemsService.\u003C\u003Ec__DisplayClass46();
    ////          // ISSUE: reference to a compiler-generated field
    ////          cDisplayClass46.CS\u0024\u003C\u003E8__locals45 = cDisplayClass44;
    ////          // ISSUE: reference to a compiler-generated field
    ////          cDisplayClass46.CS\u0024\u003C\u003E8__locals43 = cDisplayClass42;
    ////          // ISSUE: reference to a compiler-generated field
    ////          cDisplayClass46.delItem = enumerator2.Current;
    ////          // ISSUE: reference to a compiler-generated field
    ////          this.Delete(cDisplayClass46.delItem, true);
    ////          using (AssignItemService assignItemService = new AssignItemService())
    ////          {
    ////            // ISSUE: reference to a compiler-generated field
    ////            // ISSUE: reference to a compiler-generated field
    ////            assignItemService.DeleteAssignItems(cDisplayClass46.delItem.get_Item_intid(), cDisplayClass46.delItem.get_ItemEvent_intid());
    ////          }
    ////          using (BatchService batchService = new BatchService())
    ////          {
    ////            IQueryable<fb_BatchItems> all2 = new BatchItemService().FindAll();
    ////            ParameterExpression parameterExpression2;
    ////            // ISSUE: method reference
    ////            // ISSUE: field reference
    ////            // ISSUE: method reference
    ////            Expression<Func<fb_BatchItems, bool>> predicate2 = Expression.Lambda<Func<fb_BatchItems, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_ItemID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass46), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass46.delItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid)))), new ParameterExpression[1]
    ////            {
    ////              parameterExpression2
    ////            });
    ////            using (List<fb_BatchItems>.Enumerator enumerator3 = Enumerable.ToList<fb_BatchItems>((IEnumerable<fb_BatchItems>) Queryable.Where<fb_BatchItems>(all2, predicate2)).GetEnumerator())
    ////            {
    ////              while (enumerator3.MoveNext())
    ////              {
    ////                // ISSUE: object of a compiler-generated type is created
    ////                // ISSUE: variable of a compiler-generated type
    ////                ItemsService.\u003C\u003Ec__DisplayClass48 cDisplayClass48 = new ItemsService.\u003C\u003Ec__DisplayClass48();
    ////                // ISSUE: reference to a compiler-generated field
    ////                cDisplayClass48.CS\u0024\u003C\u003E8__locals47 = cDisplayClass46;
    ////                // ISSUE: reference to a compiler-generated field
    ////                cDisplayClass48.CS\u0024\u003C\u003E8__locals45 = cDisplayClass44;
    ////                // ISSUE: reference to a compiler-generated field
    ////                cDisplayClass48.CS\u0024\u003C\u003E8__locals43 = cDisplayClass42;
    ////                // ISSUE: reference to a compiler-generated field
    ////                cDisplayClass48.batchItem = enumerator3.Current;
    ////                ParameterExpression parameterExpression3;
    ////                // ISSUE: method reference
    ////                // ISSUE: field reference
    ////                // ISSUE: method reference
    ////                fb_Batches entity = Queryable.FirstOrDefault<fb_Batches>(Queryable.Where<fb_Batches>(batchService.FindAll(), Expression.Lambda<Func<fb_Batches, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Batches.get_ID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass48), FieldInfo.GetFieldFromHandle(__fieldref (ItemsService.\u003C\u003Ec__DisplayClass48.batchItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_BatchID)))), new ParameterExpression[1]
    ////                {
    ////                  parameterExpression3
    ////                })));
    ////                if (entity != null)
    ////                  batchService.Delete(entity, true);
    ////              }
    ////            }
    ////          }
    ////        }
    ////      }
    ////    }
    ////  }
    ////  return deleteItemsList;
    ////}
  }
}
