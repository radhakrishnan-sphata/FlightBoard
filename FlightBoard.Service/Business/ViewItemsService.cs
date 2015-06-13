// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.ViewItemsService
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using FlightBoard.Service.Business.DataModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace FlightBoard.Service.Business
{
  public class ViewItemsService : BusinessServiceBase<vw_GetAllAssignedItemDetails>
  {
    //private static ViewItemsService defaultInstance = new ViewItemsService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static ViewItemsService Default
    //{
    //  get
    //  {
    //    return ViewItemsService.defaultInstance;
    //  }
    //}

    //public ViewItemsService()
    //{
    //}

    //public ViewItemsService(Repository<vw_GetAllAssignedItemDetails> repository)
    //  : base(repository)
    //{
    //}

    public ViewItemsService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public fb_ItemStatusCount GetStatusCountByProductionDateAndTeamId(string productionDate, int teamID, int memberId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ViewItemsService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new ViewItemsService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.teamID = teamID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.memberId = memberId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.productionChangedDate = DateHelper.ConverStringToDateTimeFormat(productionDate, "MM/dd/yyyy");
    //  fb_ItemStatusCount fbItemStatusCount = new fb_ItemStatusCount();
    //  ParameterExpression parameterExpression1;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  fbItemStatusCount.Done = Queryable.Count<vw_GetAllAssignedItemDetails>(Queryable.Where<vw_GetAllAssignedItemDetails>(this.FindAll(), Expression.Lambda<Func<vw_GetAllAssignedItemDetails, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.teamID))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.memberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_StatusID))), (Expression) Expression.Constant((object) 2, typeof (int)))), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  })));
    //  ParameterExpression parameterExpression2;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  fbItemStatusCount.Done = fbItemStatusCount.Done + Queryable.Count<vw_GetAllAssignedItemDetails>(Queryable.Where<vw_GetAllAssignedItemDetails>(this.FindAll(), Expression.Lambda<Func<vw_GetAllAssignedItemDetails, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.teamID))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.memberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_StatusID))), (Expression) Expression.Constant((object) 4, typeof (int)))), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  })));
    //  ParameterExpression parameterExpression3;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  fbItemStatusCount.Suspend = Queryable.Count<vw_GetAllAssignedItemDetails>(Queryable.Where<vw_GetAllAssignedItemDetails>(this.FindAll(), Expression.Lambda<Func<vw_GetAllAssignedItemDetails, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.teamID))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.memberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_StatusID))), (Expression) Expression.Constant((object) 1, typeof (int)))), new ParameterExpression[1]
    //  {
    //    parameterExpression3
    //  })));
    //  ParameterExpression parameterExpression4;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  fbItemStatusCount.Due = Queryable.Count<vw_GetAllAssignedItemDetails>(Queryable.Where<vw_GetAllAssignedItemDetails>(this.FindAll(), Expression.Lambda<Func<vw_GetAllAssignedItemDetails, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.teamID))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.memberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_StatusID))), (Expression) Expression.Constant((object) 3, typeof (int)))), new ParameterExpression[1]
    //  {
    //    parameterExpression4
    //  })));
    //  ParameterExpression parameterExpression5;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  fbItemStatusCount.YetToStart = Queryable.Count<vw_GetAllAssignedItemDetails>(Queryable.Where<vw_GetAllAssignedItemDetails>(this.FindAll(), Expression.Lambda<Func<vw_GetAllAssignedItemDetails, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.teamID))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass0.memberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_StatusID))), (Expression) Expression.Constant((object) 0, typeof (int)))), new ParameterExpression[1]
    //  {
    //    parameterExpression5
    //  })));
    //  return fbItemStatusCount;
    //}

    //public List<fb_ItemsActionStatus_View> GetItemStatusDetails(string productionDate, int teamID, int memberId, int itemID = 0, int eventId = 0)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  //ViewItemsService.\u003C\u003Ec__DisplayClass12 cDisplayClass12 = new ViewItemsService.\u003C\u003Ec__DisplayClass12();
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass12.teamID = teamID;
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass12.memberId = memberId;
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass12.itemID = itemID;
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass12.eventId = eventId;
    //  //// ISSUE: reference to a compiler-generated field
    //  //cDisplayClass12.productionChangedDate = DateHelper.ConverStringToDateTimeFormat(productionDate, "MM/dd/yyyy");
    //  //ParameterExpression parameterExpression;
    //  //// ISSUE: method reference
    //  //// ISSUE: field reference
    //  //// ISSUE: method reference
    //  //// ISSUE: field reference
    //  //// ISSUE: method reference
    //  //// ISSUE: field reference
    //  //// ISSUE: method reference
    //  //List<vw_GetAllAssignedItemDetails> list1 = Enumerable.ToList<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) Queryable.Where<vw_GetAllAssignedItemDetails>(this.FindAll(), Expression.Lambda<Func<vw_GetAllAssignedItemDetails, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass12), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass12.teamID))), typeof (int?))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass12), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass12.memberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (vw_GetAllAssignedItemDetails.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass12), FieldInfo.GetFieldFromHandle(__fieldref (ViewItemsService.\u003C\u003Ec__DisplayClass12.productionChangedDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality)))), new ParameterExpression[1]
    //  //{
    //  //  parameterExpression
    //  //})));
    //  //// ISSUE: reference to a compiler-generated field
    //  //// ISSUE: reference to a compiler-generated field
    //  //if (cDisplayClass12.itemID > 0 && cDisplayClass12.eventId > 0)
    //  //{
    //  //  // ISSUE: reference to a compiler-generated method
    //  //  list1 = Enumerable.ToList<vw_GetAllAssignedItemDetails>(Enumerable.Where<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) list1, new Func<vw_GetAllAssignedItemDetails, bool>(cDisplayClass12.\u003CGetItemStatusDetails\u003Eb__7)));
    //  //}
    //  //List<fb_ItemsActionStatus_View> list2 = new List<fb_ItemsActionStatus_View>();
    //  //if (list1 != null && list1.Count > 0)
    //  //{
    //  //  using (IEnumerator<vw_GetAllAssignedItemDetails> enumerator = Enumerable.Where<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) list1, (Func<vw_GetAllAssignedItemDetails, bool>) (x => x.get_StatusID() == 0)).GetEnumerator())
    //  //  {
    //  //    while (((IEnumerator) enumerator).MoveNext())
    //  //    {
    //  //      vw_GetAllAssignedItemDetails current = enumerator.Current;
    //  //      list2.Add(new fb_ItemsActionStatus_View()
    //  //      {
    //  //        Id = current.get_Id(),
    //  //        EventId = current.get_EventId(),
    //  //        Contract = current.get_Contract(),
    //  //        EventName = current.get_EventName(),
    //  //        eventQuantity = current.get_eventQuantity(),
    //  //        FirstName = current.get_FirstName(),
    //  //        ItemId = current.get_ItemId(),
    //  //        ItemName = current.get_ItemName(),
    //  //        LastName = current.get_LastName(),
    //  //        LeadID = current.get_LeadID(),
    //  //        MemberID = current.get_MemberID(),
    //  //        ProdcutionDate = current.get_ProdcutionDate(),
    //  //        Quantity = current.get_Quantity(),
    //  //        StatusID = new int?(current.get_StatusID()),
    //  //        StatusName = current.get_StatusName(),
    //  //        TeamID = current.get_TeamID(),
    //  //        UserId = current.get_UserId(),
    //  //        Notes = current.get_Notes(),
    //  //        AssignedNotes = current.get_AssignedNotes(),
    //  //        IsBatch = false
    //  //      });
    //  //    }
    //  //  }
    //  //  using (IEnumerator<vw_GetAllAssignedItemDetails> enumerator = Enumerable.Where<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) list1, (Func<vw_GetAllAssignedItemDetails, bool>) (x => x.get_StatusID() == 1)).GetEnumerator())
    //  //  {
    //  //    while (((IEnumerator) enumerator).MoveNext())
    //  //    {
    //  //      vw_GetAllAssignedItemDetails current = enumerator.Current;
    //  //      list2.Add(new fb_ItemsActionStatus_View()
    //  //      {
    //  //        Id = current.get_Id(),
    //  //        EventId = current.get_EventId(),
    //  //        Contract = current.get_Contract(),
    //  //        EventName = current.get_EventName(),
    //  //        eventQuantity = current.get_eventQuantity(),
    //  //        FirstName = current.get_FirstName(),
    //  //        ItemId = current.get_ItemId(),
    //  //        ItemName = current.get_ItemName(),
    //  //        LastName = current.get_LastName(),
    //  //        LeadID = current.get_LeadID(),
    //  //        MemberID = current.get_MemberID(),
    //  //        ProdcutionDate = current.get_ProdcutionDate(),
    //  //        Quantity = current.get_Quantity(),
    //  //        StatusID = new int?(current.get_StatusID()),
    //  //        StatusName = current.get_StatusName(),
    //  //        TeamID = current.get_TeamID(),
    //  //        UserId = current.get_UserId(),
    //  //        Notes = current.get_Notes(),
    //  //        AssignedNotes = current.get_AssignedNotes(),
    //  //        IsBatch = false
    //  //      });
    //  //    }
    //  //  }
    //  //  using (IEnumerator<vw_GetAllAssignedItemDetails> enumerator = Enumerable.Where<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) list1, (Func<vw_GetAllAssignedItemDetails, bool>) (x => x.get_StatusID() == 3)).GetEnumerator())
    //  //  {
    //  //    while (((IEnumerator) enumerator).MoveNext())
    //  //    {
    //  //      vw_GetAllAssignedItemDetails current = enumerator.Current;
    //  //      list2.Add(new fb_ItemsActionStatus_View()
    //  //      {
    //  //        Id = current.get_Id(),
    //  //        EventId = current.get_EventId(),
    //  //        Contract = current.get_Contract(),
    //  //        EventName = current.get_EventName(),
    //  //        eventQuantity = current.get_eventQuantity(),
    //  //        FirstName = current.get_FirstName(),
    //  //        ItemId = current.get_ItemId(),
    //  //        ItemName = current.get_ItemName(),
    //  //        LastName = current.get_LastName(),
    //  //        LeadID = current.get_LeadID(),
    //  //        MemberID = current.get_MemberID(),
    //  //        ProdcutionDate = current.get_ProdcutionDate(),
    //  //        Quantity = current.get_Quantity(),
    //  //        StatusID = new int?(current.get_StatusID()),
    //  //        StatusName = current.get_StatusName(),
    //  //        TeamID = current.get_TeamID(),
    //  //        UserId = current.get_UserId(),
    //  //        Notes = current.get_Notes(),
    //  //        AssignedNotes = current.get_AssignedNotes(),
    //  //        IsBatch = false
    //  //      });
    //  //    }
    //  //  }
    //  //  using (IEnumerator<vw_GetAllAssignedItemDetails> enumerator = Enumerable.Where<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) list1, (Func<vw_GetAllAssignedItemDetails, bool>) (x => x.get_StatusID() == 2)).GetEnumerator())
    //  //  {
    //  //    while (((IEnumerator) enumerator).MoveNext())
    //  //    {
    //  //      vw_GetAllAssignedItemDetails current = enumerator.Current;
    //  //      list2.Add(new fb_ItemsActionStatus_View()
    //  //      {
    //  //        Id = current.get_Id(),
    //  //        EventId = current.get_EventId(),
    //  //        Contract = current.get_Contract(),
    //  //        EventName = current.get_EventName(),
    //  //        eventQuantity = current.get_eventQuantity(),
    //  //        FirstName = current.get_FirstName(),
    //  //        ItemId = current.get_ItemId(),
    //  //        ItemName = current.get_ItemName(),
    //  //        LastName = current.get_LastName(),
    //  //        LeadID = current.get_LeadID(),
    //  //        MemberID = current.get_MemberID(),
    //  //        ProdcutionDate = current.get_ProdcutionDate(),
    //  //        Quantity = current.get_Quantity(),
    //  //        StatusID = new int?(current.get_StatusID()),
    //  //        StatusName = current.get_StatusName(),
    //  //        TeamID = current.get_TeamID(),
    //  //        UserId = current.get_UserId(),
    //  //        Notes = current.get_Notes(),
    //  //        AssignedNotes = current.get_AssignedNotes(),
    //  //        IsBatch = false
    //  //      });
    //  //    }
    //  //  }
    //  //  using (IEnumerator<vw_GetAllAssignedItemDetails> enumerator = Enumerable.Where<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) list1, (Func<vw_GetAllAssignedItemDetails, bool>) (x => x.get_StatusID() == 4)).GetEnumerator())
    //  //  {
    //  //    while (((IEnumerator) enumerator).MoveNext())
    //  //    {
    //  //      vw_GetAllAssignedItemDetails current = enumerator.Current;
    //  //      list2.Add(new fb_ItemsActionStatus_View()
    //  //      {
    //  //        Id = current.get_Id(),
    //  //        EventId = current.get_EventId(),
    //  //        Contract = current.get_Contract(),
    //  //        EventName = current.get_EventName(),
    //  //        eventQuantity = current.get_eventQuantity(),
    //  //        FirstName = current.get_FirstName(),
    //  //        ItemId = current.get_ItemId(),
    //  //        ItemName = current.get_ItemName(),
    //  //        LastName = current.get_LastName(),
    //  //        LeadID = current.get_LeadID(),
    //  //        MemberID = current.get_MemberID(),
    //  //        ProdcutionDate = current.get_ProdcutionDate(),
    //  //        Quantity = current.get_Quantity(),
    //  //        StatusID = new int?(current.get_StatusID()),
    //  //        StatusName = current.get_StatusName(),
    //  //        TeamID = current.get_TeamID(),
    //  //        UserId = current.get_UserId(),
    //  //        Notes = current.get_Notes(),
    //  //        AssignedNotes = current.get_AssignedNotes(),
    //  //        IsBatch = false
    //  //      });
    //  //    }
    //  //  }
    //  //}
    //  //return list2;

    //    return null;
    //}

    //public List<fb_ItemsActionStatus_View> GetBatchedItemDetails(string productionDate, int itemID, int memberId, int teamId)
    //{
    //  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    //  DateTime productionChangedDate = DateHelper.ConverStringToDateTimeFormat(productionDate, "MM/dd/yyyy");
    //  BatchItemService batchItemService = new BatchItemService(this._dbContext);
    //  List<fb_ItemsActionStatus_View> list1 = new List<fb_ItemsActionStatus_View>();
    //  List<vw_GetAllAssignedItemDetails> list2 = Enumerable.ToList<vw_GetAllAssignedItemDetails>(Enumerable.Select(Enumerable.Where(Enumerable.Join(Enumerable.AsEnumerable<vw_GetAllAssignedItemDetails>((IEnumerable<vw_GetAllAssignedItemDetails>) this.FindAll()), Enumerable.AsEnumerable<fb_BatchItems>((IEnumerable<fb_BatchItems>) batchItemService.FindAll()), vw => new
    //  {
    //    a = vw.get_EventId(),
    //    b = vw.get_ItemId()
    //  }, fbi => new
    //  {
    //    a = fbi.get_EventID(),
    //    b = fbi.get_ItemID()
    //  }, (vw, fbi) => new
    //  {
    //    vw = vw,
    //    fbi = fbi
    //  }), param0 =>
    //  {
    //    if (param0.vw.get_ItemId().Equals(itemID) && param0.vw.get_ProdcutionDate() == productionChangedDate)
    //    {
    //      int? memberId1 = param0.vw.get_MemberID();
    //      int num1 = memberId;
    //      if ((memberId1.GetValueOrDefault() != num1 ? 0 : (memberId1.HasValue ? 1 : 0)) != 0)
    //      {
    //        int? teamId1 = param0.vw.get_TeamID();
    //        int num2 = teamId;
    //        if (teamId1.GetValueOrDefault() == num2)
    //          return teamId1.HasValue;
    //        return false;
    //      }
    //    }
    //    return false;
    //  }), param0 => param0.vw));
    //  if (list2 != null && list2.Count > 0)
    //  {
    //    using (List<vw_GetAllAssignedItemDetails>.Enumerator enumerator = list2.GetEnumerator())
    //    {
    //      while (enumerator.MoveNext())
    //      {
    //        vw_GetAllAssignedItemDetails current = enumerator.Current;
    //        list1.Add(new fb_ItemsActionStatus_View()
    //        {
    //          Id = current.get_Id(),
    //          EventId = current.get_EventId(),
    //          Contract = current.get_Contract(),
    //          EventName = current.get_EventName(),
    //          eventQuantity = current.get_eventQuantity(),
    //          FirstName = current.get_FirstName(),
    //          ItemId = current.get_ItemId(),
    //          ItemName = current.get_ItemName(),
    //          LastName = current.get_LastName(),
    //          LeadID = current.get_LeadID(),
    //          MemberID = current.get_MemberID(),
    //          ProdcutionDate = current.get_ProdcutionDate(),
    //          Quantity = current.get_Quantity(),
    //          StatusID = new int?(current.get_StatusID()),
    //          StatusName = current.get_StatusName(),
    //          TeamID = current.get_TeamID(),
    //          UserId = current.get_UserId(),
    //          Notes = current.get_Notes(),
    //          AssignedNotes = current.get_AssignedNotes()
    //        });
    //      }
    //    }
    //  }
    //  return list1;
    //}

    //public List<fb_EventStatusModel> GetEventStatusByProductionDate(string ProductionDate)
    //{
    //  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    //  List<fb_EventStatusModel> list1 = new List<fb_EventStatusModel>();
    //  DateTime dateTime = DateHelper.ConverStringToDateTimeFormat(ProductionDate, "MM/dd/yyyy");
    //  List<ProcGetEventStatusByProductionDate_Result> list2 = Enumerable.ToList<ProcGetEventStatusByProductionDate_Result>((IEnumerable<ProcGetEventStatusByProductionDate_Result>) flightBoardEntities.ProcGetEventStatusByProductionDate1(new DateTime?(dateTime)));
    //  if (list2 != null && list2.Count > 0)
    //  {
    //    using (List<ProcGetEventStatusByProductionDate_Result>.Enumerator enumerator = list2.GetEnumerator())
    //    {
    //      while (enumerator.MoveNext())
    //      {
    //        ProcGetEventStatusByProductionDate_Result current = enumerator.Current;
    //        List<fb_EventStatusModel> list3 = list1;
    //        fb_EventStatusModel eventStatusModel1 = new fb_EventStatusModel();
    //        eventStatusModel1.ContractID = current.get_ContractID();
    //        eventStatusModel1.EventId = current.get_EventId();
    //        eventStatusModel1.TotalCompletedItemsCount = current.get_TotalCompletedItemsCount();
    //        eventStatusModel1.TotalItemCount = current.get_TotalItemCount();
    //        fb_EventStatusModel eventStatusModel2 = eventStatusModel1;
    //        int? completedItemsCount1 = current.get_TotalCompletedItemsCount();
    //        int? totalItemCount1 = current.get_TotalItemCount();
    //        int? nullable = completedItemsCount1.HasValue & totalItemCount1.HasValue ? new int?(completedItemsCount1.GetValueOrDefault() + totalItemCount1.GetValueOrDefault()) : new int?();
    //        Decimal num1;
    //        if ((nullable.GetValueOrDefault() != 0 ? 0 : (nullable.HasValue ? 1 : 0)) == 0)
    //        {
    //          int? completedItemsCount2 = current.get_TotalCompletedItemsCount();
    //          int? completedItemsCount3 = current.get_TotalCompletedItemsCount();
    //          int? totalItemCount2 = current.get_TotalItemCount();
    //          Decimal num2 = (Decimal) (completedItemsCount3.HasValue & totalItemCount2.HasValue ? new int?(completedItemsCount3.GetValueOrDefault() + totalItemCount2.GetValueOrDefault()) : new int?()).Value;
    //          num1 = Decimal.Round((completedItemsCount2.HasValue ? new Decimal?((Decimal) completedItemsCount2.GetValueOrDefault() / num2) : new Decimal?()).Value * new Decimal(100));
    //        }
    //        else
    //          num1 = new Decimal(0);
    //        eventStatusModel2.ProgressPercent = num1;
    //        fb_EventStatusModel eventStatusModel3 = eventStatusModel1;
    //        list3.Add(eventStatusModel3);
    //      }
    //    }
    //  }
    //  return list1;
    //}
  }
}
