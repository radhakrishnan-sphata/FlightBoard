// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Controllers.DashboardController
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using FlightBoard.Data;
using FlightBoard.Service.Business;
using FlightBoard.Web.Extensions;
using FlightBoard.Web.Models;
using FlightBoard.Web.Security;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FlightBoard.Web.Controllers
{
  [FBAuthorize]
  [OutputCache(Duration = 0, NoStore = true, VaryByParam = "*")]
  public class DashboardController : BaseController
  {
    private static IList<string> objectsList1 = (IList<string>) new List<string>();
    private DashboardModel dbm = new DashboardModel();
    private List<DashboardModel> list = new List<DashboardModel>();
    private List<string> objectsList = new List<string>();
    private DashboardModel Obj = new DashboardModel();
    private List<DashboardModel> ObjCustomer = new List<DashboardModel>();

    public ActionResult Index()
    {
      //try
      //{
      //  this.Session["ItemName"] = (object) null;
      //  this.Session["Contract"] = (object) null;
      //  this.Session["FromDate"] = (object) null;
      //  this.Session["ToDate"] = (object) null;
      //  this.Session["EventDate"] = (object) null;
      //  this.Session["EventEndDate"] = (object) null;
      //  cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //  //using (EventsService eventsService = new EventsService())
      //  //{
      //  //  IEnumerable<fb_Events> source = Enumerable.Take<fb_Events>(eventsService.GetEvents(), 100);
      //  //  List<EventModel> list1 = new List<EventModel>();
      //  //  if (Enumerable.Count<fb_Events>(source) == 0)
      //  //  {
      //  //    // ISSUE: reference to a compiler-generated field
      //  //    //if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site2 == null)
      //  //    //{
      //  //    //  // ISSUE: reference to a compiler-generated field
      //  //    //  DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site2 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items2", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  //    //  {
      //  //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //  //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      //  //    //  }));
      //  //    }
      //  //    // ISSUE: reference to a compiler-generated field
      //  //    // ISSUE: reference to a compiler-generated field
      //  //    //object obj1 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site2.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site2, this.ViewBag, "");
      //  //    //// ISSUE: reference to a compiler-generated field
      //  //    //if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site3 == null)
      //  //    //{
      //  //    //  // ISSUE: reference to a compiler-generated field
      //  //    //  DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site3 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "NoOfItems", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  //    //  {
      //  //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //  //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      //  //    //  }));
      //  //    //}
      //  //    // ISSUE: reference to a compiler-generated field
      //  //    // ISSUE: reference to a compiler-generated field
      //  //    object obj2 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site3.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site3, this.ViewBag, 0);
      //  //  }
      //    fb_Events fbEvents = Enumerable.FirstOrDefault<fb_Events>(source);
      //    if (fbEvents.get_EventDate().HasValue)
      //      Convert.ToDateTime((object) fbEvents.get_EventDate()).ToString("MM/dd/yyyy");
      //    ItemsService itemsService = new ItemsService((DbContext) ((BusinessServiceBase<fb_Events>) eventsService)._dbContext);
      //    ProductionDateService productionDateService = new ProductionDateService((DbContext) ((BusinessServiceBase<fb_Events>) eventsService)._dbContext);
      //    List<fb_Items> list2 = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) itemsService.GetItemsByEventListId(fbEvents.get_FSSeventlist_intid().Value));
      //    List<ProductionDatesModel> list3 = new List<ProductionDatesModel>();
      //    using (List<fb_Items>.Enumerator enumerator1 = list2.GetEnumerator())
      //    {
      //      while (enumerator1.MoveNext())
      //      {
      //        fb_Items current1 = enumerator1.Current;
      //        using (List<fb_ProductionDates>.Enumerator enumerator2 = productionDateService.GetAllProductionDatesByItemId(current1.get_Item_intid(), current1.get_ItemEvent_intid()).GetEnumerator())
      //        {
      //          while (enumerator2.MoveNext())
      //          {
      //            fb_ProductionDates current2 = enumerator2.Current;
      //            list3.Add(MappedExtensions.ToModel(current2));
      //          }
      //        }
      //      }
      //    }
      //    using (IEnumerator<fb_Events> enumerator = source.GetEnumerator())
      //    {
      //      while (((IEnumerator) enumerator).MoveNext())
      //      {
      //        // ISSUE: object of a compiler-generated type is created
      //        // ISSUE: variable of a compiler-generated type
      //        DashboardController.\u003C\u003Ec__DisplayClass9 cDisplayClass9 = new DashboardController.\u003C\u003Ec__DisplayClass9();
      //        // ISSUE: reference to a compiler-generated field
      //        cDisplayClass9.item = enumerator.Current;
      //        ParameterExpression parameterExpression1;
      //        ParameterExpression parameterExpression2;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        List<DateTime> list4 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Distinct<DateTime>(Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), typeof (int?)), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass9), FieldInfo.GetFieldFromHandle(__fieldref (DashboardController.\u003C\u003Ec__DisplayClass9.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid)))), new ParameterExpression[1]
      //        {
      //          parameterExpression1
      //        })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //        {
      //          parameterExpression2
      //        }))));
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        list1.Add(new EventModel()
      //        {
      //          Contract = cDisplayClass9.item.get_Contract(),
      //          DateOfProduction = cDisplayClass9.item.get_DateOfProduction(),
      //          Description = cDisplayClass9.item.get_Description(),
      //          EventDate = cDisplayClass9.item.get_EventDate(),
      //          EventId = cDisplayClass9.item.get_EventId(),
      //          EventName = cDisplayClass9.item.get_EventName(),
      //          FSSeventlist_intid = cDisplayClass9.item.get_FSSeventlist_intid(),
      //          MealName = cDisplayClass9.item.get_MealName(),
      //          NoofItems = cDisplayClass9.item.get_NoofItems(),
      //          ProductionDate = list4.Count == 0 ? "NA" : (list4.Count > 1 ? "Multiple" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list4).ToString("MM/dd/yyyy")),
      //          Quantity = cDisplayClass9.item.get_Quantity(),
      //          TeamLead = cDisplayClass9.item.get_TeamLead(),
      //          UnitId = cDisplayClass9.item.get_UnitId(),
      //          UnitName = cDisplayClass9.item.get_UnitName()
      //        });
      //      }
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    //if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site4 == null)
      //    //{
      //    //  // ISSUE: reference to a compiler-generated field
      //    //  DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site4 = CallSite<Func<CallSite, object, List<fb_Items>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items2", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    //  {
      //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    //  }));
      //    //}
      //    //// ISSUE: reference to a compiler-generated field
      //    //// ISSUE: reference to a compiler-generated field
      //    //object obj3 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site4.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site4, this.ViewBag, list2);
      //    //// ISSUE: reference to a compiler-generated field
      //    //if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site5 == null)
      //    //{
      //    //  // ISSUE: reference to a compiler-generated field
      //    //  DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site5 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "NoOfItems", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    //  {
      //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    //  }));
      //    //}
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      ////    object obj4 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site5.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site5, this.ViewBag, Enumerable.Count<fb_Items>((IEnumerable<fb_Items>) list2));
      ////    RefreshTimeModel refreshTimeModel1 = new RefreshTimeModel();
      ////    RefreshService refreshService = new RefreshService();
      ////    refreshTimeModel1.RefreshTime = DateTime.Now.AddDays(-200.0);
      ////    RefreshTimeModel refreshTimeModel2 = MappedExtensions.ToModel(refreshService.getFirstEvent());
      ////    using (IEnumerator<fb_Events> enumerator = source.GetEnumerator())
      ////    {
      ////      while (((IEnumerator) enumerator).MoveNext())
      ////      {
      ////        fb_Events current = enumerator.Current;
      ////        this.Obj = new DashboardModel();
      ////        if (current.get_EventDate().HasValue)
      ////          Convert.ToDateTime((object) current.get_EventDate()).ToString("MM/dd/yyyy");
      ////        this.Obj.EventName = current.get_UnitName().ToString();
      ////        this.Obj.EventName = this.Obj.EventName.Replace("00:00:00", "");
      ////        current.set_EventName(this.Obj.EventName);
      ////        current.set_Quantity(!current.get_Quantity().HasValue ? new Decimal?(new Decimal(0)) : current.get_Quantity());
      ////        this.Obj.EventDate = current.get_EventDate();
      ////        this.Obj.Contract = current.get_Contract().ToString();
      ////        this.Obj.UnitId = current.get_UnitId();
      ////        this.Obj.MealName = current.get_MealName();
      ////        this.Obj.NoofItems = current.get_NoofItems().Value;
      ////        this.Obj.ProdDate = current.get_DateOfProduction();
      ////        this.Obj.ItemEvent_intid = current.get_FSSeventlist_intid().Value;
      ////        this.Obj.RefreshTime = new DateTime?(refreshTimeModel2.RefreshTime);
      ////        this.ObjCustomer.Add(this.Obj);
      ////      }
      ////    }
      ////    // ISSUE: reference to a compiler-generated field
      ////    if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site6 == null)
      ////    {
      ////      // ISSUE: reference to a compiler-generated field
      ////      DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site6 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "events", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      ////      {
      ////        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      ////        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      ////      }));
      ////    }
      ////    // ISSUE: reference to a compiler-generated field
      ////    // ISSUE: reference to a compiler-generated field
      ////    object obj5 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site6.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site6, this.ViewBag, JsonConvert.SerializeObject((object) list1));
      ////    Enumerable.FirstOrDefault<DashboardModel>((IEnumerable<DashboardModel>) this.ObjCustomer).productionDateModel = list3;
      ////  }
      //}
      //catch (Exception ex)
      //{
      ////  // ISSUE: reference to a compiler-generated field
      ////  if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site7 == null)
      ////  {
      ////    // ISSUE: reference to a compiler-generated field
      ////    DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site7 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items2", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      ////    {
      ////      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      ////      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      ////    }));
      ////  }
      ////  // ISSUE: reference to a compiler-generated field
      ////  // ISSUE: reference to a compiler-generated field
      ////  object obj1 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site7.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site7, this.ViewBag, "");
      //  // ISSUE: reference to a compiler-generated field
      ////  if (DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site8 == null)
      ////  {
      ////    // ISSUE: reference to a compiler-generated field
      ////    DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site8 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "NoOfItems", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      ////    {
      ////      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      ////      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      ////    }));
      ////  }
      ////  // ISSUE: reference to a compiler-generated field
      ////  // ISSUE: reference to a compiler-generated field
      ////  object obj2 = DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site8.Target((CallSite) DashboardController.\u003CIndex\u003Eo__SiteContainer1.\u003C\u003Ep__Site8, this.ViewBag, 0);
      //}
      return (ActionResult) this.View((object) this.ObjCustomer);
    }

    [HttpPost]
    public string getItems(string ItemEvent_Id)
    {
      //try
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  if (DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sited == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sited = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items2", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj1 = DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sited.Target((CallSite) DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sited, this.ViewBag, "");
      //  cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //  List<fb_Items> list1 = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) new ItemsService().GetItemsByEventListId(int.Parse(ItemEvent_Id)));
      //  ProductionDateService productionDateService = new ProductionDateService();
      //  List<ItemByProductionDateModel> list2 = new List<ItemByProductionDateModel>();
      //  using (List<fb_Items>.Enumerator enumerator = list1.GetEnumerator())
      //  {
      //    while (enumerator.MoveNext())
      //    {
      //      fb_Items current = enumerator.Current;
      //      List<fb_ProductionDates> productionDatesByItemId = productionDateService.GetAllProductionDatesByItemId(current.get_Item_intid(), current.get_ItemEvent_intid());
      //      list2.Add(new ItemByProductionDateModel()
      //      {
      //        ID = current.get_ID(),
      //        IsSubItem = current.get_IsSubItem(),
      //        Item_intid = current.get_Item_intid(),
      //        ItemEvent_intid = current.get_ItemEvent_intid(),
      //        ItemName = current.get_ItemName(),
      //        Quantity = current.get_Quantity(),
      //        UniQueItemIds = current.get_UniQueItemIds(),
      //        HasSubItem = current.get_HasSubItem(),
      //        ProductionDate = Enumerable.Count<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) productionDatesByItemId) == 0 ? "NA" : (Enumerable.Count<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) productionDatesByItemId) == 1 ? Enumerable.FirstOrDefault<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) productionDatesByItemId).get_ProdcutionDate().ToString("MM/dd/yyyy") : "Multiple"),
      //        ItemImageFileName = current.get_ItemImageFileName()
      //      });
      //    }
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  if (DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitee == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitee = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "NoOfItems", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj2 = DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitee.Target((CallSite) DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitee, this.ViewBag, Enumerable.Count<fb_Items>((IEnumerable<fb_Items>) list1));
      //  // ISSUE: reference to a compiler-generated field
      //  if (DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitef == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitef = CallSite<Func<CallSite, object, List<fb_Items>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items2", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj3 = DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitef.Target((CallSite) DashboardController.\u003CgetItems\u003Eo__SiteContainerc.\u003C\u003Ep__Sitef, this.ViewBag, list1);
      //  return JsonConvert.SerializeObject((object) list2);
      //}
      //catch (Exception ex)
      //{
      //  this._loggerService.Error(ex);
      //}
      return (string) null;
    }

    [HttpGet]
    public ActionResult LoadDataFromFSS()
    {
      cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //try
      //{
      //  using (EventsService eventsService = new EventsService())
      //  {
      //    RefreshService refreshService = new RefreshService((DbContext) ((BusinessServiceBase<fb_Events>) eventsService)._dbContext);
      //    new RefreshTimeModel().RefreshTime = DateTime.Now.AddDays(-200.0);
      //    RefreshTimeModel refreshTimeModel = MappedExtensions.ToModel(refreshService.getFirstEvent());
      //    DateTime refreshTime = refreshTimeModel.RefreshTime;
      //    List<sp_fb_Events_Result5> list1 = Enumerable.ToList<sp_fb_Events_Result5>(Enumerable.Take<sp_fb_Events_Result5>((IEnumerable<sp_fb_Events_Result5>) cbordTestEntities.sp_fb_Events(new DateTime?(refreshTimeModel.RefreshTime.Date)), 100));
      //    Enumerable.FirstOrDefault<sp_fb_Events_Result5>((IEnumerable<sp_fb_Events_Result5>) list1);
      //    foreach (sp_fb_Events_Result5 spFbEventsResult5 in list1)
      //    {
      //      fb_Events eventByItemEventId = eventsService.getEventByItemEventID(spFbEventsResult5.ItemEvent_intid);
      //      List<sp_fb_Items_Result7> list2 = Enumerable.ToList<sp_fb_Items_Result7>((IEnumerable<sp_fb_Items_Result7>) cbordTestEntities.sp_fb_Items(new int?(spFbEventsResult5.ItemEvent_intid)));
      //      if (eventByItemEventId == null)
      //      {
      //        this.Obj = new DashboardModel();
      //        this.Obj.UnitId = new int?(spFbEventsResult5.unitid);
      //        this.Obj.MealName = spFbEventsResult5.mealname;
      //        this.Obj.EventName = spFbEventsResult5.unitname.ToString();
      //        this.Obj.EventDate = spFbEventsResult5.eventdate;
      //        this.Obj.TeamLead = "";
      //        this.Obj.UnitName = spFbEventsResult5.unitname;
      //        this.Obj.ItemEvent_intid = spFbEventsResult5.ItemEvent_intid;
      //        this.Obj.Quantity = !spFbEventsResult5.Qty3.HasValue ? new Decimal?(new Decimal(0)) : spFbEventsResult5.Qty3;
      //        if (!string.IsNullOrEmpty(spFbEventsResult5.note))
      //        {
      //          string[] strArray = spFbEventsResult5.note.Split('@');
      //          this.Obj.Contract = Enumerable.Count<string>((IEnumerable<string>) strArray) > 1 ? strArray[0] : string.Empty;
      //          this.Obj.Description = Enumerable.Count<string>((IEnumerable<string>) strArray) > 1 ? strArray[1] : string.Empty;
      //        }
      //        else
      //        {
      //          this.Obj.Contract = string.Empty;
      //          this.Obj.Description = "";
      //        }
      //        if (spFbEventsResult5.eventdate.HasValue)
      //          Convert.ToDateTime((object) spFbEventsResult5.eventdate).ToString("yyyy-MM-dd");
      //        this.Obj.NoofItems = Enumerable.Count<sp_fb_Items_Result7>((IEnumerable<sp_fb_Items_Result7>) list2);
      //        ((BusinessServiceBase<fb_Events>) eventsService).Add(MappedExtensions.ToEntity(this.Obj), true);
      //      }
      //      else
      //      {
      //        eventByItemEventId.set_UnitId(new int?(spFbEventsResult5.unitid));
      //        eventByItemEventId.set_MealName(spFbEventsResult5.mealname);
      //        eventByItemEventId.set_EventName(spFbEventsResult5.unitname.ToString());
      //        eventByItemEventId.set_EventDate(spFbEventsResult5.eventdate);
      //        eventByItemEventId.set_UnitName(spFbEventsResult5.unitname);
      //        eventByItemEventId.set_NoofItems(new int?(Enumerable.Count<sp_fb_Items_Result7>((IEnumerable<sp_fb_Items_Result7>) list2)));
      //        eventByItemEventId.set_Quantity(!spFbEventsResult5.Qty3.HasValue ? new Decimal?(new Decimal(0)) : spFbEventsResult5.Qty3);
      //        if (!string.IsNullOrEmpty(spFbEventsResult5.note))
      //        {
      //          string[] strArray = spFbEventsResult5.note.Split('@');
      //          eventByItemEventId.set_Contract(Enumerable.Count<string>((IEnumerable<string>) strArray) > 1 ? strArray[0] : string.Empty);
      //          eventByItemEventId.set_Description(Enumerable.Count<string>((IEnumerable<string>) strArray) > 1 ? strArray[1] : string.Empty);
      //        }
      //        else
      //        {
      //          this.Obj.Contract = string.Empty;
      //          this.Obj.Description = "";
      //        }
      //        ((BusinessServiceBase<fb_Events>) eventsService).Update(eventByItemEventId, true);
      //      }
      //      ItemsService itemsService = new ItemsService((DbContext) ((BusinessServiceBase<fb_Events>) eventsService)._dbContext);
      //      List<fb_Items> itemsByEventListId = itemsService.GetItemsByEventListId(spFbEventsResult5.ItemEvent_intid);
      //      if (itemsByEventListId.Count > 0)
      //      {
      //        List<int> itemIdsList = Enumerable.ToList<int>(Enumerable.Select<sp_fb_Items_Result7, int>((IEnumerable<sp_fb_Items_Result7>) list2, (Func<sp_fb_Items_Result7, int>) (x => x.Item_intid)));
      //        List<fb_Items> list3 = Enumerable.ToList<fb_Items>(Enumerable.Where<fb_Items>((IEnumerable<fb_Items>) itemsByEventListId, (Func<fb_Items, bool>) (x => !itemIdsList.Contains(x.get_Item_intid()))));
      //        itemsService.DeleteItems(list3);
      //      }
      //      foreach (sp_fb_Items_Result7 spFbItemsResult7 in list2)
      //      {
      //        sp_fb_Items_Result7 items = spFbItemsResult7;
      //        int num1 = 0;
      //        List<fb_Items> list3 = Enumerable.ToList<fb_Items>(Enumerable.Where<fb_Items>((IEnumerable<fb_Items>) itemsByEventListId, (Func<fb_Items, bool>) (x => x.get_Item_intid() == items.Item_intid)));
      //        ItemModel model = new ItemModel();
      //        if (list3.Count > 0)
      //        {
      //          using (List<fb_Items>.Enumerator enumerator = list3.GetEnumerator())
      //          {
      //            while (enumerator.MoveNext())
      //            {
      //              fb_Items current = enumerator.Current;
      //              current.set_Item_intid(items.Item_intid);
      //              current.set_ItemName(items.itemname);
      //              current.set_ItemEvent_intid(items.ItemEvent_intid);
      //              current.set_Quantity(!items.QTY1.HasValue ? (!items.itemeventQty2.HasValue ? items.itemeventQty3 : items.itemeventQty2) : items.QTY1);
      //              current.set_PrepAreaId(items.preparea_intid);
      //              current.set_PrepAreaName(items.LOCID);
      //              current.set_ItemImageFileName(items.Prd_Image);
      //              ((BusinessServiceBase<fb_Items>) itemsService).Update(current, true);
      //            }
      //          }
      //        }
      //        else
      //        {
      //          model.ItemId = items.Item_intid;
      //          model.ItemName = items.itemname;
      //          model.ItemEvent_intid = items.ItemEvent_intid;
      //          model.Quantity = !items.QTY1.HasValue ? (!items.itemeventQty2.HasValue ? items.itemeventQty3 : items.itemeventQty2) : items.QTY1;
      //          model.IsSubItem = false;
      //          model.UniQueItemIds = Convert.ToString(items.ItemEvent_intid) + "_" + Convert.ToString(items.Item_intid) + "_" + Convert.ToString(num1);
      //          model.HasSubItem = false;
      //          model.PrepAreaId = items.preparea_intid;
      //          model.PrepAreaName = items.LOCID;
      //          model.ItemImageFileName = items.Prd_Image;
      //          ((BusinessServiceBase<fb_Items>) itemsService).Add(MappedExtensions.ToEntity(model), true);
      //          ObjectResult<IngredientsForItems1_Result1> objectResult = cbordTestEntities.IngredientsForItems1(new int?(items.Item_intid));
      //          int num2 = num1 + 1;
      //          foreach (IngredientsForItems1_Result1 forItems1Result1_1 in Enumerable.ToList<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) objectResult))
      //          {
      //            List<IngredientsForItems1_Result1> list4 = Enumerable.ToList<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) cbordTestEntities.IngredientsForItems1(new int?(forItems1Result1_1.component_item_intid)));
      //            model.ItemId = forItems1Result1_1.component_item_intid;
      //            model.ItemName = forItems1Result1_1.prd_name;
      //            model.ItemEvent_intid = items.ItemEvent_intid;
      //            model.Quantity = !items.QTY1.HasValue ? (!items.itemeventQty2.HasValue ? items.itemeventQty3 : items.itemeventQty2) : items.QTY1;
      //            model.IsSubItem = true;
      //            model.PrepAreaId = items.preparea_intid;
      //            model.ItemImageFileName = items.Prd_Image;
      //            model.PrepAreaName = items.LOCID;
      //            model.ItemImageFileName = forItems1Result1_1.prd_image;
      //            model.HasSubItem = list4 != null && Enumerable.Count<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) list4) > 0;
      //            model.UniQueItemIds = Convert.ToString(items.ItemEvent_intid) + "_" + Convert.ToString(items.Item_intid) + "_" + Convert.ToString(forItems1Result1_1.component_item_intid) + "_" + Convert.ToString(num2);
      //            ((BusinessServiceBase<fb_Items>) itemsService).Add(MappedExtensions.ToEntity(model), true);
      //            foreach (IngredientsForItems1_Result1 forItems1Result1_2 in Enumerable.ToList<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) list4))
      //              ((BusinessServiceBase<fb_Items>) itemsService).Add(MappedExtensions.ToEntity(new ItemModel()
      //              {
      //                ItemId = forItems1Result1_2.component_item_intid,
      //                ItemName = forItems1Result1_2.prd_name,
      //                ItemEvent_intid = items.ItemEvent_intid,
      //                Quantity = !items.QTY1.HasValue ? (!items.itemeventQty2.HasValue ? items.itemeventQty3 : items.itemeventQty2) : items.QTY1,
      //                IsSubItem = true,
      //                UniQueItemIds = Convert.ToString(items.ItemEvent_intid) + "_" + Convert.ToString(items.Item_intid) + "_" + Convert.ToString(forItems1Result1_1.component_item_intid) + "_" + Convert.ToString(forItems1Result1_2.component_item_intid) + "_" + Convert.ToString(2),
      //                HasSubItem = false,
      //                PrepAreaId = items.preparea_intid,
      //                PrepAreaName = items.LOCID,
      //                ItemImageFileName = forItems1Result1_2.prd_image
      //              }), true);
      //          }
      //        }
      //      }
      //    }
      //    ((BusinessServiceBase<fb_RefreshTime>) refreshService).Add(MappedExtensions.ToEntity(new RefreshTimeModel()
      //    {
      //      RefreshTime = DateTime.Now
      //    }), true);
      //    this.InitView();
      //  }
      //}
      //catch (Exception ex)
      //{
      //  this._loggerService.Error(ex);
      //  this.InitView();
      //}
      //if (AjaxRequestExtensions.IsAjaxRequest(this.Request))
      //  return (ActionResult) this.Json((object) new
      //  {
      //    result = "Sucessfully Data Loaded"
      //  });
      return (ActionResult) this.View("index", (object) this.ObjCustomer);
    }

    public void InitView()
    {
      //using (EventsService eventsService = new EventsService())
      //{
      //  IEnumerable<fb_Events> events = eventsService.GetEvents();
      //  cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //  ItemsService itemsService = new ItemsService((DbContext) ((BusinessServiceBase<fb_Events>) eventsService)._dbContext);
      //  fb_Events fbEvents = Enumerable.FirstOrDefault<fb_Events>(events);
      //  ProductionDateService productionDateService = new ProductionDateService();
      //  List<ProductionDatesModel> list1 = new List<ProductionDatesModel>();
      //  List<fb_Items> list2 = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) itemsService.GetItemsByEventListId(fbEvents.get_FSSeventlist_intid().Value));
      //  using (List<fb_Items>.Enumerator enumerator1 = list2.GetEnumerator())
      //  {
      //    while (enumerator1.MoveNext())
      //    {
      //      fb_Items current1 = enumerator1.Current;
      //      using (List<fb_ProductionDates>.Enumerator enumerator2 = productionDateService.GetAllProductionDatesByItemId(current1.get_Item_intid(), current1.get_ItemEvent_intid()).GetEnumerator())
      //      {
      //        while (enumerator2.MoveNext())
      //        {
      //          fb_ProductionDates current2 = enumerator2.Current;
      //          list1.Add(MappedExtensions.ToModel(current2));
      //        }
      //      }
      //    }
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  if (DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1b == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1b = CallSite<Func<CallSite, object, List<fb_Items>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "items2", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj1 = DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1b.Target((CallSite) DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1b, this.ViewBag, list2);
      //  // ISSUE: reference to a compiler-generated field
      //  if (DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1c == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1c = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "NoOfItems", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj2 = DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1c.Target((CallSite) DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1c, this.ViewBag, Enumerable.Count<fb_Items>((IEnumerable<fb_Items>) list2));
      //  RefreshService refreshService = new RefreshService();
      //  using (IEnumerator<fb_Events> enumerator = events.GetEnumerator())
      //  {
      //    while (((IEnumerator) enumerator).MoveNext())
      //    {
      //      fb_Events current = enumerator.Current;
      //      this.Obj = new DashboardModel();
      //      if (current.get_EventDate().HasValue)
      //        Convert.ToDateTime((object) current.get_EventDate()).ToString("MM-dd-yyyy");
      //      this.Obj.EventName = current.get_UnitName().ToString();
      //      this.Obj.EventName = this.Obj.EventName.Replace("00:00:00", "");
      //      current.set_EventName(this.Obj.EventName);
      //      this.Obj.EventDate = current.get_EventDate();
      //      this.Obj.Contract = current.get_Contract();
      //      current.set_Quantity(!current.get_Quantity().HasValue ? new Decimal?(new Decimal(0)) : current.get_Quantity());
      //      this.Obj.UnitId = new int?(current.get_UnitId().Value);
      //      this.Obj.MealName = current.get_MealName();
      //      this.Obj.ProdDate = current.get_DateOfProduction();
      //      this.Obj.NoofItems = current.get_NoofItems().Value;
      //      this.Obj.ItemEvent_intid = current.get_FSSeventlist_intid().Value;
      //      this.Obj.RefreshTime = new DateTime?(DateTime.Now);
      //      this.ObjCustomer.Add(this.Obj);
      //    }
      //  }
      //  List<EventModel> list3 = new List<EventModel>();
      //  using (IEnumerator<fb_Events> enumerator = events.GetEnumerator())
      //  {
      //    while (((IEnumerator) enumerator).MoveNext())
      //    {
      //      // ISSUE: object of a compiler-generated type is created
      //      // ISSUE: variable of a compiler-generated type
      //      DashboardController.\u003C\u003Ec__DisplayClass1e cDisplayClass1e = new DashboardController.\u003C\u003Ec__DisplayClass1e();
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass1e.item = enumerator.Current;
      //      ParameterExpression parameterExpression1;
      //      ParameterExpression parameterExpression2;
      //      // ISSUE: method reference
      //      // ISSUE: field reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      List<DateTime> list4 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Distinct<DateTime>(Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.Equal((Expression) Expression.Convert((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), typeof (int?)), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass1e), FieldInfo.GetFieldFromHandle(__fieldref (DashboardController.\u003C\u003Ec__DisplayClass1e.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid)))), new ParameterExpression[1]
      //      {
      //        parameterExpression1
      //      })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //      {
      //        parameterExpression2
      //      }))));
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      list3.Add(new EventModel()
      //      {
      //        Contract = cDisplayClass1e.item.get_Contract(),
      //        DateOfProduction = cDisplayClass1e.item.get_DateOfProduction(),
      //        Description = cDisplayClass1e.item.get_Description(),
      //        EventDate = cDisplayClass1e.item.get_EventDate(),
      //        EventId = cDisplayClass1e.item.get_EventId(),
      //        EventName = cDisplayClass1e.item.get_EventName(),
      //        FSSeventlist_intid = cDisplayClass1e.item.get_FSSeventlist_intid(),
      //        MealName = cDisplayClass1e.item.get_MealName(),
      //        NoofItems = cDisplayClass1e.item.get_NoofItems(),
      //        ProductionDate = list4.Count == 0 ? "NA" : (list4.Count > 1 ? "Multiple" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list4).ToString("MM/dd/yyyy")),
      //        Quantity = cDisplayClass1e.item.get_Quantity(),
      //        TeamLead = cDisplayClass1e.item.get_TeamLead(),
      //        UnitId = cDisplayClass1e.item.get_UnitId(),
      //        UnitName = cDisplayClass1e.item.get_UnitName()
      //      });
      //    }
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  if (DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1d == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1d = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "events", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj3 = DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1d.Target((CallSite) DashboardController.\u003CInitView\u003Eo__SiteContainer1a.\u003C\u003Ep__Site1d, this.ViewBag, JsonConvert.SerializeObject((object) list3));
      //}
    }

    public ActionResult TeamLeadIndex()
    {
      return (ActionResult) this.View();
    }

    public ActionResult Ingredient(int id, string eventId, string itemName)
    {
      // ISSUE: reference to a compiler-generated field
      //if (DashboardController.\u003CIngredient\u003Eo__SiteContainer22.\u003C\u003Ep__Site23 == null)
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  DashboardController.\u003CIngredient\u003Eo__SiteContainer22.\u003C\u003Ep__Site23 = CallSite<Func<CallSite, object, string, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ItemName", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  {
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //  }));
      //}
      //// ISSUE: reference to a compiler-generated field
      //// ISSUE: reference to a compiler-generated field
      //object obj = DashboardController.\u003CIngredient\u003Eo__SiteContainer22.\u003C\u003Ep__Site23.Target((CallSite) DashboardController.\u003CIngredient\u003Eo__SiteContainer22.\u003C\u003Ep__Site23, this.ViewBag, itemName);
      //List<IngredientsModel> list1 = new List<IngredientsModel>();
      //cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //foreach (IngredientsForItems1_Result1 forItems1Result1 in Enumerable.ToList<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) cbordTestEntities.IngredientsForItems1(new int?(id))))
      //  list1.Add(new IngredientsModel()
      //  {
      //    ComponentItemID = forItems1Result1.component_item_intid,
      //    Prdname = forItems1Result1.prd_name,
      //    Qty = forItems1Result1.qty,
      //    Description = forItems1Result1.description,
      //    ItemuofmCompoundtext = forItems1Result1.itemuofm_compoundtext
      //  });
      //foreach (IngredientsModel ingredientsModel in list1)
      //{
      //  List<IngredientsForItems1_Result1> list2 = Enumerable.ToList<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) cbordTestEntities.IngredientsForItems1(new int?(ingredientsModel.ComponentItemID)));
      //  List<SubItemsModel> list3 = new List<SubItemsModel>();
      //  foreach (IngredientsForItems1_Result1 forItems1Result1 in list2)
      //  {
      //    list3.Add(new SubItemsModel()
      //    {
      //      MainItemID = ingredientsModel.ComponentItemID,
      //      SubItemID = forItems1Result1.assemblage_item_intid,
      //      SubDescription = forItems1Result1.prd_name,
      //      SubItemuofmCompoundtext = forItems1Result1.itemuofm_compoundtext
      //    });
      //    ingredientsModel.SubItemsModel.AddRange((IEnumerable<SubItemsModel>) list3);
      //  }
      //}
      //return (ActionResult) this.View((object) list1);
      return null;
    }

    [HttpPost]
    public ActionResult Receipe(DashboardModel.ThirdMode thirdModel, string ItemId)
    {
      // ISSUE: reference to a compiler-generated field
      //if (DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site27 == null)
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site27 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ItemId", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  {
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //  }));
      //}
      //// ISSUE: reference to a compiler-generated field
      //// ISSUE: reference to a compiler-generated field
      //object obj1 = DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site27.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site27, this.ViewBag, Convert.ToInt32(ItemId));
      //using (SqlConnection connection = new SqlConnection(new cbord_testEntities().get_Database().get_Connection().ConnectionString))
      //{
      //  using (SqlCommand sqlCommand = new SqlCommand("cbord.proc_startrecipes", connection))
      //  {
      //    sqlCommand.CommandType = CommandType.StoredProcedure;
      //    List<string> list1 = new List<string>();
      //    sqlCommand.Parameters.Add("@eventId", SqlDbType.Int).Value = (object) Convert.ToInt32(thirdModel.EventId);
      //    sqlCommand.Parameters.Add("@itemId", SqlDbType.Int).Value = (object) Convert.ToInt32(ItemId);
      //    sqlCommand.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = (object) Convert.ToInt32(thirdModel.Quantity);
      //    connection.Open();
      //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
      //    DataSet dataSet = new DataSet();
      //    sqlDataAdapter.SelectCommand = sqlCommand;
      //    sqlDataAdapter.Fill(dataSet, "Results");
      //    List<DashboardModel.FirtModel> list2 = new List<DashboardModel.FirtModel>();
      //    List<DashboardModel.SecondModel> list3 = new List<DashboardModel.SecondModel>();
      //    if (dataSet.Tables[1].Rows.Count > 0)
      //    {
      //      foreach (DataRow dataRow in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
      //        list2.Add(new DashboardModel.FirtModel()
      //        {
      //          ProdDate = Convert.ToDateTime(dataRow["prod_date"]).ToString("MM/dd/yyyy"),
      //          Portions = Convert.ToString(dataRow["portion_ingrround"]),
      //          CookingTemp = "",
      //          CookingTime = "",
      //          itemName = Convert.ToString(dataRow["longname"]),
      //          PrepTemp = "",
      //          PrepTime = "",
      //          ProdShift = Convert.ToString(dataRow["mealname"]),
      //          Yield = Convert.ToString(dataRow["yield_ingrround"]),
      //          AssemblageID = Convert.ToInt32(dataRow["assemblage"]),
      //          Prodrecipe_intid = Convert.ToInt32(dataRow["prodrecipe_intid"])
      //        });
      //      cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //      foreach (DataRow dataRow in (InternalDataCollectionBase) dataSet.Tables[1].Rows)
      //        list3.Add(new DashboardModel.SecondModel()
      //        {
      //          IngedientSize = Convert.ToString(dataRow["QTY_UNIT_STRING"]),
      //          IngriedentsName = Convert.ToString(dataRow["PRD_NAME"]),
      //          Note = Convert.ToString(dataRow["Note"]) == null ? "" : Convert.ToString(dataRow["Note"]),
      //          ComponentID = Convert.ToInt32(dataRow["componentid"]),
      //          subitemCount = Enumerable.Count<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) cbordTestEntities.IngredientsForItems1(new int?(Convert.ToInt32(dataRow["componentid"])))),
      //          AssemblageID = Convert.ToInt32(dataRow["assemblageid"]),
      //          Prodrecipe_intid = Convert.ToInt32(dataRow["prodrecipe_intid"])
      //        });
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    if (DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site28 == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site28 = CallSite<Func<CallSite, object, List<DashboardModel.FirtModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "FirstModel", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj2 = DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site28.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site28, this.ViewBag, Enumerable.ToList<DashboardModel.FirtModel>(Enumerable.Where<DashboardModel.FirtModel>((IEnumerable<DashboardModel.FirtModel>) list2, (Func<DashboardModel.FirtModel, bool>) (x => x.AssemblageID == thirdModel.AssemblageID))));
      //    // ISSUE: reference to a compiler-generated field
      //    if (DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site29 == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site29 = CallSite<Func<CallSite, object, List<DashboardModel.SecondModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "SecondModel", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj3 = DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site29.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site29, this.ViewBag, Enumerable.ToList<DashboardModel.SecondModel>(Enumerable.Where<DashboardModel.SecondModel>((IEnumerable<DashboardModel.SecondModel>) list3, (Func<DashboardModel.SecondModel, bool>) (x => x.AssemblageID == thirdModel.AssemblageID))));
      //    // ISSUE: reference to a compiler-generated field
      //    if (DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site2a == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site2a = CallSite<Func<CallSite, object, Decimal, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Quantity", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj4 = DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site2a.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer26.\u003C\u003Ep__Site2a, this.ViewBag, Math.Round(Convert.ToDecimal(dataSet.Tables[2].Rows[0]["Qty3"]), 1));
      //  }
        return (ActionResult) this.View((object) thirdModel);
     //}
    }

    public ActionResult Receipe(int EventListId, int ItemId, Decimal Quantity, int asid)
    {
      cbord_testEntities cbordTestEntities = new cbord_testEntities();
      DbContext dbContext = (DbContext) new cbord_testEntities();
      //// ISSUE: reference to a compiler-generated field
      //if (DashboardController.objectsList1 == null)
      //{
      //  // ISSUE: reference to a compiler-generated field
      //  //DashboardController.objectsList1 = CallSite<Func<CallSite, object, int, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ItemId", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //  //{
      //  //  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //  //  CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //  //}));
      //}
      //// ISSUE: reference to a compiler-generated field
      //// ISSUE: reference to a compiler-generated field
      //object obj1 = DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site34.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site34, this.ViewBag, ItemId);
      //DashboardModel.ThirdMode thirdMode = new DashboardModel.ThirdMode();
      //using (SqlConnection connection = new SqlConnection(dbContext.get_Database().get_Connection().ConnectionString))
      //{
      //  using (SqlCommand sqlCommand = new SqlCommand("cbord.proc_startrecipes", connection))
      //  {
      //    sqlCommand.CommandType = CommandType.StoredProcedure;
      //    List<string> list1 = new List<string>();
      //    sqlCommand.Parameters.Add("@eventId", SqlDbType.Int).Value = (object) EventListId;
      //    sqlCommand.Parameters.Add("@itemId", SqlDbType.Int).Value = (object) ItemId;
      //    sqlCommand.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = (object) Quantity;
      //    connection.Open();
      //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
      //    DataSet dataSet = new DataSet();
      //    sqlDataAdapter.SelectCommand = sqlCommand;
      //    sqlDataAdapter.Fill(dataSet, "Results");
      //    List<DashboardModel.FirtModel> list2 = new List<DashboardModel.FirtModel>();
      //    List<DashboardModel.SecondModel> list3 = new List<DashboardModel.SecondModel>();
      //    if (dataSet.Tables[1].Rows.Count > 0)
      //    {
      //      foreach (DataRow dataRow in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
      //        list2.Add(new DashboardModel.FirtModel()
      //        {
      //          ProdDate = Convert.ToDateTime(dataRow["prod_date"]).ToString("MM/dd/yyyy"),
      //          Portions = Convert.ToString(dataRow["portion_ingrround"]),
      //          CookingTemp = "",
      //          CookingTime = "",
      //          itemName = Convert.ToString(dataRow["longname"]),
      //          PrepTemp = "",
      //          PrepTime = "",
      //          ProdShift = Convert.ToString(dataRow["mealname"]),
      //          Yield = Convert.ToString(dataRow["yield_ingrround"]),
      //          AssemblageID = Convert.ToInt32(dataRow["assemblage"]),
      //          Prodrecipe_intid = Convert.ToInt32(dataRow["prodrecipe_intid"])
      //        });
      //      foreach (DataRow dataRow in (InternalDataCollectionBase) dataSet.Tables[1].Rows)
      //        list3.Add(new DashboardModel.SecondModel()
      //        {
      //          IngedientSize = Convert.ToString(dataRow["QTY_UNIT_STRING"]),
      //          IngriedentsName = Convert.ToString(dataRow["PRD_NAME"]),
      //          Note = Convert.ToString(dataRow["Note"]) == null ? "" : Convert.ToString(dataRow["Note"]),
      //          ComponentID = Convert.ToInt32(dataRow["componentid"]),
      //          subitemCount = Enumerable.Count<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) cbordTestEntities.IngredientsForItems1(new int?(Convert.ToInt32(dataRow["componentid"])))),
      //          AssemblageID = Convert.ToInt32(dataRow["assemblageid"]),
      //          Prodrecipe_intid = Convert.ToInt32(dataRow["prodrecipe_intid"])
      //        });
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    if (DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site35 == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site35 = CallSite<Func<CallSite, object, List<DashboardModel.FirtModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "FirstModel", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj2 = DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site35.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site35, this.ViewBag, Enumerable.ToList<DashboardModel.FirtModel>(Enumerable.Where<DashboardModel.FirtModel>((IEnumerable<DashboardModel.FirtModel>) list2, (Func<DashboardModel.FirtModel, bool>) (x => x.AssemblageID == asid))));
      //    // ISSUE: reference to a compiler-generated field
      //    if (DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site36 == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site36 = CallSite<Func<CallSite, object, List<DashboardModel.SecondModel>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "SecondModel", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj3 = DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site36.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site36, this.ViewBag, Enumerable.ToList<DashboardModel.SecondModel>(Enumerable.Where<DashboardModel.SecondModel>((IEnumerable<DashboardModel.SecondModel>) list3, (Func<DashboardModel.SecondModel, bool>) (x => x.AssemblageID == asid))));
      //    // ISSUE: reference to a compiler-generated field
      //    if (DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site37 == null)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site37 = CallSite<Func<CallSite, object, Decimal, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Quantity", typeof (DashboardController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //      {
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //        CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //      }));
      //    }
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    object obj4 = DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site37.Target((CallSite) DashboardController.\u003CReceipe\u003Eo__SiteContainer33.\u003C\u003Ep__Site37, this.ViewBag, Math.Round(Convert.ToDecimal(dataSet.Tables[2].Rows[0]["Qty3"]), 1));
      //    thirdMode.EventId = EventListId.ToString();
      //    thirdMode.Quantity = Quantity;
      //    thirdMode.ItemId = ItemId.ToString();
      //    thirdMode.AssemblageID = asid;
      //  }
        //return (ActionResult) this.View((object) thirdMode);
      //}
      return null;
    }

    public ActionResult Print(int EventListId, int ItemId, Decimal Quantity, int asid, string Items)
    {
      //Document document = new Document(((Rectangle) PageSize.A4).Rotate());
      //using (MemoryStream memoryStream = new MemoryStream())
      //{
      //  PdfWriter.GetInstance(document, (Stream) memoryStream);
      //  document.Open();
      //  new HTMLWorkerExtended((IDocListener) document).Parse((TextReader) new StringReader(this.GetHTMLforPdf(EventListId, ItemId, Quantity, asid, Items)));
      //  document.Close();
      //  byte[] buffer = memoryStream.ToArray();
      //  memoryStream.Close();
      //  this.Response.Clear();
      //  this.Response.ContentType = "application/pdf";
      //  this.Response.AddHeader("Content-Disposition", "attachment; filename=SampleRecipe.pdf");
      //  this.Response.ContentType = "application/pdf";
      //  this.Response.Buffer = true;
      //  this.Response.Cache.SetCacheability(HttpCacheability.NoCache);
      //  this.Response.BinaryWrite(buffer);
      //  this.Response.End();
      //  this.Response.Close();
      //}
      return (ActionResult) this.View();
    }

    private string GetHTMLforPdf(int EventListId, int ItemId, Decimal Quantity, int asid, string SubItemIds = "")
    {
      StringBuilder stringBuilder = new StringBuilder();
      cbord_testEntities cbordTestEntities = new cbord_testEntities();
      DbContext dbContext = (DbContext) new cbord_testEntities();
      DashboardModel.ThirdMode thirdMode = new DashboardModel.ThirdMode();
      //using (SqlConnection connection = new SqlConnection(dbContext.get_Database().get_Connection().ConnectionString))
      //{
      //  using (SqlCommand sqlCommand = new SqlCommand("cbord.proc_startrecipes", connection))
      //  {
      //    sqlCommand.CommandType = CommandType.StoredProcedure;
      //    List<string> list1 = new List<string>();
      //    sqlCommand.Parameters.Add("@eventId", SqlDbType.Int).Value = (object) EventListId;
      //    sqlCommand.Parameters.Add("@itemId", SqlDbType.Int).Value = (object) ItemId;
      //    sqlCommand.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = (object) Quantity;
      //    connection.Open();
      //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
      //    DataSet dataSet = new DataSet();
      //    sqlDataAdapter.SelectCommand = sqlCommand;
      //    sqlDataAdapter.Fill(dataSet, "Results");
      //    List<DashboardModel.FirtModel> list2 = new List<DashboardModel.FirtModel>();
      //    List<DashboardModel.SecondModel> list3 = new List<DashboardModel.SecondModel>();
      //    if (dataSet.Tables.Count > 0)
      //    {
      //      foreach (DataRow dataRow in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
      //        list2.Add(new DashboardModel.FirtModel()
      //        {
      //          ProdDate = Convert.ToDateTime(dataRow["prod_date"]).ToString("MM/dd/yyyy"),
      //          Portions = Convert.ToString(dataRow["portion_ingrround"]),
      //          CookingTemp = "",
      //          CookingTime = "",
      //          itemName = Convert.ToString(dataRow["longname"]),
      //          PrepTemp = "",
      //          PrepTime = "",
      //          ProdShift = Convert.ToString(dataRow["mealname"]),
      //          Yield = Convert.ToString(dataRow["yield_ingrround"]),
      //          AssemblageID = Convert.ToInt32(dataRow["assemblage"]),
      //          Prodrecipe_intid = Convert.ToInt32(dataRow["prodrecipe_intid"])
      //        });
      //      foreach (DataRow dataRow in (InternalDataCollectionBase) dataSet.Tables[1].Rows)
      //        list3.Add(new DashboardModel.SecondModel()
      //        {
      //          IngedientSize = Convert.ToString(dataRow["QTY_UNIT_STRING"]),
      //          IngriedentsName = Convert.ToString(dataRow["PRD_NAME"]),
      //          Note = Convert.ToString(dataRow["Note"]) == null ? "" : Convert.ToString(dataRow["Note"]),
      //          ComponentID = Convert.ToInt32(dataRow["componentid"]),
      //          subitemCount = Enumerable.Count<IngredientsForItems1_Result1>((IEnumerable<IngredientsForItems1_Result1>) cbordTestEntities.IngredientsForItems1(new int?(Convert.ToInt32(dataRow["componentid"])))),
      //          AssemblageID = Convert.ToInt32(dataRow["assemblageid"]),
      //          Prodrecipe_intid = Convert.ToInt32(dataRow["prodrecipe_intid"])
      //        });
      //    }
      //    List<DashboardModel.SecondModel> list4 = Enumerable.ToList<DashboardModel.SecondModel>(Enumerable.Where<DashboardModel.SecondModel>((IEnumerable<DashboardModel.SecondModel>) list3, (Func<DashboardModel.SecondModel, bool>) (x => x.AssemblageID == asid)));
      //    DashboardModel.FirtModel firtModel = Enumerable.FirstOrDefault<DashboardModel.FirtModel>((IEnumerable<DashboardModel.FirtModel>) Enumerable.ToList<DashboardModel.FirtModel>(Enumerable.Where<DashboardModel.FirtModel>((IEnumerable<DashboardModel.FirtModel>) list2, (Func<DashboardModel.FirtModel, bool>) (x => x.AssemblageID == asid))));
      //    stringBuilder.Append("<table align='center' width='90%'>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td width='50%' align='left'>");
      //    stringBuilder.Append("<h1><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>" + firtModel.itemName + "</font></h1>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("<td width='50%'>");
      //    stringBuilder.Append("<table width='100%' cellspacing='0' border='0' style='float:right;'>");
      //    stringBuilder.Append("<tbody>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td align='right' ><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>Production Recipe &amp; Date: <b>" + firtModel.ProdDate.ToString() + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td align='right'><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>Production Shift: <b>" + firtModel.ProdShift + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("</tbody>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr><td height='15' colspan='2'>&nbsp;</td></tr>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("<br/>");
      //    stringBuilder.Append("<table align='center' width='90%' cellspacing='0' cellpadding='0' style='border-color: #2a2a2a' border='1' style='margin-bottom:15px'>");
      //    stringBuilder.Append("<tbody>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<th width='33%'><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'><b>&nbsp;Times</b></font></th>");
      //    stringBuilder.Append("<th width='33%'><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'><b>&nbsp;Temperatures</b></font></th>");
      //    stringBuilder.Append("<th width='33%'><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'><b>&nbsp;Production Amount</b></font></th>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td>");
      //    stringBuilder.Append("<table width='100%' cellspacing='0' cellpadding='0' border='0'>");
      //    stringBuilder.Append("<tbody>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;Prep Time: <b>" + firtModel.PrepTime + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;Cooking Time: <b>" + firtModel.CookingTime + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("</tbody>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("<td>");
      //    stringBuilder.Append("<table width='100%' cellspacing='0' cellpadding='0' border='0'>");
      //    stringBuilder.Append("<tbody>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;Cooking: <b>" + firtModel.CookingTemp + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;Internal: <b>" + firtModel.PrepTemp + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("</tbody>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("<td>");
      //    stringBuilder.Append("<table width='100%' cellspacing='0' cellpadding='0' border='0'>");
      //    stringBuilder.Append("<tbody>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;Yield: <b>" + firtModel.Yield + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;Portions: <b>" + firtModel.Portions + "</b></font></td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("</tbody>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("<tr><td height='15' colspan='3'>&nbsp;</td></tr>");
      //    stringBuilder.Append("</tbody>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("<br/>");
      //    stringBuilder.Append("<table align='center' width='90%'>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td align='left'>");
      //    stringBuilder.Append("<h2><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>Ingredients &amp; Instructions &amp; Quantity(" + (object) Quantity + ") </font></h2>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("<br/>");
      //    stringBuilder.Append("<table cellpadding='0' cellspacing='0' border='1' width='90%' align='center'>");
      //    List<DashboardModel.SecondModel> list5 = Enumerable.ToList<DashboardModel.SecondModel>(Enumerable.Where<DashboardModel.SecondModel>((IEnumerable<DashboardModel.SecondModel>) list3, (Func<DashboardModel.SecondModel, bool>) (x => x.AssemblageID == asid)));
      //    foreach (DashboardModel.SecondModel secondModel in list5)
      //    {
      //      stringBuilder.Append("<tr>");
      //      if (secondModel.subitemCount > 0)
      //      {
      //        stringBuilder.Append("<td width='60%' id='tdsubitems'><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp;");
      //        stringBuilder.Append(secondModel.IngriedentsName);
      //        stringBuilder.Append("</font></td>");
      //      }
      //      else
      //        stringBuilder.Append("<td width='60%'><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp; " + secondModel.IngriedentsName + "</font></td>");
      //      stringBuilder.Append("<td><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>&nbsp; " + secondModel.IngedientSize + "</font></td>");
      //      stringBuilder.Append("</tr>");
      //    }
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("<br/>");
      //    stringBuilder.Append("<table align='center' width='90%'>");
      //    stringBuilder.Append("<tr>");
      //    stringBuilder.Append("<td align='left'>");
      //    stringBuilder.Append("<h3><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>Preparation</font></h3>");
      //    stringBuilder.Append("</td>");
      //    stringBuilder.Append("</tr>");
      //    stringBuilder.Append("</table>");
      //    stringBuilder.Append("");
      //    List<DashboardModel.SecondModel> list6 = list4;
      //    if (list6.Count > 0)
      //    {
      //      foreach (DashboardModel.SecondModel secondModel in list6)
      //      {
      //        if (!string.IsNullOrEmpty(secondModel.Note))
      //        {
      //          string[] strArray = secondModel.Note.Split(new string[1]
      //          {
      //            Environment.NewLine
      //          }, StringSplitOptions.None);
      //          stringBuilder.Append("<table align='center' width='85%'>");
      //          stringBuilder.Append("<tr>");
      //          stringBuilder.Append("<td align='left'>");
      //          stringBuilder.Append("<div>");
      //          foreach (string str in strArray)
      //          {
      //            if (str != "")
      //              stringBuilder.Append("<div><font face='Trebuchet MS, Arial, Helvetica, sans-serif' color='#2a2a2a'>" + str + "</font></div>");
      //          }
      //          stringBuilder.Append("</div>");
      //          stringBuilder.Append("</td>");
      //          stringBuilder.Append("</tr>");
      //          stringBuilder.Append("</table>");
      //        }
      //      }
      //    }
      //    if (string.IsNullOrEmpty(SubItemIds))
      //      SubItemIds = "0";
      //    List<int> list7 = Enumerable.ToList<int>(Enumerable.Select<string, int>((IEnumerable<string>) SubItemIds.Split(','), new Func<string, int>(int.Parse)));
      //    foreach (DashboardModel.SecondModel secondModel in list5)
      //    {
      //      DashboardModel.SecondModel item3 = secondModel;
      //      if (Enumerable.Count<int>(Enumerable.Where<int>((IEnumerable<int>) list7, (Func<int, bool>) (I => I.Equals(item3.ComponentID)))) > 0 && item3.subitemCount > 0)
      //      {
      //        stringBuilder.Append("<div style='page-break-before:always'>&nbsp;</div>");
      //        stringBuilder.Append("<newpage />");
      //        stringBuilder.Append(this.GetHTMLforPdf(EventListId, ItemId, Quantity, item3.ComponentID, ""));
      //      }
      //    }
      //  }
      //}
      return stringBuilder.ToString();
    }

    public ActionResult GetEventStatus(string productionDate)
    {
      try
      {
        return (ActionResult) this.Json((object) new
        {
          status = "success",
         // EventStatusModel = new ViewItemsService().GetEventStatusByProductionDate(productionDate)
        });
      }
      catch (Exception ex)
      {
        this._loggerService.Error(ex);
        return (ActionResult) this.Json((object) new
        {
          result = "Fail"
        }, JsonRequestBehavior.AllowGet);
      }
    }
  }
}
