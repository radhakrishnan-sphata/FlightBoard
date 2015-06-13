// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.TeamService
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
  public class TeamService : BusinessServiceBase<fb_Teams>
  {
    //private static TeamService defaultInstance = new TeamService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static TeamService Default
    //{
    //  get
    //  {
    //    return TeamService.defaultInstance;
    //  }
    //}

      public TeamService()
      {
      }

    //public TeamService(Repository<fb_Teams> repository)
    //  : base(repository)
    //{
    //}

    public TeamService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public fb_Teams FindByID(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  TeamService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new TeamService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.id = id;
    //  try
    //  {
    //    ParameterExpression parameterExpression;
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    return Queryable.FirstOrDefault<fb_Teams>(Queryable.Where<fb_Teams>(this.FindAll(), Expression.Lambda<Func<fb_Teams, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (TeamService.\u003C\u003Ec__DisplayClass0.id)))), new ParameterExpression[1]
    //    {
    //      parameterExpression
    //    })));
    //  }
    //  catch (Exception ex)
    //  {
    //  }
    //  return (fb_Teams) null;
    //}

    //public IQueryable<fb_Teams_Data> GetQueryForGrid(string TeamName, string TeamLeadName)
    //{
    //  ParameterExpression parameterExpression1;
    //  ParameterExpression parameterExpression2;
    //  ParameterExpression parameterExpression3;
    //  ParameterExpression parameterExpression4;
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  IQueryable<fb_Teams_Data> source = Queryable.Join<fb_Users, fb_Teams, int, fb_Teams_Data>(new UserService(this._dbContext).FindAll(), (IEnumerable<fb_Teams>) this.FindAll(), Expression.Lambda<Func<fb_Users, int>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  }), Expression.Lambda<Func<fb_Teams, int>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamLeadId))), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  }), Expression.Lambda<Func<fb_Users, fb_Teams, fb_Teams_Data>>((Expression) Expression.MemberInit(new fb_Teams_Data(), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamId)), (Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamName)), (Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamName)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamLeadId)), (Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamLeadId)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamLeadName)), (Expression) Expression.Add((Expression) Expression.Add((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_FirstName))), (Expression) Expression.Constant((object) " ", typeof (string)), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Concat))), (Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_LastName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Concat)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamStartDate)), (Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamStartDate)))), (MemberBinding) Expression.Bind((MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams_Data.set_TeamEndDate)), (Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamEndDate))))), new ParameterExpression[2]
    //  {
    //    parameterExpression3,
    //    parameterExpression4
    //  }));
    //  if (!string.IsNullOrEmpty(TeamName))
    //    source = Queryable.Where<fb_Teams_Data>(source, (Expression<Func<fb_Teams_Data, bool>>) (p => p.TeamName.ToLower().Contains(TeamName.ToLower())));
    //  if (!string.IsNullOrEmpty(TeamLeadName))
    //    source = Queryable.Where<fb_Teams_Data>(source, (Expression<Func<fb_Teams_Data, bool>>) (p => p.TeamLeadName.ToLower().Contains(TeamLeadName.ToLower())));
    //  return source;
    //}

    //public List<fb_Users> GetTeamDetailsByProductionDate(string productionDate, int TeamID)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  TeamService.\u003C\u003Ec__DisplayClass9 cDisplayClass9 = new TeamService.\u003C\u003Ec__DisplayClass9();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass9.TeamID = TeamID;
    //  FlightBoardEntities flightBoardEntities = new FlightBoardEntities();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass9.changedDate = DateHelper.ConverStringToDateTimeFormat(productionDate, "MM/dd/yyyy");
    //  ParameterExpression parameterExpression1;
    //  ParameterExpression parameterExpression2;
    //  ParameterExpression parameterExpression3;
    //  ParameterExpression parameterExpression4;
    //  ParameterExpression parameterExpression5;
    //  ParameterExpression parameterExpression6;
    //  ParameterExpression parameterExpression7;
    //  ParameterExpression parameterExpression8;
    //  ParameterExpression parameterExpression9;
    //  ParameterExpression parameterExpression10;
    //  ParameterExpression parameterExpression11;
    //  ParameterExpression parameterExpression12;
    //  ParameterExpression parameterExpression13;
    //  ParameterExpression parameterExpression14;
    //  ParameterExpression parameterExpression15;
    //  ParameterExpression parameterExpression16;
    //  ParameterExpression parameterExpression17;
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
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
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
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: type reference
    //  // ISSUE: method reference
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  return Enumerable.ToList<fb_Users>((IEnumerable<fb_Users>) Queryable.Distinct<fb_Users>(Queryable.Select(Queryable.Where(Queryable.Join(Queryable.Join(Queryable.Join(Queryable.Join((IQueryable<fb_Teams>) flightBoardEntities.get_fb_Teams(), (IEnumerable<fb_AssignedTeam>) flightBoardEntities.get_fb_AssignedTeam(), Expression.Lambda<Func<fb_Teams, int?>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamId))), typeof (int?)), new ParameterExpression[1]
    //  {
    //    parameterExpression1
    //  }), Expression.Lambda<Func<fb_AssignedTeam, int?>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_TeamID))), new ParameterExpression[1]
    //  {
    //    parameterExpression2
    //  }), Expression.Lambda<Func<fb_Teams, fb_AssignedTeam, \u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression3,
    //    (Expression) parameterExpression4
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression3,
    //    parameterExpression4
    //  })), (IEnumerable<fb_TeamMembers>) flightBoardEntities.get_fb_TeamMembers(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, \u003C\u003Ef__AnonymousType9<int, int>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_Value), __typeref (int?))),
    //    (Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression5, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_TeamID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int?.get_Value), __typeref (int?)))
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_a), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_b), __typeref (\u003C\u003Ef__AnonymousType9<int, int>))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression5
    //  }), Expression.Lambda<Func<fb_TeamMembers, \u003C\u003Ef__AnonymousType9<int, int>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamMemberId))),
    //    (Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamId)))
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_a), __typeref (\u003C\u003Ef__AnonymousType9<int, int>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType9<int, int>.get_b), __typeref (\u003C\u003Ef__AnonymousType9<int, int>))
    //  }), new ParameterExpression[1]
    //  {
    //    parameterExpression6
    //  }), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers, \u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression7,
    //    (Expression) parameterExpression8
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>.get_TM), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression7,
    //    parameterExpression8
    //  })), (IEnumerable<fb_ProductionDates>) flightBoardEntities.get_fb_ProductionDates(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, int>>((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression9, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), new ParameterExpression[1]
    //  {
    //    parameterExpression9
    //  }), Expression.Lambda<Func<fb_ProductionDates, int>>((Expression) Expression.Property((Expression) parameterExpression10, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_AssignItemID))), new ParameterExpression[1]
    //  {
    //    parameterExpression10
    //  }), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates, \u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression11,
    //    (Expression) parameterExpression12
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>.get_pd), __typeref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression11,
    //    parameterExpression12
    //  })), (IEnumerable<fb_Users>) flightBoardEntities.get_fb_Users(), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, int?>>((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression13, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_AT), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_MemberID))), new ParameterExpression[1]
    //  {
    //    parameterExpression13
    //  }), Expression.Lambda<Func<fb_Users, int?>>((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression14, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserId))), typeof (int?)), new ParameterExpression[1]
    //  {
    //    parameterExpression14
    //  }), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users, \u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>>>((Expression) Expression.New((ConstructorInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>.\u002Ector), __typeref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>)), (IEnumerable<Expression>) new Expression[2]
    //  {
    //    (Expression) parameterExpression15,
    //    (Expression) parameterExpression16
    //  }, (MemberInfo[]) new MethodInfo[2]
    //  {
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>)),
    //    (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>.get_us), __typeref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>))
    //  }), new ParameterExpression[2]
    //  {
    //    parameterExpression15,
    //    parameterExpression16
    //  })), Expression.Lambda<Func<\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>, bool>>((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>.get_pd), __typeref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass9), FieldInfo.GetFieldFromHandle(__fieldref (TeamService.\u003C\u003Ec__DisplayClass9.changedDate)))
    //  }), (Expression) Expression.Call((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) Expression.Property((Expression) parameterExpression17, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>.get_\u003C\u003Eh__TransparentIdentifier7), __typeref (\u003C\u003Ef__AnonymousType13<\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>, fb_Users>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>.get_\u003C\u003Eh__TransparentIdentifier6), __typeref (\u003C\u003Ef__AnonymousType12<\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>, fb_ProductionDates>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>.get_\u003C\u003Eh__TransparentIdentifier5), __typeref (\u003C\u003Ef__AnonymousType2<\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>, fb_TeamMembers>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>.get_A), __typeref (\u003C\u003Ef__AnonymousType1<fb_Teams, fb_AssignedTeam>))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Teams.get_TeamId))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
    //  {
    //    (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass9), FieldInfo.GetFieldFromHandle(__fieldref (TeamService.\u003C\u003Ec__DisplayClass9.TeamID)))
    //  })), new ParameterExpression[1]
    //  {
    //    parameterExpression17
    //  })), \u003C\u003Eh__TransparentIdentifier8 => \u003C\u003Eh__TransparentIdentifier8.us)));
    //}
  }
}
