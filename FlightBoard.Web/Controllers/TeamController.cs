using FlightBoard.Core.Services;
using FlightBoard.Data;
using FlightBoard.Service.Business;
using FlightBoard.Service.Business.DataModels;
using FlightBoard.Web.Extensions;
using FlightBoard.Web.Helpers;
using FlightBoard.Web.Models;
using FlightBoard.Web.Security;
using Lib.Web.Mvc.JQuery.JqGrid;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace FlightBoard.Web.Controllers
{
  [FBAuthorize]
  [OutputCache(Duration = 0, NoStore = true, VaryByParam = "*")]
  public class TeamController : BaseController
  {
    public ActionResult Index()
    {
      using (new UserService())
      {
        this.Session["ItemName"] = (object) null;
        this.Session["Contract"] = (object) null;
        this.Session["FromDate"] = (object) null;
        this.Session["ToDate"] = (object) null;
        this.Session["EventDate"] = (object) null;
        this.Session["EventEndDate"] = (object) null;
        return (ActionResult) this.View((object) new TeamModel());
      }
    }

    [HttpPost]
    public ActionResult Save(TeamModel teamModel, string StartDate, string EndDate)
    {
      using (TeamService teamService = new TeamService())
      {
        //try
        //{
        //  teamModel.IsActive = true;
        //  teamModel.CreatedDate = new DateTime?(DateTime.Now);
        //  teamModel.CreatedBy = new int?(SessionPersister.UserId);
        //  teamModel.TeamStartDate = DateTime.ParseExact(StartDate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
        //  DateTime teamStartDate = teamModel.TeamStartDate;
        //  this.ModelState.Remove("TeamStartDate");
        //  teamModel.TeamEndDate = DateTime.ParseExact(EndDate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
        //  DateTime teamEndDate = teamModel.TeamEndDate;
        //  this.ModelState.Remove("TeamEndDate");
        //  if (this.ModelState.IsValid)
        //  {
        //    ((BusinessServiceBase<fb_Teams>) teamService).Add(MappedExtensions.ToEntity(teamModel), true);
        //  }
        //  else
        //  {
        //    this.ModelState.AddModelError("", "Invalid details.");
        //    TeamModel teamModel1 = new TeamModel();
        //    using (UserService userService = new UserService())
        //    {
        //      ParameterExpression parameterExpression;
        //      // ISSUE: method reference
        //      IEnumerable<UserModel> enumerable = MappedExtensions.ToModels<fb_Users, UserModel>((IEnumerable<fb_Users>) Queryable.OrderBy<fb_Users, string>(((BusinessServiceBase<fb_Users>) userService).FindAll(), Expression.Lambda<Func<fb_Users, string>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), new ParameterExpression[1]
        //      {
        //        parameterExpression
        //      })));
        //      // ISSUE: reference to a compiler-generated field
        //      if (TeamController.\u003CSave\u003Eo__SiteContainer0.\u003C\u003Ep__Site1 == null)
        //      {
        //        // ISSUE: reference to a compiler-generated field
        //        TeamController.\u003CSave\u003Eo__SiteContainer0.\u003C\u003Ep__Site1 = CallSite<Func<CallSite, object, IEnumerable<UserModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items", typeof (TeamController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        //        {
        //          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
        //          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
        //        }));
        //      }
        //      // ISSUE: reference to a compiler-generated field
        //      // ISSUE: reference to a compiler-generated field
        //      object obj = TeamController.\u003CSave\u003Eo__SiteContainer0.\u003C\u003Ep__Site1.Target((CallSite) TeamController.\u003CSave\u003Eo__SiteContainer0.\u003C\u003Ep__Site1, this.ViewBag, enumerable);
        //    }
        //    return (ActionResult) this.View((object) teamModel);
        //  }
        //}
        //catch (Exception ex)
        //{
        //  ((Log4NetLoggerService) LoggerService.logger).Error(ex);
        //  return (ActionResult) this.RedirectToAction("Index");
        //}
      }
      return (ActionResult) this.Json((object) new
      {
        status = "success",
        code = "",
        message = "Team assignment completed successfully."
      });
    }

    public ActionResult AssignTeam()
    {
      TeamModel teamModel = new TeamModel();
      try
      {
        object obj1 = this.TempData["Message"];
        using (UserService userService = new UserService())
        {
          ParameterExpression parameterExpression1;
          ParameterExpression parameterExpression2;
          // ISSUE: method reference
          // ISSUE: method reference
          //IEnumerable<UserModel> enumerable = MappedExtensions.ToModels<fb_Users, UserModel>((IEnumerable<fb_Users>) Queryable.OrderBy<fb_Users, string>(Queryable.Where<fb_Users>(((BusinessServiceBase<fb_Users>) userService).FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_RoleId))), (Expression) Expression.Constant((object) 3, typeof (int))), new ParameterExpression[1]
          //{
          //  parameterExpression1
          //})), Expression.Lambda<Func<fb_Users, string>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), new ParameterExpression[1]
          //{
          //  parameterExpression2
          //})));
          // ISSUE: reference to a compiler-generated field
          //if (TeamController.\u003CAssignTeam\u003Eo__SiteContainer2.\u003C\u003Ep__Site3 == null)
          //{
          //  // ISSUE: reference to a compiler-generated field
          //  TeamController.\u003CAssignTeam\u003Eo__SiteContainer2.\u003C\u003Ep__Site3 = CallSite<Func<CallSite, object, IEnumerable<UserModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items", typeof (TeamController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
          //  {
          //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
          //  }));
          //}
          //// ISSUE: reference to a compiler-generated field
          //// ISSUE: reference to a compiler-generated field
          //object obj2 = TeamController.\u003CAssignTeam\u003Eo__SiteContainer2.\u003C\u003Ep__Site3.Target((CallSite) TeamController.\u003CAssignTeam\u003Eo__SiteContainer2.\u003C\u003Ep__Site3, this.ViewBag, enumerable);
        }
      }
      catch (Exception ex)
      {
        ((Log4NetLoggerService) LoggerService.logger).Error(ex);
        this.ModelState.AddModelError("", ex.Message.ToString());
      }
      return (ActionResult) this.View((object) teamModel);
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Find(JqGridRequest request, string TeamName, string TeamLeadName)
    {
      using (TeamService teamService = new TeamService())
      {
        try
        {
          //IQueryable<fb_Teams_Data> queryForGrid = teamService.GetQueryForGrid(TeamName, TeamLeadName);
          //JqGridResponse jqGridResponse = JqGridHelper.createJQGridResponse(Queryable.Count<fb_Teams_Data>(queryForGrid), request);
          //string str = string.Format("{0} {1}", (object) request.get_SortingName(), (object) request.get_SortingOrder());
          //int count = request.get_PageIndex() * request.get_RecordsCount();
          //int recordsCount = request.get_RecordsCount();
          //jqGridResponse.get_Records().AddRange((IEnumerable<JqGridRecord>) Enumerable.Select<fb_Teams_Data, JqGridRecord<fb_Teams_View>>((IEnumerable<fb_Teams_Data>) Enumerable.ToList<fb_Teams_Data>((IEnumerable<fb_Teams_Data>) Queryable.Take<fb_Teams_Data>(Queryable.Skip<fb_Teams_Data>((IQueryable<fb_Teams_Data>) DynamicQueryable.OrderBy<fb_Teams_Data>((IQueryable<M0>) queryForGrid, str, new object[0]), count), recordsCount)), (Func<fb_Teams_Data, JqGridRecord<fb_Teams_View>>) (p => new JqGridRecord<fb_Teams_View>(Convert.ToString(p.get_TeamId()), MappedExtensions.ToModel(p)))));
          //JqGridJsonResult jqGridJsonResult = new JqGridJsonResult();
          //((JsonResult) jqGridJsonResult).Data = (object) jqGridResponse;
          // return (ActionResult) jqGridJsonResult;
          // return null;
        }
        catch (Exception ex)
        {
          this._loggerService.Error(ex);
          return (ActionResult) this.RedirectToAction("Index");
        }
      }
      return null;
    }

    public ActionResult Edit(int id)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //TeamController.\u003C\u003Ec__DisplayClass9 cDisplayClass9 = new TeamController.\u003C\u003Ec__DisplayClass9();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass9.id = id;
      //using (TeamService teamService = new TeamService())
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  TeamModel teamModel1 = MappedExtensions.ToModel(teamService.FindByID(cDisplayClass9.id));
      //  object obj1 = this.TempData["Message"];
      //  using (UserService userService = new UserService())
      //  {
      //    TeamModel teamModel2 = new TeamModel();
      //    ParameterExpression parameterExpression1;
      //    ParameterExpression parameterExpression2;
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    IEnumerable<UserModel> enumerable = MappedExtensions.ToModels<fb_Users, UserModel>((IEnumerable<fb_Users>) Queryable.OrderBy<fb_Users, string>(Queryable.Where<fb_Users>(((BusinessServiceBase<fb_Users>) userService).FindAll(), Expression.Lambda<Func<fb_Users, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_RoleId))), (Expression) Expression.Constant((object) 3, typeof (int))), new ParameterExpression[1]
      //    {
      //      parameterExpression1
      //    })), Expression.Lambda<Func<fb_Users, string>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), new ParameterExpression[1]
      //    {
      //      parameterExpression2
      //    })));
      //    // ISSUE: reference to a compiler-generated field
      //    if (TeamController.\u003CEdit\u003Eo__SiteContainer7.\u003C\u003Ep__Site8 == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      TeamController.\u003CEdit\u003Eo__SiteContainer7.\u003C\u003Ep__Site8 = CallSite<Func<CallSite, object, IEnumerable<UserModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items", typeof (TeamController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj2 = TeamController.\u003CEdit\u003Eo__SiteContainer7.\u003C\u003Ep__Site8.Target((CallSite) TeamController.\u003CEdit\u003Eo__SiteContainer7.\u003C\u003Ep__Site8, this.ViewBag, enumerable);
      //    TeamMemberService teamMemberService = new TeamMemberService();
      //    ParameterExpression parameterExpression3;
      //    ParameterExpression parameterExpression4;
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    // ISSUE: method reference
      //    teamModel1.TeammemberList = Enumerable.ToList<int>((IEnumerable<int>) Queryable.Select<fb_TeamMembers, int>(Queryable.Where<fb_TeamMembers>(((BusinessServiceBase<fb_TeamMembers>) teamMemberService).FindAll(), Expression.Lambda<Func<fb_TeamMembers, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamId))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass9), FieldInfo.GetFieldFromHandle(__fieldref (TeamController.\u003C\u003Ec__DisplayClass9.id)))), new ParameterExpression[1]
      //    {
      //      parameterExpression3
      //    })), Expression.Lambda<Func<fb_TeamMembers, int>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_TeamMembers.get_TeamMemberId))), new ParameterExpression[1]
      //    {
      //      parameterExpression4
      //    })));
      //  }
        //return (ActionResult) this.View((object) teamModel1);
        return null;
      //}
    }

    [HttpPost]
    public ActionResult Edit(TeamModel teamModel, string StartDate, string EndDate)
    {
      ////using (TeamService teamService = new TeamService())
      ////{
      ////  try
      ////  {
      ////    teamModel.IsActive = true;
      ////    teamModel.CreatedDate = new DateTime?(DateTime.Now);
      ////    teamModel.CreatedBy = new int?(SessionPersister.UserId);
      ////    teamModel.TeamStartDate = DateTime.ParseExact(StartDate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      ////    DateTime teamStartDate = teamModel.TeamStartDate;
      ////    this.ModelState.Remove("TeamStartDate");
      ////    teamModel.TeamEndDate = DateTime.ParseExact(EndDate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      ////    DateTime teamEndDate = teamModel.TeamEndDate;
      ////    this.ModelState.Remove("TeamEndDate");
      ////    if (this.ModelState.IsValid)
      ////    {
      ////      TeamMemberService teamMemberService = new TeamMemberService();
      ////      teamMemberService.DeleteTeamMembers(teamModel.TeamId);
      ////      if (teamModel.fb_TeamMembers.Count > 0)
      ////      {
      ////        foreach (TeamMembersModel model in teamModel.fb_TeamMembers)
      ////          ((BusinessServiceBase<fb_TeamMembers>) teamMemberService).Add(MappedExtensions.ToEntity(model), true);
      ////      }
      ////      teamModel.fb_TeamMembers.Clear();
      ////      ((BusinessServiceBase<fb_Teams>) teamService).Update(MappedExtensions.ToEntity(teamModel), true);
      ////    }
      ////    else
      ////    {
      ////      this.ModelState.AddModelError("", "Invalid details.");
      ////      TeamModel teamModel1 = new TeamModel();
      ////      using (UserService userService = new UserService())
      ////      {
      ////        ParameterExpression parameterExpression;
      ////        // ISSUE: method reference
      ////        IEnumerable<UserModel> enumerable = MappedExtensions.ToModels<fb_Users, UserModel>((IEnumerable<fb_Users>) Queryable.OrderBy<fb_Users, string>(((BusinessServiceBase<fb_Users>) userService).FindAll(), Expression.Lambda<Func<fb_Users, string>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Users.get_UserName))), new ParameterExpression[1]
      ////        {
      ////          parameterExpression
      ////        })));
      ////        // ISSUE: reference to a compiler-generated field
      ////        if (TeamController.\u003CEdit\u003Eo__SiteContainerb.\u003C\u003Ep__Sitec == null)
      ////        {
      ////          // ISSUE: reference to a compiler-generated field
      ////          TeamController.\u003CEdit\u003Eo__SiteContainerb.\u003C\u003Ep__Sitec = CallSite<Func<CallSite, object, IEnumerable<UserModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items", typeof (TeamController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      ////          {
      ////            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      ////            CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      ////          }));
      ////        }
      ////        // ISSUE: reference to a compiler-generated field
      ////        // ISSUE: reference to a compiler-generated field
      ////        object obj = TeamController.\u003CEdit\u003Eo__SiteContainerb.\u003C\u003Ep__Sitec.Target((CallSite) TeamController.\u003CEdit\u003Eo__SiteContainerb.\u003C\u003Ep__Sitec, this.ViewBag, enumerable);
      ////      }
      ////      return (ActionResult) this.View("Index", (object) teamModel1);
      ////    }
      ////  }
      ////  catch (Exception ex)
      ////  {
      ////    this._loggerService.Error(ex);
      ////    return (ActionResult) this.RedirectToAction("Index");
      ////  }
      ////}
      return (ActionResult) this.Json((object) new
      {
        status = "success",
        code = "",
        message = "Team updated successfully."
      });
    }

    [HttpPost]
    public JsonResult Delete(int id)
    {
      try
      {
        using (TeamService teamService = new TeamService())
        {
          //new TeamMemberService((DbContext) ((BusinessServiceBase<fb_Teams>) teamService)._dbContext).DeleteTeamMembers(id);
          //if (new AssignItemService().GetAssignItemCount(id) > 0)
          //  return this.Json((object) new
          //  {
          //    status = "fail",
          //    message = "Item assign to this team.Unable to delete team"
          //  });
          //if (!((BusinessServiceBase<fb_Teams>) teamService).Delete(teamService.FindByID(id), true))
          //  return this.Json((object) new
          //  {
          //    status = "fail",
          //    message = "Unable to delete team."
          //  });
        }
        return this.Json((object) new
        {
          status = "success",
          message = "Team deleted successfully."
        });
      }
      catch (Exception ex)
      {
        return this.Json((object) new
        {
          status = "fail",
          message = ex.Message
        });
      }
    }

    [HttpPost]
    public string getTeammberItems(int TeamId)
    {
      try
      {
        using (TeamMemberService teamMemberService = new TeamMemberService())
          return JsonConvert.SerializeObject((object) teamMemberService.GetTeamMemberdetails(TeamId));
      }
      catch (Exception ex)
      {
        this._loggerService.Error(ex);
      }
      return (string) null;
    }
  }
}
