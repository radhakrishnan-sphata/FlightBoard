// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.ProductionDateService
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
  public class ProductionDateService : BusinessServiceBase<fb_ProductionDates>
  {
    //private static ProductionDateService defaultInstance = new ProductionDateService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static ProductionDateService Default
    //{
    //  get
    //  {
    //    return ProductionDateService.defaultInstance;
    //  }
    //}

    public ProductionDateService()
    {
    }

      public ProductionDateService(Repository<fb_ProductionDates> repository)
          : base(repository)
      {
      }

    public ProductionDateService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public List<fb_ProductionDates_Data> GetProductionDatesByItemId(int[] items, int eventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ProductionDateService.\u003C\u003Ec__DisplayClass8 cDisplayClass8 = new ProductionDateService.\u003C\u003Ec__DisplayClass8();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass8.items = items;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass8.eventId = eventId;
    //  List<fb_Items> list = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) new ItemsService(this._dbContext).FindAll());
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  return Enumerable.ToList<fb_ProductionDates_Data>(Enumerable.Join((IEnumerable<fb_ProductionDates>) Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Queryable.Where<fb_ProductionDates>(this.FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass8), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClass8.eventId)))
    //  }), (Expression) Expression.Call((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (Enumerable.Contains)), new Expression[2]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass8), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClass8.items))),
    //    (Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId)))
    //  })), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }))), (IEnumerable<fb_Items>) list, item => new
    //  {
    //    a = item.get_ItemId(),
    //    b = item.get_EventID()
    //  }, item1 => new
    //  {
    //    a = item1.get_Item_intid(),
    //    b = item1.get_ItemEvent_intid()
    //  }, (Func<fb_ProductionDates, fb_Items, fb_ProductionDates_Data>) ((item, item1) =>
    //  {
    //    fb_ProductionDates_Data productionDatesData1 = new fb_ProductionDates_Data();
    //    productionDatesData1.EventId = item.get_EventID();
    //    productionDatesData1.ItemId = item.get_ItemId();
    //    productionDatesData1.ID = item.get_ID();
    //    productionDatesData1.ItemName = item1.get_ItemName();
    //    fb_ProductionDates_Data productionDatesData2 = productionDatesData1;
    //    item.get_ProdcutionDate();
    //    DateTime prodcutionDate = item.get_ProdcutionDate();
    //    productionDatesData2.ProductionDate = prodcutionDate;
    //    return productionDatesData1;
    //  })));
    //}

    //public List<fb_ProductionDates_Data> GetAllProductionDatesBySingleItemId(int itemId, int eventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ProductionDateService.\u003C\u003Ec__DisplayClassb cDisplayClassb = new ProductionDateService.\u003C\u003Ec__DisplayClassb();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassb.itemId = itemId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassb.eventId = eventId;
    //  ParameterExpression parameterExpression1;
    //  ParameterExpression parameterExpression2;
    //  ParameterExpression parameterExpression3;
    //  ParameterExpression parameterExpression4;
    //  ParameterExpression parameterExpression5;
    //  ParameterExpression parameterExpression6;
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  return Enumerable.ToList<fb_ProductionDates_Data>((IEnumerable<fb_ProductionDates_Data>) Queryable.Select(Queryable.Where(Queryable.Join(this.FindAll(), (IEnumerable<fb_Items>) new ItemsService(this._dbContext).FindAll(), Expression.Lambda<Func<fb_ProductionDates, \u003C\u003Ef__AnonymousType9<int, int>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))),
    //    (Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID)))
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_a), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_b), __typeref (\u003C\u003Ef__AnonymousType9<int, int>))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  }), Expression.Lambda<Func<fb_Items, \u003C\u003Ef__AnonymousType9<int, int>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid))),
    //    (Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid)))
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_a), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_b), __typeref (\u003C\u003Ef__AnonymousType9<int, int>))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  }), Expression.Lambda<Func<fb_ProductionDates, fb_Items, \u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression3,
    //    (Expression) parameterExpression4
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item1), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression3,
    //    parameterExpression4
    //  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassb), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassb.eventId)))
    //  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassb), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassb.itemId)))
    //  })), new ParameterExpression[1]
    //  {
    //    parameterExpression5
    //  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>, fb_ProductionDates_Data>>((Expression) Expression.MemberInit(new fb_ProductionDates_Data(), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates_Data.set_EventId)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates_Data.set_ItemId)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates_Data.set_ID)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ID)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates_Data.set_ItemName)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item1), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates_Data.set_ProductionDate)), (Expression) Expression.Condition((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), typeof (DateTime?)), (Expression) Expression.Convert((Expression) Expression.Constant((object) new DateTime?(), typeof (DateTime?)), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))), (Expression) Expression.Property((Expression) null, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.get_Now))), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>.get_item), __typeref (\u003C\u003Ef__AnonymousTypea<fb_ProductionDates, fb_Items>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate)))))), new ParameterExpression[1]
    //  {
    //    parameterExpression6
    //  })));
    //}

    //public List<fb_ProductionDates> GetAllProductionDatesByItemId(int itemId, int eventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ProductionDateService.\u003C\u003Ec__DisplayClassd cDisplayClassd = new ProductionDateService.\u003C\u003Ec__DisplayClassd();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassd.itemId = itemId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassd.eventId = eventId;
    //  // ISSUE: reference to a compiler-generated field
    //  // ISSUE: reference to a compiler-generated field
    //  if (cDisplayClassd.itemId > 0 && cDisplayClassd.eventId > 0)
    //  {
    //    ParameterExpression parameterExpression;
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    return Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Queryable.Where<fb_ProductionDates>(this.FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassd.itemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassd.eventId))))), new ParameterExpression[1]
    //    {
    //      parameterExpression
    //    })));
    //  }
    //  ParameterExpression parameterExpression1;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Queryable.Where<fb_ProductionDates>(this.FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassd.eventId)))), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  })));
    //}

    //public void DeleteProductionDatesByItemIdandEventID(int itemId, int eventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ProductionDateService.\u003C\u003Ec__DisplayClassf cDisplayClassf = new ProductionDateService.\u003C\u003Ec__DisplayClassf();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassf.itemId = itemId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassf.eventId = eventId;
    //  IQueryable<fb_ProductionDates> all = this.FindAll();
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  Expression<Func<fb_ProductionDates, bool>> predicate = Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassf.itemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClassf.eventId))))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  });
    //  using (List<fb_ProductionDates>.Enumerator enumerator = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Queryable.Where<fb_ProductionDates>(all, predicate)).GetEnumerator())
    //  {
    //    while (enumerator.MoveNext())
    //      this.Delete(enumerator.Current, true);
    //  }
    //}

    //public List<fb_ProductionDates> UpdateProductionDatesByTeamId(string productionDate, string notes, int itemID = 0, int eventId = 0, int statusID = 0)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ProductionDateService.\u003C\u003Ec__DisplayClass11 cDisplayClass11 = new ProductionDateService.\u003C\u003Ec__DisplayClass11();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass11.itemID = itemID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass11.eventId = eventId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass11.productionChangedDate = DateHelper.ConverStringToDateTimeFormat(productionDate, "MM/dd/yyyy");
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  List<fb_ProductionDates> list = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) Queryable.Where<fb_ProductionDates>(this.FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClass11.itemID)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClass11.eventId))))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (ProductionDateService.\u003C\u003Ec__DisplayClass11.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //  using (List<fb_ProductionDates>.Enumerator enumerator = list.GetEnumerator())
    //  {
    //    while (enumerator.MoveNext())
    //    {
    //      fb_ProductionDates current = enumerator.Current;
    //      current.set_StatusID(new int?(statusID));
    //      current.set_Notes(notes);
    //      this.Update(current, true);
    //    }
    //  }
    //  return list;
    //}
  }
}
