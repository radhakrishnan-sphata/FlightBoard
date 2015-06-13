
using FlightBoard.Core.Security;
using FlightBoard.Core.Services;
using FlightBoard.Core.Utilities;
using FlightBoard.Data;
using FlightBoard.Service.Business;
using FlightBoard.Web.Extensions;
using FlightBoard.Web.Helpers;
using FlightBoard.Web.Models;
using FlightBoard.Web.Security;
using Lib.Web.Mvc.JQuery.JqGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web.Mvc;

namespace FlightBoard.Web.Controllers
{
    [FBAuthorize]
    [OutputCache(Duration = 0, NoStore = true, VaryByParam = "*")]
    public class UserController : BaseController
    {
        public ActionResult Index()
        {
            this.Session["ItemName"] = (object)null;
            this.Session["Contract"] = (object)null;
            this.Session["FromDate"] = (object)null;
            this.Session["ToDate"] = (object)null;
            this.Session["EventDate"] = (object)null;
            this.Session["EventEndDate"] = (object)null;
            return (ActionResult)this.View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Find(JqGridRequest request)
        {
            this.Session["ItemName"] = (object)null;
            this.Session["Contract"] = (object)null;
            this.Session["FromDate"] = (object)null;
            this.Session["ToDate"] = (object)null;
            this.Session["EventDate"] = (object)null;
            this.Session["EventEndDate"] = (object)null;
            using (UserService userService = new UserService())
            {
                string str1 = string.Empty;
                //string str2 = JQGridFilterHelper.SearchFilterExpression(request);
                //JqGridResponse jqGridResponse = JqGridHelper.createJQGridResponse(Queryable.Count<fb_Users>(((BusinessServiceBase<fb_Users>)userService).FindAll()), request);
                //try
                //{
                //    if (request.get_SortingName() == "RoleName")
                //        request.set_SortingName("RoleId");
                //    else if (request.get_SortingName() == "Name")
                //        request.set_SortingName("FirstName");
                //    else if (request.get_SortingName() == "SSNNo")
                //        request.set_SortingName("SSN");
                //    jqGridResponse.get_Records().AddRange((IEnumerable<JqGridRecord>)Enumerable.Select<fb_Users, JqGridRecord<UserModel>>((IEnumerable<fb_Users>)Enumerable.ToList<fb_Users>(((BusinessServiceBase<fb_Users>)userService).GetRecordsForGrid(request, str2, (Expression<Func<fb_Users, bool>>)null)), (Func<fb_Users, JqGridRecord<UserModel>>)(p => new JqGridRecord<UserModel>(Convert.ToString(p.get_UserId()), MappedExtensions.ToModel(p)))));
                //    JqGridJsonResult jqGridJsonResult = new JqGridJsonResult();
                //    ((JsonResult)jqGridJsonResult).Data = (object)jqGridResponse;
                //    return (ActionResult)jqGridJsonResult;
                //}
                //catch (Exception ex)
                //{
                //    ((Log4NetLoggerService)LoggerService.logger).Error(ex);
                 return (ActionResult)this.RedirectToAction("Index");
                //}
            }
        }

        public ActionResult Create()
        {
        //    using (RoleService roleService = new RoleService())
        //    {
        //        UserModel userModel = new UserModel();
        //        ParameterExpression parameterExpression;
        //        // ISSUE: method reference
        //        userModel.Roles = MappedExtensions.ToModels<fb_Roles, RoleModel>((IEnumerable<fb_Roles>)Queryable.OrderBy<fb_Roles, string>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
        //{
        //  parameterExpression
        //})));
        //        return (ActionResult)this.View((object)userModel);
        //    }
            return null;
        }

        [NonAction]
        public void SendRegistrationEmail(UserModel userModel)
        {
            try
            {
                //string str1 = string.Empty;
                //if (userModel.RoleId == 1)
                //    str1 = "Admin";
                //else if (userModel.RoleId == 2)
                //    str1 = "Team leader";
                //string str2 = string.Format("Hi {0} {1},<br/><br/>Your “{3}” account has been created with username “{2}”. Please click on the below link to activate your account.<br/><br/><a target='_blank' href='" + ConfigurationManager.AppSettings["ApplicationURL"].ToString() + "Account/Activate?id=" + BasicSecurity.Encrypt(userModel.UserId.ToString()) + "'>Click here to activate account</a><br/><br/><strong>Note:</strong> Your account will not be activated unless you create a new password and complete activation.<br/><br/>Regards,<br/>Flightboard", (object)userModel.FirstName, (object)userModel.LastName, (object)userModel.UserName, (object)str1);
                //EmailHelper.SendEmail(userModel.UserName, "Registration with Flightboard", str2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public ActionResult Create(UserModel userModel)
        {
            using (UserService userService = new UserService())
            {
                try
                {
                    if (userModel.RoleId == 3)
                    {
                        this.ModelState["SSN"].Errors.Clear();
                        this.ModelState["UserName"].Errors.Clear();
                    }
                    if (userModel.RoleId != 1)
                    {
                        this.ModelState.Remove("SSN");
                        this.ModelState.Remove("UserName");
                    }
                    if (this.ModelState.IsValid)
                    {
                        //if (!userService.IsUserNameExist(userModel.UserName))
                        //{
                        //    if (userModel.RoleId != 1)
                        //    {
                        //        userModel.SSN = string.Empty;
                        //        userModel.Password = "member";
                        //        userModel.IsActive = new bool?(true);
                        //    }
                        //    else
                        //    {
                        //        userModel.SSN = userModel.SSN.Trim();
                        //        userModel.Password = userModel.SSN.Length > 4 ? userModel.SSN.Substring(userModel.SSN.Length - 4) : userModel.SSN;
                        //        userModel.IsActive = new bool?(false);
                        //    }
                        //    userModel.CreatedDate = new DateTime?(DateTime.Now);
                        //    fb_Users entity = ((BusinessServiceBase<fb_Users>)userService).Add(MappedExtensions.ToEntity(userModel), true);
                        //    if (userModel.RoleId == 1)
                        //        this.SendRegistrationEmail(MappedExtensions.ToModel(entity));
                        //    return (ActionResult)this.RedirectToAction("Index");
                        //}
              //          this.ModelState.AddModelError("", "Email already exists.");
              //          using (RoleService roleService = new RoleService())
              //          {
              //              UserModel userModel1 = new UserModel();
              //              ParameterExpression parameterExpression;
              //              // ISSUE: method reference
              //              userModel1.Roles = MappedExtensions.ToModels<fb_Roles, RoleModel>((IEnumerable<fb_Roles>)Queryable.OrderBy<fb_Roles, string>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
              //{
              //  parameterExpression
              //})));
                        //    return (ActionResult)this.View((object)userModel1);
                        //}
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    this._loggerService.Error(ex.Message);
                }
          //      using (RoleService roleService = new RoleService())
          //      {
          ////          UserModel userModel1 = new UserModel();
          ////          ParameterExpression parameterExpression;
          ////          // ISSUE: method reference
          ////          userModel1.Roles = MappedExtensions.ToModels<fb_Roles, RoleModel>((IEnumerable<fb_Roles>)Queryable.OrderBy<fb_Roles, string>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
          ////{
          ////  parameterExpression
          ////})));
          ////          return (ActionResult)this.View((object)userModel1);
                  return null;
          //      }
            }
        }

        public ActionResult Edit(int id)
        {
            using (UserService userService = new UserService())
            {
                using (RoleService roleService = new RoleService((DbContext)((BusinessServiceBase<fb_Users>)userService)._dbContext))
                {
          //          UserModel userModel = MappedExtensions.ToModel(userService.FindByID(id));
          //          ParameterExpression parameterExpression;
          //          // ISSUE: method reference
          //          userModel.Roles = MappedExtensions.ToModels<fb_Roles, RoleModel>((IEnumerable<fb_Roles>)Queryable.OrderBy<fb_Roles, string>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
          //{
          //  parameterExpression
          //})));
                    //return (ActionResult)this.View((object)userModel);
                    return null;
                }
            }
        }

        [HttpPost]
        public ActionResult Edit(UserModel userModel)
        {
            using (UserService userService = new UserService())
            {
                try
                {
                    if (userModel.RoleId == 3)
                    {
                        this.ModelState["SSN"].Errors.Clear();
                        this.ModelState["UserName"].Errors.Clear();
                    }
                    if (userModel.RoleId != 1)
                    {
                        this.ModelState.Remove("SSN");
                        this.ModelState.Remove("UserName");
                    }
                    if (this.ModelState.IsValid)
                    {
                        if (userModel.RoleId != 1)
                        {
                            userModel.SSN = string.Empty;
                            userModel.Password = "member";
                            userModel.IsActive = new bool?(true);
                            userModel.CreatedDate = new DateTime?(DateTime.Now);
                            ((BusinessServiceBase<fb_Users>)userService).Update(MappedExtensions.ToEntity(userModel), true);
                            return (ActionResult)this.RedirectToAction("Index");
                        }
                        //if (!userService.IsUserNameExist(userModel.UserName, userModel.UserId))
                        //{
                        //    userModel.UpdatedDate = new DateTime?(DateTime.Now);
                        //    ((BusinessServiceBase<fb_Users>)userService).Update(MappedExtensions.ToEntity(userModel), true);
                        //    return (ActionResult)this.RedirectToAction("Index");
                        //}
                        this.ModelState.AddModelError("", "Email already exists.");
                        using (RoleService roleService = new RoleService((DbContext)((BusinessServiceBase<fb_Users>)userService)._dbContext))
                        {
              //            //  UserModel userModel1 = MappedExtensions.ToModel(userService.FindByID(userModel.UserId));
              //              ParameterExpression parameterExpression;
              //              // ISSUE: method reference
              //              userModel1.Roles = MappedExtensions.ToModels<fb_Roles, RoleModel>((IEnumerable<fb_Roles>)Queryable.OrderBy<fb_Roles, string>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
              //{
              //  parameterExpression
              //})));
                          //  return (ActionResult)this.View((object)userModel1);
                        }
                    }
                }
                catch
                {
                }
          //      using (RoleService roleService = new RoleService())
          //      {
          //          UserModel userModel1 = new UserModel();
          //          ParameterExpression parameterExpression;
          //          // ISSUE: method reference
          //          userModel1.Roles = MappedExtensions.ToModels<fb_Roles, RoleModel>((IEnumerable<fb_Roles>)Queryable.OrderBy<fb_Roles, string>(((BusinessServiceBase<fb_Roles>)roleService).FindAll(), Expression.Lambda<Func<fb_Roles, string>>((Expression)Expression.Property((Expression)parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle(__methodref(fb_Roles.get_RoleName))), new ParameterExpression[1]
          //{
          //  parameterExpression
          //})));
                   // return (ActionResult)this.View((object)userModel1);
                return  null;
              //  }
            }
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            try
            {
                using (UserService userService = new UserService())
                {
                    //if (!((BusinessServiceBase<fb_Users>)userService).Delete(userService.FindByID(id), true))
                    //    return this.Json((object)new
                    //    {
                    //        status = "fail",
                    //        code = "",
                    //        message = "Unable to delete user."
                    //    });
                }
                return this.Json((object)new
                {
                    status = "success",
                    code = "",
                    message = "User deleted successfully."
                });
            }
            catch (Exception ex)
            {
                return this.Json((object)new
                {
                    status = "fail",
                    code = "",
                    message = "This user is already assigned to a team. Please unassign the user from the team to delete this user."
                });
            }
        }
    }
}
