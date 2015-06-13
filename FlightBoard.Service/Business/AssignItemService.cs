// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.AssignItemService
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
  public class AssignItemService : BusinessServiceBase<AssignItem>
  {
    //private static AssignItemService defaultInstance = new AssignItemService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static AssignItemService Default
    //{
    //  get
    //  {
    //    return AssignItemService.defaultInstance;
    //  }
    //}

    //public AssignItemService()
    //{
    //}

    //public AssignItemService(Repository<AssignItem> repository)
    //  : base(repository)
    //{
    //}

    //public AssignItemService(DbContext dbContext)
    //  : base(dbContext)
    //{
    //}

    //public AssignItem GetNotesByEventItemBYId(int ItemID, int EventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  AssignItemService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new AssignItemService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.ItemID = ItemID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.EventId = EventId;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Queryable.FirstOrDefault<AssignItem>(Queryable.Where<AssignItem>((IQueryable<AssignItem>) new FlightBoardEntities().get_AssignItems(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass0.ItemID)))
    //  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass0.EventId)))
    //  })), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public string GetItemTLName(int ItemId, int EventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  AssignItemService.\u003C\u003Ec__DisplayClass3 cDisplayClass3 = new AssignItemService.\u003C\u003Ec__DisplayClass3();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass3.ItemId = ItemId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass3.EventId = EventId;
    //  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    //  ParameterExpression parameterExpression1;
    //  ParameterExpression parameterExpression2;
    //  ParameterExpression parameterExpression3;
    //  ParameterExpression parameterExpression4;
    //  ParameterExpression parameterExpression5;
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
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  int num = Queryable.Count<fb_AssignedTeam>(Queryable.Select(Queryable.Where(Queryable.Join((IQueryable<AssignItem>) flightBoardEntities.get_AssignItems(), (IEnumerable<fb_AssignedTeam>) flightBoardEntities.get_fb_AssignedTeam(), Expression.Lambda<Func<AssignItem, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_Id))), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  }), Expression.Lambda<Func<fb_AssignedTeam, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  }), Expression.Lambda<Func<AssignItem, fb_AssignedTeam, \u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression3,
    //    (Expression) parameterExpression4
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>.get_T), __typeref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression3,
    //    parameterExpression4
    //  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass3.ItemId)))
    //  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType0<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass3.EventId)))
    //  })), new ParameterExpression[1]
    //  {
    //    parameterExpression5
    //  })), \u003C\u003Eh__TransparentIdentifier2 => \u003C\u003Eh__TransparentIdentifier2.T));
    //  if (num != 0)
    //    return num.ToString();
    //  return string.Empty;
    //}

    public List<fb_Teams_Data> GetTeammberonItems(int Itemid, int EventId)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //AssignItemService.\u003C\u003Ec__DisplayClass9 cDisplayClass9 = new AssignItemService.\u003C\u003Ec__DisplayClass9();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass9.Itemid = Itemid;
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass9.EventId = EventId;
      //FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
      //ParameterExpression parameterExpression1;
      //ParameterExpression parameterExpression2;
      //ParameterExpression parameterExpression3;
      //ParameterExpression parameterExpression4;
      //ParameterExpression parameterExpression5;
      //ParameterExpression parameterExpression6;
      //ParameterExpression parameterExpression7;
      //ParameterExpression parameterExpression8;
      //ParameterExpression parameterExpression9;
      //ParameterExpression parameterExpression10;
      //ParameterExpression parameterExpression11;
      //ParameterExpression parameterExpression12;
      //ParameterExpression parameterExpression13;
      //ParameterExpression parameterExpression14;
      //ParameterExpression parameterExpression15;
      //ParameterExpression parameterExpression16;
      //ParameterExpression parameterExpression17;
      //ParameterExpression parameterExpression18;
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: field reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: field reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: type reference
      //return Enumerable.ToList<fb_Teams_Data>((IEnumerable<fb_Teams_Data>) Enumerable.ToList<fb_Teams_Data>((IEnumerable<fb_Teams_Data>) Queryable.Select(Queryable.Where(Queryable.Join(Queryable.Join(Queryable.Join(Queryable.Join((IQueryable<AssignItem>) flightBoardEntities.get_AssignItems(), (IEnumerable<fb_AssignedTeam>) flightBoardEntities.get_fb_AssignedTeam(), Expression.Lambda<Func<AssignItem, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_Id))), new ParameterExpression[1]
      //{
      //  parameterExpression1
      //}), Expression.Lambda<Func<fb_AssignedTeam, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), new ParameterExpression[1]
      //{
      //  parameterExpression2
      //}), Expression.Lambda<Func<AssignItem, fb_AssignedTeam, \u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>)), (IEnumerable<Expression>) new Expression[2]
      //{
      //  (Expression) parameterExpression3,
      //  (Expression) parameterExpression4
      //}, (MemberInfo[]) new MethodInfo[2]
      //{
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))
      //}), new ParameterExpression[2]
      //{
      //  parameterExpression3,
      //  parameterExpression4
      //})), (IEnumerable<fb_Users>) flightBoardEntities.get_fb_Users(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, int?>>((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), new ParameterExpression[1]
      //{
      //  parameterExpression5
      //}), Expression.Lambda<Func<fb_Users, int?>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), typeof (int?)), new ParameterExpression[1]
      //{
      //  parameterExpression6
      //}), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users, \u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>)), (IEnumerable<Expression>) new Expression[2]
      //{
      //  (Expression) parameterExpression7,
      //  (Expression) parameterExpression8
      //}, (MemberInfo[]) new MethodInfo[2]
      //{
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_TM), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))
      //}), new ParameterExpression[2]
      //{
      //  parameterExpression7,
      //  parameterExpression8
      //})), (IEnumerable<fb_Users>) flightBoardEntities.get_fb_Users(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, int?>>((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression9, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_LeadID))), new ParameterExpression[1]
      //{
      //  parameterExpression9
      //}), Expression.Lambda<Func<fb_Users, int?>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression10, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), typeof (int?)), new ParameterExpression[1]
      //{
      //  parameterExpression10
      //}), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users, \u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>)), (IEnumerable<Expression>) new Expression[2]
      //{
      //  (Expression) parameterExpression11,
      //  (Expression) parameterExpression12
      //}, (MemberInfo[]) new MethodInfo[2]
      //{
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_TL), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))
      //}), new ParameterExpression[2]
      //{
      //  parameterExpression11,
      //  parameterExpression12
      //})), (IEnumerable<fb_Teams>) flightBoardEntities.get_fb_Teams(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, int?>>((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression13, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_TeamID))), new ParameterExpression[1]
      //{
      //  parameterExpression13
      //}), Expression.Lambda<Func<fb_Teams, int?>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression14, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamId))), typeof (int?)), new ParameterExpression[1]
      //{
      //  parameterExpression14
      //}), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams, \u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>)), (IEnumerable<Expression>) new Expression[2]
      //{
      //  (Expression) parameterExpression15,
      //  (Expression) parameterExpression16
      //}, (MemberInfo[]) new MethodInfo[2]
      //{
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>)),
      //  (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_T), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))
      //}), new ParameterExpression[2]
      //{
      //  parameterExpression15,
      //  parameterExpression16
      //})), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
      //{
      //  (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass9), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass9.Itemid)))
      //}), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
      //{
      //  (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass9), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass9.EventId)))
      //})), new ParameterExpression[1]
      //{
      //  parameterExpression17
      //})), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>, fb_Teams_Data>>((Expression) Expression.MemberInit(new fb_Teams_Data(), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamId)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_T), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamName)), (Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_T), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamLeadName)), (Expression) Expression.Add((Expression) Expression.Add((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_TL), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_FirstName))), (Expression) Expression.Constant((object) " ", typeof (string)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Concat))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_TL), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_LastName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Concat)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamMemberName)), (Expression) Expression.Add((Expression) Expression.Add((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_TM), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_FirstName))), (Expression) Expression.Constant((object) " ", typeof (string)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Concat))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_TM), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_LastName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Concat)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamLeadId)), (Expression) Expression.Condition((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_LeadID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_HasValue), __typeref (int?))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_LeadID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_Value), __typeref (int?))), (Expression) Expression.Constant((object) 0, typeof (int)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamMemberId)), (Expression) Expression.Condition((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_HasValue), __typeref (int?))), (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression18, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType4<\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>, fb_Teams>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType3<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<AssignItem, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_Value), __typeref (int?))), (Expression) Expression.Constant((object) 0, typeof (int))))), new ParameterExpression[1]
      //{
      //  parameterExpression18
      //}))));

        return null;
    }

    public void DeleteAssignItems(int id, int eventId)
    {
      //// ISSUE: object of a compiler-generated type is created
      //// ISSUE: variable of a compiler-generated type
      //AssignItemService.\u003C\u003Ec__DisplayClassb cDisplayClassb = new AssignItemService.\u003C\u003Ec__DisplayClassb();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClassb.id = id;
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClassb.eventId = eventId;
      //ParameterExpression parameterExpression;
      //// ISSUE: method reference
      //// ISSUE: field reference
      //// ISSUE: method reference
      //// ISSUE: field reference
      //List<AssignItem> list = Enumerable.ToList<AssignItem>((IEnumerable<AssignItem>) Queryable.Where<AssignItem>(this.FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassb), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClassb.id)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassb), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClassb.eventId))))), new ParameterExpression[1]
      //{
      //  parameterExpression
      //})));
      //if (list.Count <= 0)
      //  return;
      //using (List<AssignItem>.Enumerator enumerator = list.GetEnumerator())
      //{
      //  while (enumerator.MoveNext())
      //    this.Delete(enumerator.Current, true);
      //}
    }

    //public int GetAssignItemCount(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  AssignItemService.\u003C\u003Ec__DisplayClassd cDisplayClassd = new AssignItemService.\u003C\u003Ec__DisplayClassd();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassd.id = id;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) Queryable.Where<fb_AssignedTeam>((IQueryable<fb_AssignedTeam>) new FlightBoardEntities().get_fb_AssignedTeam(), Expression.Lambda<Func<fb_AssignedTeam, bool>>((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_TeamID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_Value), __typeref (int?))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClassd.id)))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  }))).Count;
    //}

    //public List<AssignItem> GetItemsByEventid(int EventId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  AssignItemService.\u003C\u003Ec__DisplayClassf cDisplayClassf = new AssignItemService.\u003C\u003Ec__DisplayClassf();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClassf.EventId = EventId;
    //  List<AssignItem> list = new List<AssignItem>();
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Enumerable.ToList<AssignItem>((IEnumerable<AssignItem>) Queryable.Where<AssignItem>(this.FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClassf.EventId)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}

    //public List<AssignItem> GetAssignItemsbyListOfItems(List<fb_Items> lstfbItems)
    //{
    //  return Enumerable.ToList<AssignItem>(Enumerable.Join<AssignItem, fb_Items, int, AssignItem>(Enumerable.AsEnumerable<AssignItem>((IEnumerable<AssignItem>) this.FindAll()), Enumerable.AsEnumerable<fb_Items>((IEnumerable<fb_Items>) lstfbItems), (Func<AssignItem, int>) (u => u.get_ItemId()), (Func<fb_Items, int>) (l => l.get_Item_intid()), (Func<AssignItem, fb_Items, AssignItem>) ((u, l) => u)));
    //}

    public string GetItemTLNameByItemId(int ItemId)
    {
      return string.Empty;
    }

    ////public List<fb_Items_Data> GetAssignItemsList(int ItemId, int EventId)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  AssignItemService.\u003C\u003Ec__DisplayClass19 cDisplayClass19 = new AssignItemService.\u003C\u003Ec__DisplayClass19();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass19.ItemId = ItemId;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass19.EventId = EventId;
    ////  using (AssignItemService assignItemService = new AssignItemService(this._dbContext))
    ////  {
    ////    EventsService eventsService = new EventsService(assignItemService._dbContext);
    ////    ProductionDateService productionDateService = new ProductionDateService(assignItemService._dbContext);
    ////    UserService userService = new UserService(assignItemService._dbContext);
    ////    List<fb_Items_Data> list1 = new List<fb_Items_Data>();
    ////    ItemsService itemsService = new ItemsService(assignItemService._dbContext);
    ////    IQueryable<AssignItem> all = this.FindAll();
    ////    ParameterExpression parameterExpression1;
    ////    // ISSUE: method reference
    ////    // ISSUE: field reference
    ////    // ISSUE: method reference
    ////    // ISSUE: field reference
    ////    Expression<Func<AssignItem, bool>> predicate = Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass19), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass19.EventId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass19), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass19.ItemId))))), new ParameterExpression[1]
    ////    {
    ////      parameterExpression1
    ////    });
    ////    using (List<AssignItem>.Enumerator enumerator = Enumerable.ToList<AssignItem>((IEnumerable<AssignItem>) Queryable.Where<AssignItem>(all, predicate)).GetEnumerator())
    ////    {
    ////      while (enumerator.MoveNext())
    ////      {
    ////        // ISSUE: object of a compiler-generated type is created
    ////        // ISSUE: variable of a compiler-generated type
    ////        AssignItemService.\u003C\u003Ec__DisplayClass1b cDisplayClass1b = new AssignItemService.\u003C\u003Ec__DisplayClass1b();
    ////        // ISSUE: reference to a compiler-generated field
    ////        cDisplayClass1b.CS\u0024\u003C\u003E8__locals1a = cDisplayClass19;
    ////        // ISSUE: reference to a compiler-generated field
    ////        cDisplayClass1b.item = enumerator.Current;
    ////        ParameterExpression parameterExpression2;
    ////        ParameterExpression parameterExpression3;
    ////        // ISSUE: method reference
    ////        // ISSUE: field reference
    ////        // ISSUE: method reference
    ////        // ISSUE: method reference
    ////        // ISSUE: field reference
    ////        // ISSUE: method reference
    ////        // ISSUE: method reference
    ////        List<DateTime> list2 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(productionDateService.FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass1b), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass1b.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass1b), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass1b.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))))), new ParameterExpression[1]
    ////        {
    ////          parameterExpression2
    ////        })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
    ////        {
    ////          parameterExpression3
    ////        })));
    ////        ParameterExpression parameterExpression4;
    ////        // ISSUE: method reference
    ////        // ISSUE: field reference
    ////        // ISSUE: method reference
    ////        string contract = Queryable.FirstOrDefault<fb_Events>(Queryable.Where<fb_Events>(eventsService.FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass1b), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass1b.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), typeof (int?))), new ParameterExpression[1]
    ////        {
    ////          parameterExpression4
    ////        }))).get_Contract();
    ////        // ISSUE: reference to a compiler-generated field
    ////        // ISSUE: reference to a compiler-generated field
    ////        list1.Add(new fb_Items_Data()
    ////        {
    ////          ItemId = cDisplayClass1b.item.get_ItemId(),
    ////          ContractID = contract,
    ////          EventID = cDisplayClass1b.item.get_EventId(),
    ////          ItemName = string.Empty,
    ////          ProductionFrom = list2.Count > 1 ? "Multiple" : (list2.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list2).ToString("MM/dd/yyyy")),
    ////          TeamMember = string.Empty
    ////        });
    ////      }
    ////    }
    ////    return list1;
    ////  }
    ////}

    ////public List<AssignItem> GetAssignItemsByEventIDItemId(int itemId, int eventId)
    ////{
    ////  // ISSUE: object of a compiler-generated type is created
    ////  // ISSUE: variable of a compiler-generated type
    ////  AssignItemService.\u003C\u003Ec__DisplayClass1d cDisplayClass1d = new AssignItemService.\u003C\u003Ec__DisplayClass1d();
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass1d.itemId = itemId;
    ////  // ISSUE: reference to a compiler-generated field
    ////  cDisplayClass1d.eventId = eventId;
    ////  ParameterExpression parameterExpression;
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  // ISSUE: method reference
    ////  // ISSUE: field reference
    ////  return Enumerable.ToList<AssignItem>((IEnumerable<AssignItem>) Queryable.Where<AssignItem>((IQueryable<AssignItem>) new FlightBoardEntities().get_AssignItems(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass1d), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass1d.eventId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass1d), FieldInfo.GetFieldFromHandle(__fieldref (AssignItemService.\u003C\u003Ec__DisplayClass1d.itemId))))), new ParameterExpression[1]
    ////  {
    ////    parameterExpression
    ////  })));
    ////}
  }
}
