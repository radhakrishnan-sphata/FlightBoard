using FlightBoard.Core.Security;
using FlightBoard.Core.Services;
using FlightBoard.Data;
using FlightBoard.Service.Business;
using FlightBoard.Web.Models;
using FlightBoard.Web.Security;
using Microsoft.AspNet.Identity;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Web;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using System.Web.Security;

namespace FlightBoard.Web.Controllers
{
  public class AccountController : Controller
  {
    [AllowAnonymous]
    public ActionResult Login(string returnUrl)
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        //if (AccountController.\u003CLogin\u003Eo__SiteContainer0.\u003C\u003Ep__Site1 == null)
        //{
        //  // ISSUE: reference to a compiler-generated field
        //  AccountController.\u003CLogin\u003Eo__SiteContainer0.\u003C\u003Ep__Site1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "ReturnUrl", typeof (AccountController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        //  {
        //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
        //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
        //  }));
        //}
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        //object obj = AccountController.\u003CLogin\u003Eo__SiteContainer0.\u003C\u003Ep__Site1.Target((CallSite) AccountController.\u003CLogin\u003Eo__SiteContainer0.\u003C\u003Ep__Site1, this.ViewBag, returnUrl);
      }
      catch (Exception ex)
      {
        ((Log4NetLoggerService) LoggerService.logger).Error(ex);
      }
      return (ActionResult) this.View();
    }

    [ValidateAntiForgeryToken]
    [HttpPost]
    [AllowAnonymous]
    public ActionResult Login(LoginViewModel model, string returnUrl)
    {
      try
      {
        if (this.ModelState.IsValid)
        {
          using (UserService userService = new UserService())
          {
            //fb_Users fbUsers = userService.IsValidUser(model.UserName, model.Password);
            //if (fbUsers != null)
            //{
            //  bool? isActive = fbUsers.get_IsActive();
            //  if ((isActive.GetValueOrDefault() ? 0 : (isActive.HasValue ? 1 : 0)) != 0)
            //  {
            //    this.ModelState.Clear();
            //    this.ModelState.AddModelError("", "User is inactive. Please contact administrator.");
            //    return (ActionResult) this.View();
            //  }
            //  SessionPersister.UserId = fbUsers.get_UserId();
            //  SessionPersister.Username = fbUsers.get_UserName();
            //  SessionPersister.DisplayName = fbUsers.get_FirstName() + " " + fbUsers.get_LastName();
            //  SessionPersister.Roles = fbUsers.get_RoleId();
            //  if (fbUsers.get_Password().Equals(fbUsers.get_SSN()))
            //    return (ActionResult) this.RedirectToAction("ChangePassword", "Account");
            //  if (fbUsers.get_RoleId() == 2)
            //    return (ActionResult) this.RedirectToAction("TeamLeadIndex", "Dashboard");
            //  return (ActionResult) this.RedirectToAction("Index", "Dashboard");
            //}
            //this.ModelState.Clear();
            //this.ModelState.AddModelError("", "Invalid Credentials.");
            return (ActionResult) this.View();
          }
        }
      }
      catch (Exception ex)
      {
        ((Log4NetLoggerService) LoggerService.logger).Error(ex);
        this.ModelState.AddModelError("", ex.Message.ToString());
      }
      return (ActionResult) this.View((object) model);
    }

    [FBAuthorize]
    public ActionResult LogOff()
    {
      try
      {
        this.Session.Clear();
        this.Session.Abandon();
        FormsAuthentication.SignOut();
        return (ActionResult) this.RedirectToAction("Login", "Account");
      }
      catch (Exception ex)
      {
        ((Log4NetLoggerService) LoggerService.logger).Error(ex);
        return (ActionResult) this.View();
      }
    }

    [HttpGet]
    [FBAuthorize]
    public ActionResult ChangePassword()
    {
      return (ActionResult) this.View();
    }

    [HttpPost]
    [FBAuthorize]
    public ActionResult ChangePassword(string CurrentPassword, string NewPassword, string ConfirmPassword, ChangePasswordModel model)
    {
      try
      {
        if (this.ModelState.IsValid)
        {
          if (CurrentPassword != null)
          {
            using (UserService userService = new UserService())
            {
              //fb_Users fbUsers = userService.checkUserByPassword(CurrentPassword, SessionPersister.UserId);
              //if (fbUsers != null)
              //{
              //  if (fbUsers.get_UserId() > 0)
              //  {
              //    if (userService.ChangeUserPassword(NewPassword, CurrentPassword, Convert.ToInt32(fbUsers.get_UserId())))
              //      this.ModelState.AddModelError("", "Password Changed successfully");
              //    else
              //      this.ModelState.AddModelError("", "Unknown error occurred. Password change process failed");
              //  }
              //}
              //else
              //  this.ModelState.AddModelError("", "No user exists with given password");
            }
          }
        }
      }
      catch (Exception ex)
      {
        this.ModelState.AddModelError("", ex.Message.ToString());
      }
      return (ActionResult) this.View((object) model);
    }

    [AllowAnonymous]
    public ActionResult ForgotPassword()
    {
      return (ActionResult) this.View();
    }

    [HttpPost]
    [AllowAnonymous]
    [ValidateAntiForgeryToken]
    public ActionResult ForgotPassword(ForgotPasswordModel model)
    {
      try
      {
        if (this.ModelState.IsValid)
        {
          using (UserService userService = new UserService())
          {
            //fb_Users fbUsers = userService.CheckUserDetails(model.UserName, model.SSN);
            //if (fbUsers != null)
            //{
            //  fbUsers.set_Password(fbUsers.get_SSN());
            //  ((BusinessServiceBase<fb_Users>) userService).Update(fbUsers, true);
            //  this.ModelState.AddModelError("", "Your password reset with your SSN. Please login and change the password.");
            //}
            //else
            //  this.ModelState.AddModelError("", "No user is exists with given details.");
          }
        }
      }
      catch (Exception ex)
      {
        this.ModelState.AddModelError("", ex.Message.ToString());
      }
      return (ActionResult) this.View((object) model);
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }

    private void AddErrors(IdentityResult result)
    {
      //foreach (string errorMessage in result.get_Errors())
      //  this.ModelState.AddModelError("", errorMessage);
    }

    public ActionResult Activate(string id)
    {
      //string str = BasicSecurity.Decrypt(id);
      //using (UserService userService = new UserService())
      //{
      ////  fb_Users byId = userService.FindByID(Convert.ToInt32(str));
      //  if (byId == null)
      //    return (ActionResult) this.RedirectToAction("InvalidUser");
      ////  bool? isActive = byId.get_IsActive();
      // // if ((!isActive.GetValueOrDefault() ? 0 : (isActive.HasValue ? 1 : 0)) != 0)
      //    return (ActionResult) this.RedirectToAction("AlreadyActivated");
      ////  byId.set_IsActive(new bool?(true));
      //  ((BusinessServiceBase<fb_Users>) userService).Update(byId, true);
      ////  SessionPersister.UserId = byId.get_UserId();
        //SessionPersister.Username = byId.get_UserName();
        //SessionPersister.DisplayName = byId.get_FirstName() + " " + byId.get_LastName();
        //SessionPersister.Roles = byId.get_RoleId();
        return (ActionResult) this.RedirectToAction("ActivateChangePassword", "Account");
      //}
    }

    public ActionResult InvalidUser()
    {
      return (ActionResult) this.View();
    }

    public ActionResult AlreadyActivated()
    {
      return (ActionResult) this.View();
    }

    [FBAuthorize]
    [HttpGet]
    public ActionResult ActivateChangePassword()
    {
      return (ActionResult) this.View();
    }

    [FBAuthorize]
    [HttpPost]
    public ActionResult ActivateChangePassword(string newPassword, string confirmPassword, ChangePasswordModel model)
    {
      try
      {
        model.NewPassword = newPassword;
        model.ConfirmPassword = confirmPassword;
        if (!string.IsNullOrEmpty(newPassword) && !string.IsNullOrEmpty(confirmPassword))
        {
          if (newPassword.Equals(confirmPassword))
          {
            using (UserService userService = new UserService())
            {
              //fb_Users byId = userService.FindByID(SessionPersister.UserId);
              //if (!byId.get_SSN().Equals(newPassword))
              //{
              //  byId.set_Password(newPassword);
              //  ((BusinessServiceBase<fb_Users>) userService).Update(byId, true);
              //  if (byId.get_RoleId() == 2)
              //    return (ActionResult) this.RedirectToAction("TeamLeadIndex", "Dashboard");
              //  return (ActionResult) this.RedirectToAction("Index", "Dashboard");
              //}
              this.ModelState.AddModelError("", "Password should not be same as the last 4 digits of SSN.");
            }
          }
          else
            this.ModelState.AddModelError("", "New password and confirm password does not match.");
        }
        else if (string.IsNullOrEmpty(newPassword))
          this.ModelState.AddModelError("", "Password is required.");
        else if (string.IsNullOrEmpty(confirmPassword))
          this.ModelState.AddModelError("", "Confirm Password is required.");
      }
      catch (Exception ex)
      {
      }
      return (ActionResult) this.View((object) model);
    }
  }
}
