// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.ItemsStatusService
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
  public class ItemsStatusService : BusinessServiceBase<fb_ItemsStatus>
  {
    //private static ItemsStatusService defaultInstance = new ItemsStatusService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static ItemsStatusService Default
    //{
    //  get
    //  {
    //    return ItemsStatusService.defaultInstance;
    //  }
    //}

    //public ItemsStatusService()
    //{
    //}

    //public ItemsStatusService(Repository<fb_ItemsStatus> repository)
    //  : base(repository)
    //{
    //}

    public ItemsStatusService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public List<fb_ItemsStatus> GetItemsStatusByLeadID(int TeamID, int MemberID, DateTime ProductionDate)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  ItemsStatusService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new ItemsStatusService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.TeamID = TeamID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.MemberID = MemberID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.ProductionDate = ProductionDate;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  return Enumerable.ToList<fb_ItemsStatus>((IEnumerable<fb_ItemsStatus>) Queryable.Where<fb_ItemsStatus>(this.FindAll(), Expression.Lambda<Func<fb_ItemsStatus, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatus.get_TeamID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ItemsStatusService.\u003C\u003Ec__DisplayClass0.TeamID)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatus.get_TeamMemberID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ItemsStatusService.\u003C\u003Ec__DisplayClass0.MemberID))))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ItemsStatus.get_ProductionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (ItemsStatusService.\u003C\u003Ec__DisplayClass0.ProductionDate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_Equality)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //}
  }
}
