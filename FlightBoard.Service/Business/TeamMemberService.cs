// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.TeamMemberService
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
  public class TeamMemberService : BusinessServiceBase<fb_TeamMembers>
  {
    //private static TeamMemberService defaultInstance = new TeamMemberService((DbContext) ServiceFactory<FlightBoardEntities>.get_Instance());

    //public static TeamMemberService Default
    //{
    //  get
    //  {
    //    return TeamMemberService.defaultInstance;
    //  }
    //}

      public TeamMemberService()
      {
      }

    //public TeamMemberService(Repository<fb_TeamMembers> repository)
    //  : base(repository)
    //{
    //}

    public TeamMemberService(DbContext dbContext)
      : base(dbContext)
    {
    }

    //public fb_TeamMembers FindByID(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  TeamMemberService.\u003C\u003Ec__DisplayClass0 cDisplayClass0 = new TeamMemberService.\u003C\u003Ec__DisplayClass0();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass0.id = id;
    //  try
    //  {
    //    ParameterExpression parameterExpression;
    //    // ISSUE: method reference
    //    // ISSUE: field reference
    //    return Queryable.FirstOrDefault<fb_TeamMembers>(Queryable.Where<fb_TeamMembers>(this.FindAll(), Expression.Lambda<Func<fb_TeamMembers, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass0), FieldInfo.GetFieldFromHandle(__fieldref (TeamMemberService.\u003C\u003Ec__DisplayClass0.id)))), new ParameterExpression[1]
    //    {
    //      parameterExpression
    //    })));
    //  }
    //  catch (Exception ex)
    //  {
    //  }
    //  return (fb_TeamMembers) null;
    //}

    //public void DeleteTeamMembers(int id)
    //{
    //  // ISSUE: object of a compiler-generated type is created
    //  // ISSUE: variable of a compiler-generated type
    //  TeamMemberService.\u003C\u003Ec__DisplayClass2 cDisplayClass2 = new TeamMemberService.\u003C\u003Ec__DisplayClass2();
    //  // ISSUE: reference to a compiler-generated field
    //  cDisplayClass2.id = id;
    //  ParameterExpression parameterExpression;
    //  // ISSUE: method reference
    //  // ISSUE: field reference
    //  List<fb_TeamMembers> list = Enumerable.ToList<fb_TeamMembers>((IEnumerable<fb_TeamMembers>) Queryable.Where<fb_TeamMembers>(this.FindAll(), Expression.Lambda<Func<fb_TeamMembers, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass2), FieldInfo.GetFieldFromHandle(__fieldref (TeamMemberService.\u003C\u003Ec__DisplayClass2.id)))), new ParameterExpression[1]
    //  {
    //    parameterExpression
    //  })));
    //  if (list.Count <= 0)
    //    return;
    //  using (List<fb_TeamMembers>.Enumerator enumerator = list.GetEnumerator())
    //  {
    //    while (enumerator.MoveNext())
    //      this.Delete(enumerator.Current, true);
    //  }
    //}

    public List<fb_Teams_Data> GetTeamMemberdetails(int TeamId)
    {
        return null;
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //TeamMemberService.\u003C\u003Ec__DisplayClass8 cDisplayClass8 = new TeamMemberService.\u003C\u003Ec__DisplayClass8();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass8.TeamId = TeamId;
      //UserService userService = new UserService(this._dbContext);
      //TeamService teamService = new TeamService(this._dbContext);
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass8.users = Enumerable.ToList<fb_Users>((IEnumerable<fb_Users>) userService.FindAll());
      //ParameterExpression parameterExpression;
      //// ISSUE: method reference
      //// ISSUE: field reference
      //// ISSUE: reference to a compiler-generated method
      //return Enumerable.ToList<fb_Teams_Data>((IEnumerable<fb_Teams_Data>) Enumerable.ToList<fb_Teams_Data>(Enumerable.Select<fb_TeamMembers, fb_Teams_Data>((IEnumerable<fb_TeamMembers>) Enumerable.ToList<fb_TeamMembers>((IEnumerable<fb_TeamMembers>) Queryable.Where<fb_TeamMembers>(this.FindAll(), Expression.Lambda<Func<fb_TeamMembers, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass8), FieldInfo.GetFieldFromHandle(__fieldref (TeamMemberService.\u003C\u003Ec__DisplayClass8.TeamId)))), new ParameterExpression[1]
      //{
      //  parameterExpression
      //}))), new Func<fb_TeamMembers, fb_Teams_Data>(cDisplayClass8.\u003CGetTeamMemberdetails\u003Eb__5))));
    }
  }
}
