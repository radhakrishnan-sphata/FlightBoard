// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.BatchItemService
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
  public class BatchItemService : BusinessServiceBase<fb_BatchItems>
  {
    //private static BatchItemService defaultInstance = new BatchItemService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static BatchItemService Default
    //{
    //  get
    //  {
    //    return BatchItemService.defaultInstance;
    //  }
    //}

      public BatchItemService()
      {
      }

    //public BatchItemService(Repository<fb_BatchItems> repository)
    //  : base(repository)
    //{
    //}

    public BatchItemService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public List<fb_BatchItems> GetBatchItems(int eventID, int ItemId)
    //{
    //  return Enumerable.ToList<fb_BatchItems>(Enumerable.Select(Enumerable.Where(Enumerable.Join(Enumerable.AsEnumerable<fb_Batches>((IEnumerable<fb_Batches>) new BatchService().FindAll()), Enumerable.AsEnumerable<fb_BatchItems>((IEnumerable<fb_BatchItems>) this.FindAll()), (Func<fb_Batches, int>) (b => b.get_ID()), (Func<fb_BatchItems, int>) (bi => bi.get_BatchID()), (b, bi) => new
    //  {
    //    b = b,
    //    bi = bi
    //  }), param0 =>
    //  {
    //    if (param0.bi.get_EventID() == eventID)
    //      return param0.bi.get_ItemID() == ItemId;
    //    return false;
    //  }), param0 => param0.bi));
    //}

    ////public string GetBatch(int ItemID, int EventID, bool IsSubItem)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  BatchItemService.\u003C\u003Ec__DisplayClassf cDisplayClassf = new BatchItemService.\u003C\u003Ec__DisplayClassf();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClassf.ItemID = ItemID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClassf.EventID = EventID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClassf.IsSubItem = IsSubItem;
    ////  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    ////  ParameterExpression parameterExpression1;
    ////  ParameterExpression parameterExpression2;
    ////  ParameterExpression parameterExpression3;
    ////  ParameterExpression parameterExpression4;
    ////  ParameterExpression parameterExpression5;
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
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  List<fb_Batches> list = Enumerable.ToList<fb_Batches>((IEnumerable<fb_Batches>) Queryable.Select(Queryable.Where(Queryable.Join((IQueryable<fb_Batches>) flightBoardEntities.get_fb_Batches(), (IEnumerable<fb_BatchItems>) flightBoardEntities.get_fb_BatchItems(), Expression.Lambda<Func<fb_Batches, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Batches.get_ID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression1
    ////  }), Expression.Lambda<Func<fb_BatchItems, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_BatchID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression2
    ////  }), Expression.Lambda<Func<fb_Batches, fb_BatchItems, \u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression3,
    ////    (Expression) parameterExpression4
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_B), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression3,
    ////    parameterExpression4
    ////  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_EventID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClassf.EventID)))
    ////  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_ItemID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClassf.ItemID)))
    ////  })), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_IsSubItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (bool.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClassf.IsSubItem)))
    ////  })), new ParameterExpression[1]
    ////  {
    ////    parameterExpression5
    ////  })), \u003C\u003Eh__TransparentIdentifierc => \u003C\u003Eh__TransparentIdentifierc.B));
    ////  if (list.Count == 0)
    ////    return " Not yet Batched";
    ////  return Enumerable.FirstOrDefault<fb_Batches>((IEnumerable<fb_Batches>) Enumerable.OrderByDescending<fb_Batches, int>((IEnumerable<fb_Batches>) list, (Func<fb_Batches, int>) (x => x.get_ID()))).get_Name();
    ////}

    ////public string GetBatchColor(int ItemID, int EventID, bool IsSubItem)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  BatchItemService.\u003C\u003Ec__DisplayClass14 cDisplayClass14 = new BatchItemService.\u003C\u003Ec__DisplayClass14();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass14.ItemID = ItemID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass14.EventID = EventID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass14.IsSubItem = IsSubItem;
    ////  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    ////  ParameterExpression parameterExpression1;
    ////  ParameterExpression parameterExpression2;
    ////  ParameterExpression parameterExpression3;
    ////  ParameterExpression parameterExpression4;
    ////  ParameterExpression parameterExpression5;
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
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  List<fb_Batches> list = Enumerable.ToList<fb_Batches>((IEnumerable<fb_Batches>) Queryable.Select(Queryable.Where(Queryable.Join((IQueryable<fb_Batches>) flightBoardEntities.get_fb_Batches(), (IEnumerable<fb_BatchItems>) flightBoardEntities.get_fb_BatchItems(), Expression.Lambda<Func<fb_Batches, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Batches.get_ID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression1
    ////  }), Expression.Lambda<Func<fb_BatchItems, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_BatchID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression2
    ////  }), Expression.Lambda<Func<fb_Batches, fb_BatchItems, \u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression3,
    ////    (Expression) parameterExpression4
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_B), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression3,
    ////    parameterExpression4
    ////  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_EventID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass14), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClass14.EventID)))
    ////  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_ItemID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass14), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClass14.ItemID)))
    ////  })), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_IsSubItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (bool.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass14), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClass14.IsSubItem)))
    ////  })), new ParameterExpression[1]
    ////  {
    ////    parameterExpression5
    ////  })), \u003C\u003Eh__TransparentIdentifier11 => \u003C\u003Eh__TransparentIdentifier11.B));
    ////  if (list.Count == 0)
    ////    return string.Empty;
    ////  return Enumerable.FirstOrDefault<fb_Batches>((IEnumerable<fb_Batches>) Enumerable.OrderByDescending<fb_Batches, int>((IEnumerable<fb_Batches>) list, (Func<fb_Batches, int>) (x => x.get_ID()))).get_Color();
    ////}

    ////public List<fb_Batches> GetBatchItemDetails(int ItemId, int eventID, bool IsSubItem)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  BatchItemService.\u003C\u003Ec__DisplayClass17 cDisplayClass17 = new BatchItemService.\u003C\u003Ec__DisplayClass17();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass17.ItemId = ItemId;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass17.eventID = eventID;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass17.IsSubItem = IsSubItem;
    ////  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    ////  ParameterExpression parameterExpression1;
    ////  ParameterExpression parameterExpression2;
    ////  ParameterExpression parameterExpression3;
    ////  ParameterExpression parameterExpression4;
    ////  ParameterExpression parameterExpression5;
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
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: type reference
    ////  // ISSUE: method reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  return Enumerable.ToList<fb_Batches>((IEnumerable<fb_Batches>) Queryable.Select(Queryable.Where(Queryable.Join((IQueryable<fb_Batches>) flightBoardEntities.get_fb_Batches(), (IEnumerable<fb_BatchItems>) flightBoardEntities.get_fb_BatchItems(), Expression.Lambda<Func<fb_Batches, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Batches.get_ID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression1
    ////  }), Expression.Lambda<Func<fb_BatchItems, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_BatchID))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression2
    ////  }), Expression.Lambda<Func<fb_Batches, fb_BatchItems, \u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>)), (IEnumerable<Expression>) new Expression[2]
    ////  {
    ////    (Expression) parameterExpression3,
    ////    (Expression) parameterExpression4
    ////  }, (MemberInfo[]) new MethodInfo[2]
    ////  {
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_B), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>)),
    ////    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))
    ////  }), new ParameterExpression[2]
    ////  {
    ////    parameterExpression3,
    ////    parameterExpression4
    ////  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_EventID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass17), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClass17.eventID)))
    ////  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_ItemID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass17), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClass17.ItemId)))
    ////  })), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>.get_I), __typeref (\u003C\u003Ef__AnonymousType7<fb_Batches, fb_BatchItems>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_IsSubItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (bool.Equals)), new Expression[1]
    ////  {
    ////    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass17), FieldInfo.GetFieldFromHandle(__fieldref (BatchItemService.\u003C\u003Ec__DisplayClass17.IsSubItem)))
    ////  })), new ParameterExpression[1]
    ////  {
    ////    parameterExpression5
    ////  })), \u003C\u003Eh__TransparentIdentifier16 => \u003C\u003Eh__TransparentIdentifier16.B));
    ////}
  }
}
