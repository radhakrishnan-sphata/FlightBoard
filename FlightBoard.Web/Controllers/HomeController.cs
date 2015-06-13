

using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace FlightBoard.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View();
    }

    public ActionResult About()
    {
      // ISSUE: reference to a compiler-generated field
      //if (HomeController.\u003CAbout\u003Eo__SiteContainer0.\u003C\u003Ep__Site1 == null)
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  HomeController.\u003CAbout\u003Eo__SiteContainer0.\u003C\u003Ep__Site1 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Message", typeof (HomeController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  {
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      //  }));
      //}
      //// ISSUE: reference to a compiler-generated field
      //// ISSUE: reference to a compiler-generated field
      //object obj = HomeController.\u003CAbout\u003Eo__SiteContainer0.\u003C\u003Ep__Site1.Target((CallSite) HomeController.\u003CAbout\u003Eo__SiteContainer0.\u003C\u003Ep__Site1, this.ViewBag, "Your application description page.");
      return (ActionResult) this.View();
    }

    public ActionResult Contact()
    {
      // ISSUE: reference to a compiler-generated field
      //if (HomeController.\u003CContact\u003Eo__SiteContainer2.\u003C\u003Ep__Site3 == null)
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  HomeController.\u003CContact\u003Eo__SiteContainer2.\u003C\u003Ep__Site3 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Message", typeof (HomeController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  {
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      //  }));
      //}
      //// ISSUE: reference to a compiler-generated field
      //// ISSUE: reference to a compiler-generated field
      //object obj = HomeController.\u003CContact\u003Eo__SiteContainer2.\u003C\u003Ep__Site3.Target((CallSite) HomeController.\u003CContact\u003Eo__SiteContainer2.\u003C\u003Ep__Site3, this.ViewBag, "Your contact page.");
      return (ActionResult) this.View();
    }
  }
}
