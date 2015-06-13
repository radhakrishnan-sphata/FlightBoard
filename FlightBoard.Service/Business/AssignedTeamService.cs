

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
  public class AssignedTeamService : BusinessServiceBase<fb_AssignedTeam>
  {
    //private static BatchService defaultInstance = new BatchService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static BatchService Default
    //{
    //  get
    //  {
    //    return AssignedTeamService.defaultInstance;
    //  }
    //}

    //public AssignedTeamService()
    //{
    //}

    //public AssignedTeamService(Repository<fb_AssignedTeam> repository)
    //  : base(repository)
    //{
    //}

    public AssignedTeamService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public bool CheckDuplicateMember(int AssignItemID, int MemberId, int LeadId, int TeamId)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  AssignedTeamService cDisplayClass0 = new AssignedTeamService();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.AssignItemID = AssignItemID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.MemberId = MemberId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.LeadId = LeadId;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.TeamId = TeamId;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  List<fb_AssignedTeam> list = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) Queryable.Where<fb_AssignedTeam>((IQueryable<fb_AssignedTeam>) new FlightBoardEntities().get_fb_AssignedTeam(), Expression.Lambda<Func<fb_AssignedTeam, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (AssignedTeamService.\u003C\u003Ec__DisplayClass0.AssignItemID)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (AssignedTeamService.\u003C\u003Ec__DisplayClass0.MemberId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_LeadID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (AssignedTeamService.\u003C\u003Ec__DisplayClass0.LeadId))), typeof (int?)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_TeamID))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (AssignedTeamService.\u003C\u003Ec__DisplayClass0.TeamId))), typeof (int?)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //  return list != null && list.Count > 0;
    //}

    //public List<fb_AssignedTeam> GetAssignedMembers(int ItemID, int EventID)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  AssignedTeamService.\u003C\u003Ec__DisplayClass3 cDisplayClass3 = new AssignedTeamService.\u003C\u003Ec__DisplayClass3();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass3.ItemID = ItemID;
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass3.EventID = EventID;
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
    //  // ISSUE: field reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) Queryable.Select(Queryable.Where(Queryable.Join((IQueryable<fb_AssignedTeam>) flightBoardEntities.get_fb_AssignedTeam(), (IEnumerable<AssignItem>) flightBoardEntities.get_AssignItems(), Expression.Lambda<Func<fb_AssignedTeam, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  }), Expression.Lambda<Func<AssignItem, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_Id))), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  }), Expression.Lambda<Func<fb_AssignedTeam, AssignItem, \u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression3,
    //    (Expression) parameterExpression4
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>.get_C), __typeref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>.get_A), __typeref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression3,
    //    parameterExpression4
    //  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>.get_A), __typeref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3), FieldInfo.GetFieldFromHandle(__fieldref (AssignedTeamService.\u003C\u003Ec__DisplayClass3.ItemID)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>.get_A), __typeref (\u003C\u003Ef__AnonymousType5<fb_AssignedTeam, AssignItem>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3), FieldInfo.GetFieldFromHandle(__fieldref (AssignedTeamService.\u003C\u003Ec__DisplayClass3.EventID))))), new ParameterExpression[1]
    //  {
    //    parameterExpression5
    //  })), \u003C\u003Eh__TransparentIdentifier2 => \u003C\u003Eh__TransparentIdentifier2.C));
    //}
  }
}
