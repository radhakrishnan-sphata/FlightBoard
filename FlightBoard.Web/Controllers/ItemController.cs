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
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace FlightBoard.Web.Controllers
{
  [FBAuthorize]
  [OutputCache(Duration = 0, NoStore = true, VaryByParam = "*")]
  public class ItemController : BaseController
  {
    public ActionResult Index(int Id = 0, string Contract = "", string ItemName = "", string fromdate = "", string Todate = "", string IsBack = "", string EventDate = "", string EventEndDate = "")
    {
      ItemModel itemModel = new ItemModel();
      itemModel.EventId = Id;
      if (Contract != "")
        itemModel.EventName = Contract;
      if (this.Session["ItemName"] != null)
        itemModel.ItemName = this.Session["ItemName"].ToString();
      if (this.Session["Contract"] != null)
        itemModel.EventName = this.Session["Contract"].ToString();
      if (this.Session["FromDate"] != null && this.Session["ToDate"] != null)
      {
        itemModel.ProductionFrom = this.Session["FromDate"].ToString();
        itemModel.ProductionTo = this.Session["ToDate"].ToString();
        itemModel.EventDate = (string) null;
        itemModel.EventEndDate = (string) null;
      }
      if (this.Session["EventDate"] != null && this.Session["EventEndDate"] != null)
      {
        itemModel.EventDate = this.Session["EventDate"].ToString();
        itemModel.EventEndDate = this.Session["EventEndDate"].ToString();
        itemModel.ProductionFrom = (string) null;
        itemModel.ProductionTo = (string) null;
      }
      if (this.Session["FromDate"] != null && this.Session["ToDate"] != null && (this.Session["EventDate"] != null && this.Session["EventEndDate"] != null))
      {
        itemModel.ProductionFrom = this.Session["FromDate"].ToString();
        itemModel.ProductionTo = this.Session["ToDate"].ToString();
        itemModel.EventDate = this.Session["EventDate"].ToString();
        itemModel.EventEndDate = this.Session["EventEndDate"].ToString();
      }
      itemModel.IsBack = IsBack == "True";
      return (ActionResult) this.View((object) itemModel);
    }

    [AcceptVerbs(HttpVerbs.Post)]
    public ActionResult Find(JqGridRequest request, string ItemName, string EventContract, string fromdate, string Todate, int EventId, string EventDate, string EventEndDate, string ContractId, int Show, string Search, bool IsBack)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //ItemController.\u003C\u003Ec__DisplayClass8 cDisplayClass8 = new ItemController.\u003C\u003Ec__DisplayClass8();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass8.ItemName = ItemName;
      //this.Session["ItemName"] = (object) null;
      //this.Session["Contract"] = (object) null;
      //this.Session["FromDate"] = (object) null;
      //this.Session["ToDate"] = (object) null;
      //this.Session["EventDate"] = (object) null;
      //this.Session["EventEndDate"] = (object) null;
      //// ISSUE: reference to a compiler-generated field
      //Search = cDisplayClass8.ItemName != "" || ContractId != "" || (fromdate != "" || Todate != "") || (EventDate != "" || EventEndDate != "") ? "Yes" : "No";
      //using (TeamService teamService = new TeamService())
      //{
      //  try
      //  {
      //    ItemsService itemsService = new ItemsService((DbContext) ((BusinessServiceBase<fb_Teams>) teamService)._dbContext);
      //    EventsService eventsService = new EventsService((DbContext) ((BusinessServiceBase<fb_Teams>) teamService)._dbContext);
      //    BatchItemService batchItemService = new BatchItemService((DbContext) ((BusinessServiceBase<fb_Teams>) teamService)._dbContext);
      //    List<fb_Items> list1 = new List<fb_Items>();
      //    if (Search != "No" || EventId > 0)
      //    {
      //      // ISSUE: reference to a compiler-generated field
      //      list1 = Enumerable.ToList<fb_Items>((IEnumerable<fb_Items>) itemsService.GetItemsByItemNameOrderByEventID(cDisplayClass8.ItemName, EventId, EventDate, EventEndDate, ContractId, Show, fromdate, Todate));
      //    }
      //    List<fb_Items_Data> list2 = new List<fb_Items_Data>();
      //    List<AssignItem> list3 = new List<AssignItem>();
      //    AssignItemService assignItemService = new AssignItemService((DbContext) ((BusinessServiceBase<fb_Teams>) teamService)._dbContext);
      //    ProductionDateService productionDateService = new ProductionDateService((DbContext) ((BusinessServiceBase<fb_Teams>) teamService)._dbContext);
      //    int num = 0;
      //    List<int> list4 = new List<int>();
      //    List<AssignItem> list5 = EventId != 0 || list1.Count <= 0 ? assignItemService.GetItemsByEventid(EventId) : assignItemService.GetAssignItemsbyListOfItems(list1);
      //    if (list1.Count > 0)
      //    {
      //      List<int> list6 = Enumerable.ToList<int>(Enumerable.Select<AssignItem, int>((IEnumerable<AssignItem>) list5, (Func<AssignItem, int>) (p => p.get_ItemId())));
      //      using (List<fb_Items>.Enumerator enumerator = list1.GetEnumerator())
      //      {
      //        while (enumerator.MoveNext())
      //        {
      //          // ISSUE: object of a compiler-generated type is created
      //          // ISSUE: variable of a compiler-generated type
      //          ItemController.\u003C\u003Ec__DisplayClassd cDisplayClassd = new ItemController.\u003C\u003Ec__DisplayClassd();
      //          // ISSUE: reference to a compiler-generated field
      //          cDisplayClassd.CS\u0024\u003C\u003E8__locals9 = cDisplayClass8;
      //          // ISSUE: reference to a compiler-generated field
      //          cDisplayClassd.val = enumerator.Current;
      //          // ISSUE: reference to a compiler-generated method
      //          // ISSUE: reference to a compiler-generated method
      //          string str1 = Enumerable.FirstOrDefault<fb_Events>(Enumerable.Where<fb_Events>(eventsService.GetEvents(), new Func<fb_Events, bool>(cDisplayClassd.\u003CFind\u003Eb__2))).get_Contract() == null ? "" : Enumerable.FirstOrDefault<fb_Events>(Enumerable.Where<fb_Events>(eventsService.GetEvents(), new Func<fb_Events, bool>(cDisplayClassd.\u003CFind\u003Eb__3))).get_Contract();
      //          // ISSUE: reference to a compiler-generated method
      //          string str2 = Enumerable.FirstOrDefault<fb_Events>(Enumerable.Where<fb_Events>(eventsService.GetEvents(), new Func<fb_Events, bool>(cDisplayClassd.\u003CFind\u003Eb__4))).get_EventDate().Value.ToString("MM/dd/yyyy");
      //          // ISSUE: reference to a compiler-generated field
      //          // ISSUE: reference to a compiler-generated field
      //          List<fb_BatchItems> batchItems = batchItemService.GetBatchItems(cDisplayClassd.val.get_ItemEvent_intid(), cDisplayClassd.val.get_Item_intid());
      //          if (fromdate != "")
      //          {
      //            // ISSUE: object of a compiler-generated type is created
      //            // ISSUE: variable of a compiler-generated type
      //            ItemController.\u003C\u003Ec__DisplayClassf cDisplayClassf = new ItemController.\u003C\u003Ec__DisplayClassf();
      //            // ISSUE: reference to a compiler-generated field
      //            cDisplayClassf.CS\u0024\u003C\u003E8__localse = cDisplayClassd;
      //            // ISSUE: reference to a compiler-generated field
      //            cDisplayClassf.CS\u0024\u003C\u003E8__locals9 = cDisplayClass8;
      //            // ISSUE: reference to a compiler-generated field
      //            cDisplayClassf.fromproddate = DateTime.ParseExact(fromdate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      //            // ISSUE: reference to a compiler-generated field
      //            cDisplayClassf.fromtodate = DateTime.ParseExact(Todate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      //            DateTime.ParseExact(fromdate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      //            DateTime.ParseExact(fromdate, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture);
      //            ParameterExpression parameterExpression1;
      //            ParameterExpression parameterExpression2;
      //            // ISSUE: method reference
      //            // ISSUE: field reference
      //            // ISSUE: method reference
      //            // ISSUE: method reference
      //            // ISSUE: field reference
      //            // ISSUE: method reference
      //            // ISSUE: method reference
      //            // ISSUE: field reference
      //            // ISSUE: method reference
      //            // ISSUE: method reference
      //            // ISSUE: field reference
      //            // ISSUE: method reference
      //            // ISSUE: method reference
      //            List<DateTime> list7 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Distinct<DateTime>(Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClassd.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClassd.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))))), (Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClassf.fromproddate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual)))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassf), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClassf.fromtodate))), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual)))), new ParameterExpression[1]
      //            {
      //              parameterExpression1
      //            })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //            {
      //              parameterExpression2
      //            }))));
      //            if (list5.Count > 0)
      //            {
      //              // ISSUE: reference to a compiler-generated field
      //              if (!list6.Contains(cDisplayClassd.val.get_Item_intid()))
      //              {
      //                fb_Items_Data fbItemsData = new fb_Items_Data();
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_EventID(cDisplayClassd.val.get_ItemEvent_intid());
      //                fbItemsData.set_BatchName(batchItems.Count > 0 ? "Yes" : "No");
      //                fbItemsData.set_ProductionFrom(list7.Count > 1 ? "Multiple" : (list7.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list7).ToString()));
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ProductionFrom(fbItemsData.get_ProductionFrom() + (object) "~" + (string) (object) cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                fbItemsData.set_ContractID(str1);
      //                fbItemsData.set_EventDate(str2);
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_IsSubItem(cDisplayClassd.val.get_IsSubItem());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_Quantity(cDisplayClassd.val.get_Quantity());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ID(cDisplayClassd.val.get_ID());
      //                if (EventId == 0)
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                else
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                if (fbItemsData.get_TeamLead() != null)
      //                  ++num;
      //                list2.Add(fbItemsData);
      //              }
      //              else
      //              {
      //                fb_Items_Data fbItemsData = new fb_Items_Data();
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_EventID(cDisplayClassd.val.get_ItemEvent_intid());
      //                fbItemsData.set_ProductionFrom(list7.Count > 1 ? "Multiple" : (list7.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list7).ToString("MM/dd/yyyy")));
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ProductionFrom(fbItemsData.get_ProductionFrom() + (object) "~" + (string) (object) cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                fbItemsData.set_BatchName(batchItems.Count > 0 ? "Yes" : "No");
      //                fbItemsData.set_ContractID(str1);
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_IsSubItem(cDisplayClassd.val.get_IsSubItem());
      //                fbItemsData.set_EventDate(str2);
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_Quantity(cDisplayClassd.val.get_Quantity());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ID(cDisplayClassd.val.get_ID());
      //                if (EventId == 0)
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                else
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                if (fbItemsData.get_TeamLead() != null)
      //                  ++num;
      //                list2.Add(fbItemsData);
      //              }
      //            }
      //            else
      //            {
      //              fb_Items_Data fbItemsData = new fb_Items_Data();
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //              fbItemsData.set_ContractID(str1);
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_IsSubItem(cDisplayClassd.val.get_IsSubItem());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_EventID(cDisplayClassd.val.get_ItemEvent_intid());
      //              fbItemsData.set_BatchName(batchItems.Count > 0 ? "Yes" : "No");
      //              fbItemsData.set_EventDate(str2);
      //              fbItemsData.set_ProductionFrom(list7.Count > 1 ? "Multiple" : (list7.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list7).ToString("MM/dd/yyyy")));
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ProductionFrom(fbItemsData.get_ProductionFrom() + (object) "~" + (string) (object) cDisplayClassd.val.get_Item_intid());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_Quantity(cDisplayClassd.val.get_Quantity());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ID(cDisplayClassd.val.get_ID());
      //              if (EventId == 0)
      //              {
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //              }
      //              else
      //              {
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //              }
      //              if (fbItemsData.get_TeamLead() != null)
      //                ++num;
      //              list2.Add(fbItemsData);
      //            }
      //          }
      //          else
      //          {
      //            ParameterExpression parameterExpression1;
      //            ParameterExpression parameterExpression2;
      //            // ISSUE: method reference
      //            // ISSUE: field reference
      //            // ISSUE: method reference
      //            // ISSUE: method reference
      //            // ISSUE: field reference
      //            // ISSUE: method reference
      //            // ISSUE: method reference
      //            List<DateTime> list7 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClassd.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClassd), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClassd.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_ItemEvent_intid))))), new ParameterExpression[1]
      //            {
      //              parameterExpression1
      //            })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //            {
      //              parameterExpression2
      //            })));
      //            if (list5.Count > 0)
      //            {
      //              // ISSUE: reference to a compiler-generated field
      //              if (!list6.Contains(cDisplayClassd.val.get_Item_intid()))
      //              {
      //                fb_Items_Data fbItemsData = new fb_Items_Data();
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_EventID(cDisplayClassd.val.get_ItemEvent_intid());
      //                fbItemsData.set_BatchName(batchItems.Count > 0 ? "Yes" : "No");
      //                fbItemsData.set_ProductionFrom(list7.Count > 1 ? "Multiple" : (list7.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list7).ToString("MM/dd/yyyy")));
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ProductionFrom(fbItemsData.get_ProductionFrom() + (object) "~" + (string) (object) cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                fbItemsData.set_ContractID(str1);
      //                fbItemsData.set_EventDate(str2);
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_IsSubItem(cDisplayClassd.val.get_IsSubItem());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_Quantity(cDisplayClassd.val.get_Quantity());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ID(cDisplayClassd.val.get_ID());
      //                if (EventId == 0)
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                else
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                if (fbItemsData.get_TeamLead() != null)
      //                  ++num;
      //                list2.Add(fbItemsData);
      //              }
      //              else
      //              {
      //                fb_Items_Data fbItemsData = new fb_Items_Data();
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_EventID(cDisplayClassd.val.get_ItemEvent_intid());
      //                fbItemsData.set_ProductionFrom(list7.Count > 1 ? "Multiple" : (list7.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list7).ToString("MM/dd/yyyy")));
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ProductionFrom(fbItemsData.get_ProductionFrom() + (object) "~" + (string) (object) cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //                fbItemsData.set_BatchName(batchItems.Count > 0 ? "Yes" : "No");
      //                fbItemsData.set_ContractID(str1);
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_IsSubItem(cDisplayClassd.val.get_IsSubItem());
      //                fbItemsData.set_EventDate(str2);
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_Quantity(cDisplayClassd.val.get_Quantity());
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_ID(cDisplayClassd.val.get_ID());
      //                if (EventId == 0)
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                else
      //                {
      //                  // ISSUE: reference to a compiler-generated field
      //                  fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //                }
      //                if (fbItemsData.get_TeamLead() != null)
      //                  ++num;
      //                list2.Add(fbItemsData);
      //              }
      //            }
      //            else
      //            {
      //              fb_Items_Data fbItemsData = new fb_Items_Data();
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ItemId(cDisplayClassd.val.get_Item_intid());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ItemName(cDisplayClassd.val.get_ItemName());
      //              fbItemsData.set_ContractID(str1);
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_IsSubItem(cDisplayClassd.val.get_IsSubItem());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_EventID(cDisplayClassd.val.get_ItemEvent_intid());
      //              fbItemsData.set_BatchName(batchItems.Count > 0 ? "Yes" : "No");
      //              fbItemsData.set_EventDate(str2);
      //              fbItemsData.set_ProductionFrom(list7.Count > 1 ? "Multiple" : (list7.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list7).ToString("MM/dd/yyyy")));
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ProductionFrom(fbItemsData.get_ProductionFrom() + (object) "~" + (string) (object) cDisplayClassd.val.get_Item_intid());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_Quantity(cDisplayClassd.val.get_Quantity());
      //              // ISSUE: reference to a compiler-generated field
      //              fbItemsData.set_ID(cDisplayClassd.val.get_ID());
      //              if (EventId == 0)
      //              {
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //              }
      //              else
      //              {
      //                // ISSUE: reference to a compiler-generated field
      //                fbItemsData.set_TeamLead(assignItemService.GetItemTLName(cDisplayClassd.val.get_Item_intid(), fbItemsData.get_EventID()));
      //              }
      //              if (fbItemsData.get_TeamLead() != null)
      //                ++num;
      //              list2.Add(fbItemsData);
      //            }
      //          }
      //        }
      //      }
      //    }
      //    IQueryable<fb_Items_Data> source = Queryable.AsQueryable<fb_Items_Data>((IEnumerable<fb_Items_Data>) list2);
      //    // ISSUE: reference to a compiler-generated field
      //    if (!string.IsNullOrEmpty(cDisplayClass8.ItemName))
      //    {
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: field reference
      //      // ISSUE: method reference
      //      source = Queryable.Where<fb_Items_Data>(source, Expression.Lambda<Func<fb_Items_Data, bool>>((Expression) Expression.Call((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items_Data.get_ItemName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.ToLower)), new Expression[0]), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.Contains)), new Expression[1]
      //      {
      //        (Expression) Expression.Call((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass8), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass8.ItemName))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (string.ToLower)), new Expression[0])
      //      }), new ParameterExpression[1]
      //      {
      //        parameterExpression
      //      }));
      //    }
      //    JqGridResponse jqGridResponse = JqGridHelper.createJQGridResponse(Queryable.Count<fb_Items_Data>(source), request);
      //    string.Format("{0} {1}", (object) request.get_SortingName(), (object) request.get_SortingOrder());
      //    int count = request.get_PageIndex() * request.get_RecordsCount();
      //    int recordsCount = request.get_RecordsCount();
      //    jqGridResponse.get_Records().AddRange((IEnumerable<JqGridRecord>) Enumerable.Select<fb_Items_Data, JqGridRecord<fb_Items_View>>((IEnumerable<fb_Items_Data>) Enumerable.ToList<fb_Items_Data>((IEnumerable<fb_Items_Data>) Queryable.Take<fb_Items_Data>(Queryable.Skip<fb_Items_Data>(source, count), recordsCount)), (Func<fb_Items_Data, JqGridRecord<fb_Items_View>>) (p => new JqGridRecord<fb_Items_View>(Convert.ToString(p.get_ID()), MappedExtensions.ToModel(p)))));
      //    JqGridJsonResult jqGridJsonResult = new JqGridJsonResult();
      //    ((JsonResult) jqGridJsonResult).Data = (object) jqGridResponse;
      //    return (ActionResult) jqGridJsonResult;
      //  }
      //  catch (Exception ex)
      //  {
      //    this._loggerService.Error(ex);
      //    return (ActionResult) this.RedirectToAction("Index");
      //  }
      //}

        return null;
    }

    public string GetAssignitemscount(ItemModel itemModel)
    {
      //cbord_testEntities cbordTestEntities = new cbord_testEntities();
      //ItemsService itemsService = new ItemsService();
      //List<fb_Items_Data> list = new List<fb_Items_Data>();
      //AssignItemService assignItemService = new AssignItemService();
      //int num1 = 0;
      //int num2;
      //if (itemModel.ItemList.Count > 0)
      //{
      //  num2 = itemModel.ItemList.Count;
      //  foreach (CheckItem checkItem in itemModel.ItemList)
      //  {
      //    // ISSUE: object of a compiler-generated type is created
      //    // ISSUE: variable of a compiler-generated type
      //    ItemController.\u003C\u003Ec__DisplayClass11 cDisplayClass11 = new ItemController.\u003C\u003Ec__DisplayClass11();
      //    // ISSUE: reference to a compiler-generated field
      //    cDisplayClass11.val = checkItem;
      //    ParameterExpression parameterExpression;
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    // ISSUE: method reference
      //    if (Queryable.Count<AssignItem>(Queryable.Where<AssignItem>(((BusinessServiceBase<AssignItem>) assignItemService).FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass11.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_Key)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass11), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass11.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))))), new ParameterExpression[1]
      //    {
      //      parameterExpression
      //    }))) > 0)
      //      ++num1;
      //  }
      //}
      //else
      //{
      //  num2 = 0;
      //  num1 = 0;
      //}
      //return (string) (object) num2 + (object) "_" + (string) (object) num1;

        return "";
    }

    public JsonResult CheckforItemTeammebers(ItemModel itemModel)
    {
      string str = "success";
    //  List<int> list1 = new List<int>();
    //  List<int> list2 = new List<int>();
    //  if (itemModel.ItemList.Count > 0)
    //  {
    //    foreach (CheckItem checkItem in itemModel.ItemList)
    //    {
    //      // ISSUE: object of a compiler-generated type is created
    //      // ISSUE: variable of a compiler-generated type
    //      ItemController.\u003C\u003Ec__DisplayClass15 cDisplayClass15 = new ItemController.\u003C\u003Ec__DisplayClass15();
    //      // ISSUE: reference to a compiler-generated field
    //      cDisplayClass15.items = checkItem;
    //      AssignItemService assignItemService = new AssignItemService();
    //      ParameterExpression parameterExpression;
    //      // ISSUE: method reference
    //      // ISSUE: field reference
    //      // ISSUE: method reference
    //      // ISSUE: method reference
    //      // ISSUE: field reference
    //      // ISSUE: method reference
    //      AssignItem assignItem = Queryable.FirstOrDefault<AssignItem>(Queryable.Where<AssignItem>(((BusinessServiceBase<AssignItem>) assignItemService).FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass15), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass15.items))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_Key)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass15), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass15.items))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))))), new ParameterExpression[1]
    //      {
    //        parameterExpression
    //      })));
    //      if (assignItem != null)
    //      {
    //        List<int> list3 = Enumerable.ToList<int>(Enumerable.Select<fb_Teams_Data, int>((IEnumerable<fb_Teams_Data>) assignItemService.GetTeammberonItems(assignItem.get_ItemId(), assignItem.get_EventId()), (Func<fb_Teams_Data, int>) (x => x.get_TeamMemberId())));
    //        if (list3.Count > 0)
    //        {
    //          if (list1.Count > 0)
    //          {
    //            foreach (int num in list1)
    //            {
    //              if (list3.IndexOf(num) < 0)
    //              {
    //                str = "Fail";
    //                break;
    //              }
    //            }
    //            foreach (int num in list3)
    //            {
    //              if (list1.IndexOf(num) < 0)
    //              {
    //                str = "Fail";
    //                break;
    //              }
    //            }
    //          }
    //          foreach (int num in list3)
    //            list1.Add(num);
    //        }
    //      }
    //    }
    //  }
    //  return this.Json((object) new
    //  {
    //    status = str,
    //    message = "Selected items are assigned to multiple TeamMembers, Do you want to continue?"
    //  });
    //}

    //public ActionResult AssignItem(ItemModel itemModel)
    //{
    //  this.Session["ItemName"] = (object) itemModel.ItemName;
    //  this.Session["Contract"] = (object) itemModel.EventName;
    //  this.Session["FromDate"] = (object) itemModel.ProductionFrom;
    //  this.Session["ToDate"] = (object) itemModel.ProductionTo;
    //  this.Session["EventDate"] = (object) itemModel.EventDate;
    //  this.Session["EventEndDate"] = (object) itemModel.EventEndDate;
    //  using (new TeamService())
    //  {
    //    itemModel.SubItemsList = this.BindSubItems(itemModel);
    //    AssignItemService assignItemService = new AssignItemService();
    //    List<fb_Items_View> list = new List<fb_Items_View>();
    //    List<string> productionDatesList = new List<string>();
    //    List<TeamMember> memberList = new List<TeamMember>();
    //    if (!itemModel.IsEdit)
    //    {
    //      foreach (CheckItem checkItem in itemModel.ItemList)
    //      {
    //        List<fb_Items_Data> assignItemsList = assignItemService.GetAssignItemsList(checkItem.Key, checkItem.EventId);
    //        if (assignItemsList != null && assignItemsList.Count > 0)
    //        {
    //          using (List<fb_Items_Data>.Enumerator enumerator1 = assignItemsList.GetEnumerator())
    //          {
    //            while (enumerator1.MoveNext())
    //            {
    //              fb_Items_Data current1 = enumerator1.Current;
    //              current1.set_ItemName(checkItem.Value);
    //              list.Add(MappedExtensions.ToModel(current1));
    //              using (List<fb_ProductionDates>.Enumerator enumerator2 = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) new ProductionDateService().GetAllProductionDatesByItemId(checkItem.Key, checkItem.EventId)).GetEnumerator())
    //              {
    //                while (enumerator2.MoveNext())
    //                {
    //                  fb_ProductionDates current2 = enumerator2.Current;
    //                  if (productionDatesList.IndexOf(current2.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy")) < 0)
    //                    productionDatesList.Add(current2.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy"));
    //                }
    //              }
    //              using (List<fb_AssignedTeam>.Enumerator enumerator2 = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) new AssignedTeamService().GetAssignedMembers(checkItem.Key, checkItem.EventId)).GetEnumerator())
    //              {
    //                while (enumerator2.MoveNext())
    //                {
    //                  fb_AssignedTeam iMember = enumerator2.Current;
    //                  if (Enumerable.Count<TeamMember>(Enumerable.Where<TeamMember>((IEnumerable<TeamMember>) memberList, (Func<TeamMember, bool>) (x => x.MemberId.Equals((object) iMember.get_MemberID())))) <= 0)
    //                  {
    //                    fb_Users byId = new UserService().FindByID(iMember.get_MemberID().Value);
    //                    memberList.Add(new TeamMember()
    //                    {
    //                      LeadId = iMember.get_LeadID().Value,
    //                      MemberId = iMember.get_MemberID().Value,
    //                      TeamId = iMember.get_TeamID().Value,
    //                      MemberName = byId.get_FirstName() + " " + byId.get_LastName()
    //                    });
    //                  }
    //                }
    //              }
    //            }
    //          }
    //        }
    //      }
    //      if (itemModel.SubItemsList != null && itemModel.SubItemsList.Count > 0)
    //      {
    //        foreach (SubItemsList subItemsList in itemModel.SubItemsList)
    //        {
    //          List<fb_Items_Data> assignItemsList = assignItemService.GetAssignItemsList(subItemsList.SubItemId, subItemsList.EventId);
    //          if (assignItemsList != null && assignItemsList.Count > 0)
    //          {
    //            using (List<fb_Items_Data>.Enumerator enumerator1 = assignItemsList.GetEnumerator())
    //            {
    //              while (enumerator1.MoveNext())
    //              {
    //                fb_Items_Data current1 = enumerator1.Current;
    //                current1.set_ItemName(subItemsList.SubItemName);
    //                list.Add(MappedExtensions.ToModel(current1));
    //                using (List<fb_ProductionDates>.Enumerator enumerator2 = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) new ProductionDateService().GetAllProductionDatesByItemId(subItemsList.SubItemId, subItemsList.EventId)).GetEnumerator())
    //                {
    //                  while (enumerator2.MoveNext())
    //                  {
    //                    fb_ProductionDates current2 = enumerator2.Current;
    //                    if (productionDatesList.IndexOf(current2.get_ProdcutionDate().ToString()) < 0)
    //                      productionDatesList.Add(current2.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy"));
    //                  }
    //                }
    //                using (List<fb_AssignedTeam>.Enumerator enumerator2 = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) new AssignedTeamService().GetAssignedMembers(subItemsList.SubItemId, subItemsList.EventId)).GetEnumerator())
    //                {
    //                  while (enumerator2.MoveNext())
    //                  {
    //                    fb_AssignedTeam iMember = enumerator2.Current;
    //                    if (Enumerable.Count<TeamMember>(Enumerable.Where<TeamMember>((IEnumerable<TeamMember>) memberList, (Func<TeamMember, bool>) (x => x.MemberId.Equals((object) iMember.get_MemberID())))) <= 0)
    //                    {
    //                      fb_Users byId = new UserService().FindByID(iMember.get_MemberID().Value);
    //                      memberList.Add(new TeamMember()
    //                      {
    //                        LeadId = iMember.get_LeadID().Value,
    //                        MemberId = iMember.get_MemberID().Value,
    //                        TeamId = iMember.get_TeamID().Value,
    //                        MemberName = byId.get_FirstName() + " " + byId.get_LastName()
    //                      });
    //                    }
    //                  }
    //                }
    //              }
    //            }
    //          }
    //        }
    //      }
    //    }
    //    else
    //    {
    //      foreach (CheckItem checkItem in itemModel.ItemList)
    //      {
    //        CheckItem item = checkItem;
    //        List<fb_Items_Data> assignItemsList = assignItemService.GetAssignItemsList(item.Key, item.EventId);
    //        if (assignItemsList != null && assignItemsList.Count > 0)
    //        {
    //          using (List<fb_Items_Data>.Enumerator enumerator = assignItemsList.GetEnumerator())
    //          {
    //            while (enumerator.MoveNext())
    //            {
    //              fb_Items_Data current = enumerator.Current;
    //              current.set_ItemName(item.Value);
    //              list.Add(MappedExtensions.ToModel(current));
    //            }
    //          }
    //          foreach (EditItemList editItemList in Enumerable.ToList<EditItemList>(Enumerable.Where<EditItemList>((IEnumerable<EditItemList>) itemModel.EditItemList, (Func<EditItemList, bool>) (x =>
    //          {
    //            if (x.Key == item.Key)
    //              return x.EventId == item.EventId;
    //            return false;
    //          }))))
    //          {
    //            ItemController.GetAssignedData(productionDatesList, memberList, item.Key, item.EventId);
    //            item.IsEdit = true;
    //          }
    //        }
    //      }
    //      foreach (SubItemsList subItemsList in itemModel.SubItemsList)
    //      {
    //        SubItemsList subitem = subItemsList;
    //        List<fb_Items_Data> assignItemsList = assignItemService.GetAssignItemsList(subitem.SubItemId, subitem.EventId);
    //        if (assignItemsList != null && assignItemsList.Count > 0)
    //        {
    //          using (List<fb_Items_Data>.Enumerator enumerator = assignItemsList.GetEnumerator())
    //          {
    //            while (enumerator.MoveNext())
    //            {
    //              fb_Items_Data current = enumerator.Current;
    //              current.set_ItemName(subitem.SubItemName);
    //              list.Add(MappedExtensions.ToModel(current));
    //            }
    //          }
    //          foreach (EditItemList editItemList in Enumerable.ToList<EditItemList>(Enumerable.Where<EditItemList>((IEnumerable<EditItemList>) itemModel.EditItemList, (Func<EditItemList, bool>) (x => x.Key == subitem.SubItemId))))
    //          {
    //            ItemController.GetAssignedData(productionDatesList, memberList, subitem.SubItemId, subitem.EventId);
    //            subitem.IsEdit = true;
    //          }
    //        }
    //      }
    //    }
    //    itemModel.AssignedItemsList = list;
    //    itemModel.ProductionDates = productionDatesList;
    //    itemModel.TeamMemberList = memberList;
    //  }
      //return (ActionResult) this.View((object) itemModel);

        return null;
    }

    private static void GetAssignedData(List<string> productionDatesList, List<TeamMember> memberList, int itemId, int eventId)
    {
      //using (List<fb_ProductionDates>.Enumerator enumerator = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) new ProductionDateService().GetAllProductionDatesByItemId(itemId, eventId)).GetEnumerator())
      //{
      //  while (enumerator.MoveNext())
      //  {
      //    fb_ProductionDates current = enumerator.Current;
      //    if (productionDatesList.IndexOf(current.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy")) < 0)
      //      productionDatesList.Add(current.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy"));
      //  }
      //}
      //using (List<fb_AssignedTeam>.Enumerator enumerator = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) new AssignedTeamService().GetAssignedMembers(itemId, eventId)).GetEnumerator())
      //{
      //  while (enumerator.MoveNext())
      //  {
      //    fb_AssignedTeam iMember = enumerator.Current;
      //    if (Enumerable.Count<TeamMember>(Enumerable.Where<TeamMember>((IEnumerable<TeamMember>) memberList, (Func<TeamMember, bool>) (x => x.MemberId.Equals((object) iMember.get_MemberID())))) <= 0)
      //    {
      //      fb_Users byId = new UserService().FindByID(iMember.get_MemberID().Value);
      //      memberList.Add(new TeamMember()
      //      {
      //        LeadId = iMember.get_LeadID().Value,
      //        MemberId = iMember.get_MemberID().Value,
      //        TeamId = iMember.get_TeamID().Value,
      //        MemberName = byId.get_FirstName() + " " + byId.get_LastName()
      //      });
      //    }
      //  }
      //}
    }

    public ActionResult AssignItemByBatch(ItemModel itemModel)
    {
      this.Session["ItemName"] = (object) itemModel.ItemName;
      this.Session["Contract"] = (object) itemModel.EventName;
      this.Session["FromDate"] = (object) itemModel.ProductionFrom;
      this.Session["ToDate"] = (object) itemModel.ProductionTo;
      this.Session["EventDate"] = (object) itemModel.EventDate;
      this.Session["EventEndDate"] = (object) itemModel.EventEndDate;
      //using (TeamService teamService = new TeamService())
      //{
      //  IQueryable<fb_Teams> all = ((BusinessServiceBase<fb_Teams>) teamService).FindAll();
      //  itemModel.Teamlist = Enumerable.ToList<KeyValuePair<int, string>>(Enumerable.Select<fb_Teams, KeyValuePair<int, string>>((IEnumerable<fb_Teams>) Enumerable.ToList<fb_Teams>((IEnumerable<fb_Teams>) all), (Func<fb_Teams, KeyValuePair<int, string>>) (t => new KeyValuePair<int, string>(t.get_TeamId(), t.get_TeamName()))));
      //  itemModel.SubItemsList = this.BindSubItems(itemModel);
      //  AssignItemService assignItemService = new AssignItemService();
      //  List<fb_Items_View> list1 = new List<fb_Items_View>();
      //  List<string> list2 = new List<string>();
      //  List<TeamMember> list3 = new List<TeamMember>();
      //  foreach (CheckItem checkItem in itemModel.ItemList)
      //  {
      //    List<fb_Items_Data> assignItemsList = assignItemService.GetAssignItemsList(checkItem.Key, checkItem.EventId);
      //    if (assignItemsList != null && assignItemsList.Count > 0 && checkItem.BatchName != " Not yet Batched")
      //    {
      //      using (List<fb_Items_Data>.Enumerator enumerator1 = assignItemsList.GetEnumerator())
      //      {
      //        while (enumerator1.MoveNext())
      //        {
      //          fb_Items_Data current1 = enumerator1.Current;
      //          current1.set_ItemName(checkItem.Value);
      //          list1.Add(MappedExtensions.ToModel(current1));
      //          using (List<fb_ProductionDates>.Enumerator enumerator2 = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) new ProductionDateService().GetAllProductionDatesByItemId(checkItem.Key, checkItem.EventId)).GetEnumerator())
      //          {
      //            while (enumerator2.MoveNext())
      //            {
      //              fb_ProductionDates current2 = enumerator2.Current;
      //              if (list2.IndexOf(current2.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy")) < 0)
      //                list2.Add(current2.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy"));
      //            }
      //          }
      //          using (List<fb_AssignedTeam>.Enumerator enumerator2 = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) new AssignedTeamService().GetAssignedMembers(checkItem.Key, checkItem.EventId)).GetEnumerator())
      //          {
      //            while (enumerator2.MoveNext())
      //            {
      //              fb_AssignedTeam iMember = enumerator2.Current;
      //              if (Enumerable.Count<TeamMember>(Enumerable.Where<TeamMember>((IEnumerable<TeamMember>) list3, (Func<TeamMember, bool>) (x => x.MemberId.Equals((object) iMember.get_MemberID())))) <= 0)
      //              {
      //                fb_Users byId = new UserService().FindByID(iMember.get_MemberID().Value);
      //                list3.Add(new TeamMember()
      //                {
      //                  LeadId = iMember.get_LeadID().Value,
      //                  MemberId = iMember.get_MemberID().Value,
      //                  TeamId = iMember.get_TeamID().Value,
      //                  MemberName = byId.get_FirstName() + " " + byId.get_LastName()
      //                });
      //              }
      //            }
      //          }
      //        }
      //      }
      //    }
      //  }
      //  if (itemModel.SubItemsList != null && itemModel.SubItemsList.Count > 0)
      //  {
      //    foreach (SubItemsList subItemsList in itemModel.SubItemsList)
      //    {
      //      List<fb_Items_Data> assignItemsList = assignItemService.GetAssignItemsList(subItemsList.SubItemId, subItemsList.EventId);
      //      if (assignItemsList != null && assignItemsList.Count > 0 && subItemsList.BatchName != " Not yet Batched")
      //      {
      //        using (List<fb_Items_Data>.Enumerator enumerator1 = assignItemsList.GetEnumerator())
      //        {
      //          while (enumerator1.MoveNext())
      //          {
      //            fb_Items_Data current1 = enumerator1.Current;
      //            current1.set_ItemName(subItemsList.SubItemName);
      //            list1.Add(MappedExtensions.ToModel(current1));
      //            using (List<fb_ProductionDates>.Enumerator enumerator2 = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) new ProductionDateService().GetAllProductionDatesByItemId(subItemsList.SubItemId, subItemsList.EventId)).GetEnumerator())
      //            {
      //              while (enumerator2.MoveNext())
      //              {
      //                fb_ProductionDates current2 = enumerator2.Current;
      //                if (list2.IndexOf(current2.get_ProdcutionDate().ToString()) < 0)
      //                  list2.Add(current2.get_ProdcutionDate().ToString("MM'/'dd'/'yyyy"));
      //              }
      //            }
      //            using (List<fb_AssignedTeam>.Enumerator enumerator2 = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) new AssignedTeamService().GetAssignedMembers(subItemsList.SubItemId, subItemsList.EventId)).GetEnumerator())
      //            {
      //              while (enumerator2.MoveNext())
      //              {
      //                fb_AssignedTeam iMember = enumerator2.Current;
      //                if (Enumerable.Count<TeamMember>(Enumerable.Where<TeamMember>((IEnumerable<TeamMember>) list3, (Func<TeamMember, bool>) (x => x.MemberId.Equals((object) iMember.get_MemberID())))) <= 0)
      //                {
      //                  fb_Users byId = new UserService().FindByID(iMember.get_MemberID().Value);
      //                  list3.Add(new TeamMember()
      //                  {
      //                    LeadId = iMember.get_LeadID().Value,
      //                    MemberId = iMember.get_MemberID().Value,
      //                    TeamId = iMember.get_TeamID().Value,
      //                    MemberName = byId.get_FirstName() + " " + byId.get_LastName()
      //                  });
      //                }
      //              }
      //            }
      //          }
      //        }
      //      }
      //    }
      //  }
      //  itemModel.AssignedItemsList = list1;
      //  itemModel.ProductionDates = list2;
      //  itemModel.TeamMemberList = list3;
      //}
      return (ActionResult) this.View((object) itemModel);
    }

    public ActionResult UnAssignItem(ItemModel itemModel)
    {
      try
      {
        using (AssignItemService assignItemService = new AssignItemService())
        {
          if (itemModel.ItemList.Count > 0)
          {
            foreach (CheckItem checkItem in itemModel.ItemList)
              assignItemService.DeleteAssignItems(checkItem.Key, itemModel.EventId);
          }
        }
        return (ActionResult) this.Json((object) new
        {
          status = "success",
          message = "Items unassigned successfully."
        });
      }
      catch (Exception ex)
      {
        return (ActionResult) this.Json((object) new
        {
          status = "fail",
          message = ex.Message
        });
      }
    }

    [HttpPost]
    public string GetTeammembersdetails(int TeamId)
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

    public ActionResult SaveItems(ItemModel itemModel)
    {
      //using (AssignItemService assignItemService = new AssignItemService())
      //{
      //  List<AssignItemsList> list1 = new List<AssignItemsList>();
      //  ProductionDateService pds = new ProductionDateService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //  try
      //  {
      //    if (itemModel.ItemList != null && itemModel.ItemList.Count > 0)
      //    {
      //      foreach (CheckItem checkItem in itemModel.ItemList)
      //      {
      //        // ISSUE: object of a compiler-generated type is created
      //        // ISSUE: variable of a compiler-generated type
      //        ItemController.\u003C\u003Ec__DisplayClass3c cDisplayClass3c = new ItemController.\u003C\u003Ec__DisplayClass3c();
      //        // ISSUE: reference to a compiler-generated field
      //        cDisplayClass3c.val = checkItem;
      //        AssignItemModel model = new AssignItemModel();
      //        ParameterExpression parameterExpression1;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        AssignItem assignItem = Queryable.FirstOrDefault<AssignItem>(Queryable.Where<AssignItem>(((BusinessServiceBase<AssignItem>) assignItemService).FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3c.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_Key)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3c.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression1
      //        })));
      //        // ISSUE: reference to a compiler-generated field
      //        model.ItemId = cDisplayClass3c.val.Key;
      //        // ISSUE: reference to a compiler-generated field
      //        model.EventId = cDisplayClass3c.val.EventId;
      //        if (assignItem != null)
      //        {
      //          model.Id = assignItem.get_Id();
      //          ((BusinessServiceBase<AssignItem>) new AssignItemService()).Update(MappedExtensions.ToEntity(model), true);
      //        }
      //        else
      //          model = MappedExtensions.ToModel(((BusinessServiceBase<AssignItem>) assignItemService).Add(MappedExtensions.ToEntity(model), true));
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        ItemController.AddProductionDates(itemModel, pds, cDisplayClass3c.val.Key, cDisplayClass3c.val.EventId, model.Id);
      //        this.AssignTeamMembers(itemModel, model.Id);
      //        EventsService eventsService = new EventsService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        ProductionDateService productionDateService = new ProductionDateService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        UserService userService = new UserService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        ParameterExpression parameterExpression2;
      //        ParameterExpression parameterExpression3;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        List<DateTime> list2 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3c.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_Key)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3c.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression2
      //        })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //        {
      //          parameterExpression3
      //        })));
      //        ParameterExpression parameterExpression4;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        string contract = Queryable.FirstOrDefault<fb_Events>(Queryable.Where<fb_Events>(((BusinessServiceBase<fb_Events>) eventsService).FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3c), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3c.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))), typeof (int?))), new ParameterExpression[1]
      //        {
      //          parameterExpression4
      //        }))).get_Contract();
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        list1.Add(new AssignItemsList()
      //        {
      //          Id = model.Id,
      //          Contract = contract,
      //          EventId = cDisplayClass3c.val.EventId,
      //          ItemId = cDisplayClass3c.val.Key,
      //          ItemName = cDisplayClass3c.val.Value.Trim(),
      //          ProductionDate = list2.Count > 1 ? "Multiple" : (list2.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list2).ToString("MM/dd/yyyy")),
      //          TeamMembers = string.Empty
      //        });
      //      }
      //    }
      //    if (itemModel.SubItemsList != null && itemModel.SubItemsList.Count > 0)
      //    {
      //      foreach (SubItemsList subItemsList in itemModel.SubItemsList)
      //      {
      //        // ISSUE: object of a compiler-generated type is created
      //        // ISSUE: variable of a compiler-generated type
      //        ItemController.\u003C\u003Ec__DisplayClass3e cDisplayClass3e = new ItemController.\u003C\u003Ec__DisplayClass3e();
      //        // ISSUE: reference to a compiler-generated field
      //        cDisplayClass3e.val = subItemsList;
      //        AssignItemModel model = new AssignItemModel();
      //        ParameterExpression parameterExpression1;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        AssignItem assignItem = Queryable.FirstOrDefault<AssignItem>(Queryable.Where<AssignItem>(((BusinessServiceBase<AssignItem>) assignItemService).FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3e.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_SubItemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3e.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression1
      //        })));
      //        // ISSUE: reference to a compiler-generated field
      //        model.ItemId = cDisplayClass3e.val.SubItemId;
      //        // ISSUE: reference to a compiler-generated field
      //        model.EventId = cDisplayClass3e.val.EventId;
      //        if (assignItem != null)
      //        {
      //          model.Id = assignItem.get_Id();
      //          ((BusinessServiceBase<AssignItem>) new AssignItemService()).Update(MappedExtensions.ToEntity(model), true);
      //        }
      //        else
      //          model = MappedExtensions.ToModel(((BusinessServiceBase<AssignItem>) assignItemService).Add(MappedExtensions.ToEntity(model), true));
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        ItemController.AddProductionDates(itemModel, pds, cDisplayClass3e.val.SubItemId, cDisplayClass3e.val.EventId, model.Id);
      //        this.AssignTeamMembers(itemModel, model.Id);
      //        EventsService eventsService = new EventsService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        ProductionDateService productionDateService = new ProductionDateService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        UserService userService = new UserService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        ParameterExpression parameterExpression2;
      //        ParameterExpression parameterExpression3;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        List<DateTime> list2 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3e.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_SubItemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3e.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression2
      //        })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //        {
      //          parameterExpression3
      //        })));
      //        ParameterExpression parameterExpression4;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        string contract = Queryable.FirstOrDefault<fb_Events>(Queryable.Where<fb_Events>(((BusinessServiceBase<fb_Events>) eventsService).FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass3e), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass3e.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_EventId))), typeof (int?))), new ParameterExpression[1]
      //        {
      //          parameterExpression4
      //        }))).get_Contract();
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        list1.Add(new AssignItemsList()
      //        {
      //          Id = model.Id,
      //          Contract = contract,
      //          EventId = cDisplayClass3e.val.EventId,
      //          ItemId = cDisplayClass3e.val.SubItemId,
      //          ItemName = cDisplayClass3e.val.SubItemName.Trim(),
      //          ProductionDate = list2.Count > 1 ? "Multiple" : (list2.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list2).ToString("MM/dd/yyyy")),
      //          TeamMembers = string.Empty
      //        });
      //      }
      //    }
      //    return (ActionResult) this.Json((object) new
      //    {
      //      result = "Success",
      //      AssignItemsList = list1
      //    }, JsonRequestBehavior.AllowGet);
      //  }
      //  catch (Exception ex)
      //  {
      //    this._loggerService.Error(ex);
      //    return (ActionResult) this.Json((object) new
      //    {
      //      result = "Fail"
      //    }, JsonRequestBehavior.AllowGet);
      //  }
      //}

        return null;
    }

    private static void AddProductionDates(ItemModel itemModel, ProductionDateService pds, int itemId, int eventId, int AssignItemID)
    {
      //if (itemModel.ProductionDates == null || itemModel.ProductionDates.Count <= 0)
      //  return;
      //List<fb_ProductionDates> list = Enumerable.ToList<fb_ProductionDates>((IEnumerable<fb_ProductionDates>) pds.GetAllProductionDatesByItemId(itemId, eventId));
      //if (list.Count > 0 && list != null)
      //{
      //  using (List<fb_ProductionDates>.Enumerator enumerator = list.GetEnumerator())
      //  {
      //    while (enumerator.MoveNext())
      //    {
      //      fb_ProductionDates current = enumerator.Current;
      //      ((BusinessServiceBase<fb_ProductionDates>) pds).Delete(current, true);
      //    }
      //  }
      //}
      //foreach (string s in itemModel.ProductionDates)
      //  ((BusinessServiceBase<fb_ProductionDates>) pds).Add(MappedExtensions.ToEntity(new ProductionDatesModel()
      //  {
      //    ItemId = itemId,
      //    EventId = eventId,
      //    AssignItemID = AssignItemID,
      //    ProdcutionDate = DateTime.ParseExact(s, "MM/dd/yyyy", (IFormatProvider) CultureInfo.InvariantCulture)
      //  }), true);
    }

    private void AssignTeamMembers(ItemModel itemModel, int AssignItemID)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //ItemController.\u003C\u003Ec__DisplayClass40 cDisplayClass40 = new ItemController.\u003C\u003Ec__DisplayClass40();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass40.AssignItemID = AssignItemID;
      //AssignedTeamService assignedTeamService1 = new AssignedTeamService();
      //ParameterExpression parameterExpression;
      //// ISSUE: method reference
      //// ISSUE: method reference
      //// ISSUE: field reference
      //List<fb_AssignedTeam> list = Enumerable.ToList<fb_AssignedTeam>((IEnumerable<fb_AssignedTeam>) Queryable.Where<fb_AssignedTeam>(((BusinessServiceBase<fb_AssignedTeam>) assignedTeamService1).FindAll(), Expression.Lambda<Func<fb_AssignedTeam, bool>>((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_AssignedTeam.get_AssignItemID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
      //{
      //  (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass40), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass40.AssignItemID)))
      //}), new ParameterExpression[1]
      //{
      //  parameterExpression
      //})));
      //if (list.Count > 0 && list != null)
      //{
      //  using (List<fb_AssignedTeam>.Enumerator enumerator = list.GetEnumerator())
      //  {
      //    while (enumerator.MoveNext())
      //    {
      //      fb_AssignedTeam current = enumerator.Current;
      //      ((BusinessServiceBase<fb_AssignedTeam>) assignedTeamService1).Delete(current, true);
      //    }
      //  }
      //}
      //if (itemModel.TeamMemberList == null)
      //  return;
      //foreach (TeamMember teamMember in itemModel.TeamMemberList)
      //{
      //  AssignedTeamModel model = new AssignedTeamModel();
      //  using (AssignedTeamService assignedTeamService2 = new AssignedTeamService())
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    model.AssignItemID = cDisplayClass40.AssignItemID;
      //    model.MemberID = teamMember.MemberId;
      //    model.LeadID = teamMember.LeadId;
      //    model.TeamID = teamMember.TeamId;
      //    // ISSUE: reference to a compiler-generated field
      //    if (!assignedTeamService2.CheckDuplicateMember(cDisplayClass40.AssignItemID, teamMember.MemberId, teamMember.LeadId, teamMember.TeamId))
      //      MappedExtensions.ToModel(((BusinessServiceBase<fb_AssignedTeam>) assignedTeamService2).Add(MappedExtensions.ToEntity(model), true));
      //  }
      //}
    }

    [HttpPost]
    public string GetTeammberonItems(int ItemId, int EventId)
    {
      try
      {
        using (AssignItemService assignItemService = new AssignItemService())
          return JsonConvert.SerializeObject((object) assignItemService.GetTeammberonItems(ItemId, EventId));
      }
      catch (Exception ex)
      {
        this._loggerService.Error(ex);
      }
      return (string) null;
    }

    public List<SubItemsList> BindSubItems(ItemModel itemModel)
    {
      List<SubItemsList> list1 = new List<SubItemsList>();
      ItemsService itemsService = new ItemsService();
      BatchItemService batchItemService = new BatchItemService();
      AssignItemService assignItemService = new AssignItemService();
      EventsService eventsService = new EventsService();
      //foreach (CheckItem checkItem in itemModel.ItemList)
      //{
      //  // ISSUE: object of a compiler-generated type is created
      //  // ISSUE: variable of a compiler-generated type
      //  ItemController.\u003C\u003Ec__DisplayClass49 cDisplayClass49 = new ItemController.\u003C\u003Ec__DisplayClass49();
      //  // ISSUE: reference to a compiler-generated field
      //  cDisplayClass49.item = checkItem;
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  cDisplayClass49.item.BatchName = batchItemService.GetBatch(cDisplayClass49.item.Key, cDisplayClass49.item.EventId, false);
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  cDisplayClass49.item.BatchColor = batchItemService.GetBatchColor(cDisplayClass49.item.Key, cDisplayClass49.item.EventId, false);
      //  // ISSUE: reference to a compiler-generated field
      //  if (cDisplayClass49.item.BatchName != " Not yet Batched")
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    cDisplayClass49.item.BatchID = Enumerable.FirstOrDefault<fb_Batches>((IEnumerable<fb_Batches>) batchItemService.GetBatchItemDetails(cDisplayClass49.item.Key, cDisplayClass49.item.EventId, false)).get_ID();
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  IEnumerable<int> source1 = Enumerable.Select<AssignItem, int>((IEnumerable<AssignItem>) assignItemService.GetAssignItemsByEventIDItemId(cDisplayClass49.item.Key, cDisplayClass49.item.EventId), (Func<AssignItem, int>) (x => x.get_ItemId()));
      //  if (Enumerable.Count<int>(source1) > 0 && source1 != null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    cDisplayClass49.item.IsPreviouslyAssigned = true;
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  if (!cDisplayClass49.item.Quantity.HasValue)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: reference to a compiler-generated field
      //    cDisplayClass49.item.Quantity = itemsService.GetItemByID(cDisplayClass49.item.Key).get_Quantity();
      //    ParameterExpression parameterExpression;
      //    // ISSUE: reference to a compiler-generated field
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    // ISSUE: method reference
      //    cDisplayClass49.item.ContractId = Enumerable.FirstOrDefault<string>(Enumerable.Select<fb_Events, string>((IEnumerable<fb_Events>) Enumerable.ToList<fb_Events>((IEnumerable<fb_Events>) Queryable.Where<fb_Events>(((BusinessServiceBase<fb_Events>) eventsService).FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass49), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass49.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))), typeof (int?))), new ParameterExpression[1]
      //    {
      //      parameterExpression
      //    }))), (Func<fb_Events, string>) (x => x.get_Contract())));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  using (List<fb_Items>.Enumerator enumerator = itemsService.GetSubItemsByMainItemIdAndEventID((string) (object) cDisplayClass49.item.EventId + (object) "_" + (string) (object) cDisplayClass49.item.Key).GetEnumerator())
      //  {
      //    while (enumerator.MoveNext())
      //    {
      //      // ISSUE: object of a compiler-generated type is created
      //      // ISSUE: variable of a compiler-generated type
      //      ItemController.\u003C\u003Ec__DisplayClass4b cDisplayClass4b = new ItemController.\u003C\u003Ec__DisplayClass4b();
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass4b.CS\u0024\u003C\u003E8__locals4a = cDisplayClass49;
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass4b.subitem = enumerator.Current;
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      IEnumerable<int> source2 = Enumerable.Select<AssignItem, int>((IEnumerable<AssignItem>) assignItemService.GetAssignItemsByEventIDItemId(cDisplayClass4b.subitem.get_Item_intid(), cDisplayClass49.item.EventId), (Func<AssignItem, int>) (x => x.get_ItemId()));
      //      List<SubItemsList> list2 = list1;
      //      SubItemsList subItemsList1 = new SubItemsList();
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.EventId = cDisplayClass49.item.EventId;
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.MainItemId = cDisplayClass49.item.Key;
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.MainItemName = cDisplayClass49.item.Value;
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.SubItemId = cDisplayClass4b.subitem.get_Item_intid();
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.SubItemName = cDisplayClass4b.subitem.get_ItemName();
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.BatchName = batchItemService.GetBatch(cDisplayClass4b.subitem.get_Item_intid(), cDisplayClass49.item.EventId, true);
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      subItemsList1.BatchColor = batchItemService.GetBatchColor(cDisplayClass4b.subitem.get_Item_intid(), cDisplayClass49.item.EventId, true);
      //      SubItemsList subItemsList2 = subItemsList1;
      //      int num;
      //      // ISSUE: reference to a compiler-generated field
      //      // ISSUE: reference to a compiler-generated field
      //      if (!(batchItemService.GetBatch(cDisplayClass4b.subitem.get_Item_intid(), cDisplayClass49.item.EventId, true) == " Not yet Batched"))
      //      {
      //        ParameterExpression parameterExpression;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        num = Enumerable.FirstOrDefault<fb_BatchItems>((IEnumerable<fb_BatchItems>) Enumerable.ToList<fb_BatchItems>((IEnumerable<fb_BatchItems>) Queryable.Where<fb_BatchItems>(((BusinessServiceBase<fb_BatchItems>) batchItemService).FindAll(), Expression.Lambda<Func<fb_BatchItems, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_ItemID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4b), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass4b.subitem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Items.get_Item_intid)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass49), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass49.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression
      //        })))).get_BatchID();
      //      }
      //      else
      //        num = 0;
      //      subItemsList2.BatchId = num;
      //      subItemsList1.IsPreviouslyAssigned = Enumerable.Count<int>(source2) > 0 && source2 != null;
      //      SubItemsList subItemsList3 = subItemsList1;
      //      list2.Add(subItemsList3);
      //    }
      //  }
      //}
      return list1;
    }

    public ActionResult CreateBatch(ItemModel itemModel)
    {
      using (TeamService teamService = new TeamService())
      {
        ((BusinessServiceBase<fb_Teams>) teamService).FindAll();
        itemModel.SubItemsList = this.BindSubItems(itemModel);
      }
      return (ActionResult) this.View((object) itemModel);
    }

    public JsonResult AddBatch(ItemModel itemModel, string BatchName, bool isSubitem)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      //ItemController.\u003C\u003Ec__DisplayClass4d cDisplayClass4d = new ItemController.\u003C\u003Ec__DisplayClass4d();
      //// ISSUE: reference to a compiler-generated field
      //cDisplayClass4d.isSubitem = isSubitem;
      //BatchModel model1 = new BatchModel();
      //using (BatchService batchService = new BatchService())
      //{
      //  Random random = new Random();
      //  KnownColor[] knownColorArray = (KnownColor[]) Enum.GetValues(typeof (KnownColor));
      //  Color color = Color.FromKnownColor(knownColorArray[random.Next(knownColorArray.Length)]);
      //  model1.Color = color.Name;
      //  model1.Name = new ItemsService().GetItemByID(itemModel.ItemList[0].Key).get_ItemName() + " B";
      //  BatchModel batchModel = MappedExtensions.ToModel(((BusinessServiceBase<fb_Batches>) batchService).Add(MappedExtensions.ToEntity(model1), true));
      //  foreach (CheckItem checkItem in itemModel.ItemList)
      //  {
      //    // ISSUE: object of a compiler-generated type is created
      //    // ISSUE: variable of a compiler-generated type
      //    ItemController.\u003C\u003Ec__DisplayClass4f cDisplayClass4f = new ItemController.\u003C\u003Ec__DisplayClass4f();
      //    // ISSUE: reference to a compiler-generated field
      //    cDisplayClass4f.CS\u0024\u003C\u003E8__locals4e = cDisplayClass4d;
      //    // ISSUE: reference to a compiler-generated field
      //    cDisplayClass4f.Item = checkItem;
      //    BatchItemService batchItemService = new BatchItemService();
      //    BatchItemModel model2 = new BatchItemModel();
      //    model2.BatchID = batchModel.ID;
      //    // ISSUE: reference to a compiler-generated field
      //    model2.ItemId = cDisplayClass4f.Item.Key;
      //    // ISSUE: reference to a compiler-generated field
      //    model2.IsSubItem = cDisplayClass4d.isSubitem;
      //    // ISSUE: reference to a compiler-generated field
      //    model2.EventID = cDisplayClass4f.Item.EventId;
      //    ParameterExpression parameterExpression;
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    // ISSUE: method reference
      //    // ISSUE: field reference
      //    fb_BatchItems fbBatchItems = Queryable.FirstOrDefault<fb_BatchItems>(Queryable.Where<fb_BatchItems>(((BusinessServiceBase<fb_BatchItems>) batchItemService).FindAll(), Expression.Lambda<Func<fb_BatchItems, bool>>((Expression) Expression.AndAlso((Expression) Expression.AndAlso((Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_ItemID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
      //    {
      //      (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4f), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass4f.Item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_Key)))
      //    }), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_EventID))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (int.Equals)), new Expression[1]
      //    {
      //      (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4f), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass4f.Item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId)))
      //    })), (Expression) Expression.Call((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_BatchItems.get_IsSubItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (bool.Equals)), new Expression[1]
      //    {
      //      (Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass4d), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass4d.isSubitem)))
      //    })), new ParameterExpression[1]
      //    {
      //      parameterExpression
      //    })));
      //    if (fbBatchItems != null)
      //      ((BusinessServiceBase<fb_BatchItems>) batchItemService).Delete(fbBatchItems, true);
      //    MappedExtensions.ToModel(((BusinessServiceBase<fb_BatchItems>) batchItemService).Add(MappedExtensions.ToEntity(model2), true));
      //  }
      //}
      return this.Json((object) new
      {
        status = true
      });
    }

    [HttpPost]
    public JsonResult DeleteAssignItem(ItemModel itemModel, string Ids)
    {
      //try
      //{
      //  string[] strArray = Ids.Split('~');
      //  AssignItemService assignItemService = new AssignItemService();
      //  assignItemService.DeleteAssignItems(Convert.ToInt32(strArray[1]), Convert.ToInt32(strArray[2]));
      //  List<AssignItemsList> list1 = new List<AssignItemsList>();
      //  if (itemModel.ItemList != null)
      //  {
      //    foreach (CheckItem checkItem in itemModel.ItemList)
      //    {
      //      // ISSUE: object of a compiler-generated type is created
      //      // ISSUE: variable of a compiler-generated type
      //      ItemController.\u003C\u003Ec__DisplayClass53 cDisplayClass53 = new ItemController.\u003C\u003Ec__DisplayClass53();
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass53.val = checkItem;
      //      // ISSUE: object of a compiler-generated type is created
      //      // ISSUE: variable of a compiler-generated type
      //      ItemController.\u003C\u003Ec__DisplayClass55 cDisplayClass55 = new ItemController.\u003C\u003Ec__DisplayClass55();
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass55.CS\u0024\u003C\u003E8__locals54 = cDisplayClass53;
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass55.assignItemModel = new AssignItemModel();
      //      ParameterExpression parameterExpression1;
      //      // ISSUE: method reference
      //      // ISSUE: field reference
      //      // ISSUE: method reference
      //      // ISSUE: method reference
      //      // ISSUE: field reference
      //      // ISSUE: method reference
      //      AssignItemModel assignItemModel = MappedExtensions.ToModel(Queryable.FirstOrDefault<AssignItem>(Queryable.Where<AssignItem>(((BusinessServiceBase<AssignItem>) assignItemService).FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass53), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass53.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_Key)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass53), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass53.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))))), new ParameterExpression[1]
      //      {
      //        parameterExpression1
      //      }))));
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass55.assignItemModel = assignItemModel;
      //      // ISSUE: reference to a compiler-generated field
      //      if (cDisplayClass55.assignItemModel != null)
      //      {
      //        EventsService eventsService = new EventsService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        ProductionDateService productionDateService = new ProductionDateService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        UserService userService = new UserService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //        ParameterExpression parameterExpression2;
      //        ParameterExpression parameterExpression3;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        List<DateTime> list2 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass55), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass55.assignItemModel))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItemModel.get_ItemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass55), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass55.assignItemModel))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItemModel.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression2
      //        })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //        {
      //          parameterExpression3
      //        })));
      //        ParameterExpression parameterExpression4;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        string contract = Queryable.FirstOrDefault<fb_Events>(Queryable.Where<fb_Events>(((BusinessServiceBase<fb_Events>) eventsService).FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass53), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass53.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_EventId))), typeof (int?))), new ParameterExpression[1]
      //        {
      //          parameterExpression4
      //        }))).get_Contract();
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        // ISSUE: reference to a compiler-generated field
      //        list1.Add(new AssignItemsList()
      //        {
      //          Id = cDisplayClass55.assignItemModel.Id,
      //          Contract = contract,
      //          EventId = cDisplayClass53.val.EventId,
      //          ItemId = cDisplayClass53.val.Key,
      //          ItemName = cDisplayClass53.val.Value.Trim(),
      //          ProductionDate = list2.Count > 1 ? "Multiple" : (list2.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list2).ToString("MM/dd/yyyy")),
      //          TeamMembers = string.Empty
      //        });
      //      }
      //    }
      //    if (itemModel.SubItemsList != null)
      //    {
      //      foreach (SubItemsList subItemsList in itemModel.SubItemsList)
      //      {
      //        // ISSUE: object of a compiler-generated type is created
      //        // ISSUE: variable of a compiler-generated type
      //        ItemController.\u003C\u003Ec__DisplayClass57 cDisplayClass57 = new ItemController.\u003C\u003Ec__DisplayClass57();
      //        // ISSUE: reference to a compiler-generated field
      //        cDisplayClass57.val = subItemsList;
      //        // ISSUE: object of a compiler-generated type is created
      //        // ISSUE: variable of a compiler-generated type
      //        ItemController.\u003C\u003Ec__DisplayClass59 cDisplayClass59 = new ItemController.\u003C\u003Ec__DisplayClass59();
      //        // ISSUE: reference to a compiler-generated field
      //        cDisplayClass59.CS\u0024\u003C\u003E8__locals58 = cDisplayClass57;
      //        AssignItemModel assignItemModel = new AssignItemModel();
      //        ParameterExpression parameterExpression1;
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        // ISSUE: method reference
      //        // ISSUE: field reference
      //        // ISSUE: method reference
      //        AssignItem assignItem = Queryable.FirstOrDefault<AssignItem>(Queryable.Where<AssignItem>(((BusinessServiceBase<AssignItem>) assignItemService).FindAll(), Expression.Lambda<Func<AssignItem, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass57), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass57.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_SubItemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass57), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass57.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_EventId))))), new ParameterExpression[1]
      //        {
      //          parameterExpression1
      //        })));
      //        // ISSUE: reference to a compiler-generated field
      //        cDisplayClass59.assignItem = assignItem;
      //        // ISSUE: reference to a compiler-generated field
      //        if (cDisplayClass59.assignItem != null)
      //        {
      //          // ISSUE: reference to a compiler-generated field
      //          assignItemModel.ItemId = cDisplayClass59.assignItem.get_ItemId();
      //          // ISSUE: reference to a compiler-generated field
      //          assignItemModel.EventId = cDisplayClass59.assignItem.get_EventId();
      //          EventsService eventsService = new EventsService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //          ProductionDateService productionDateService = new ProductionDateService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //          UserService userService = new UserService((DbContext) ((BusinessServiceBase<AssignItem>) assignItemService)._dbContext);
      //          ParameterExpression parameterExpression2;
      //          ParameterExpression parameterExpression3;
      //          // ISSUE: method reference
      //          // ISSUE: field reference
      //          // ISSUE: method reference
      //          // ISSUE: method reference
      //          // ISSUE: field reference
      //          // ISSUE: method reference
      //          // ISSUE: method reference
      //          List<DateTime> list2 = Enumerable.ToList<DateTime>((IEnumerable<DateTime>) Queryable.Select<fb_ProductionDates, DateTime>(Queryable.Where<fb_ProductionDates>(((BusinessServiceBase<fb_ProductionDates>) productionDateService).FindAll(), Expression.Lambda<Func<fb_ProductionDates, bool>>((Expression) Expression.AndAlso((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ItemId))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass59), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass59.assignItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_ItemId)))), (Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_EventID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass59), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass59.assignItem))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AssignItem.get_EventId))))), new ParameterExpression[1]
      //          {
      //            parameterExpression2
      //          })), Expression.Lambda<Func<fb_ProductionDates, DateTime>>((Expression) Expression.Property((Expression) parameterExpression3, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_ProductionDates.get_ProdcutionDate))), new ParameterExpression[1]
      //          {
      //            parameterExpression3
      //          })));
      //          ParameterExpression parameterExpression4;
      //          // ISSUE: method reference
      //          // ISSUE: field reference
      //          // ISSUE: method reference
      //          string contract = Queryable.FirstOrDefault<fb_Events>(Queryable.Where<fb_Events>(((BusinessServiceBase<fb_Events>) eventsService).FindAll(), Expression.Lambda<Func<fb_Events, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Events.get_FSSeventlist_intid))), (Expression) Expression.Convert((Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass57), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass57.val))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SubItemsList.get_EventId))), typeof (int?))), new ParameterExpression[1]
      //          {
      //            parameterExpression4
      //          }))).get_Contract();
      //          // ISSUE: reference to a compiler-generated field
      //          // ISSUE: reference to a compiler-generated field
      //          // ISSUE: reference to a compiler-generated field
      //          list1.Add(new AssignItemsList()
      //          {
      //            Id = assignItemModel.Id,
      //            Contract = contract,
      //            EventId = cDisplayClass57.val.EventId,
      //            ItemId = cDisplayClass57.val.SubItemId,
      //            ItemName = cDisplayClass57.val.SubItemName.Trim(),
      //            ProductionDate = list2.Count > 1 ? "Multiple" : (list2.Count == 0 ? "NA" : Enumerable.FirstOrDefault<DateTime>((IEnumerable<DateTime>) list2).ToString("MM/dd/yyyy")),
      //            TeamMembers = string.Empty
      //          });
      //        }
      //      }
      //    }
      //  }
      //  return this.Json((object) new
      //  {
      //    result = "Success",
      //    AssignItemsList = list1
      //  }, JsonRequestBehavior.AllowGet);
      //}
      //catch (Exception ex)
      //{
      //  this._loggerService.Error(ex);
      //  return this.Json((object) new
      //  {
      //    result = "Fail"
      //  });
      //}
        return null;
    }

    public ActionResult AddTeamMembers()
    {
      IQueryable<fb_Teams> all = ((BusinessServiceBase<fb_Teams>) new TeamService()).FindAll();
      return (ActionResult) this.View((object) new ItemModel()
      {
        //Teamlist = Enumerable.ToList<KeyValuePair<int, string>>(Enumerable.Select<fb_Teams, KeyValuePair<int, string>>((IEnumerable<fb_Teams>) Enumerable.ToList<fb_Teams>((IEnumerable<fb_Teams>) all), (Func<fb_Teams, KeyValuePair<int, string>>) (t => new KeyValuePair<int, string>(t.get_TeamId(), t.get_TeamName()))))
      });
    }

    public ActionResult ShowProductionDates(int itemId, int eventId)
    {
    //  try
      //{
      //  List<string> list = Enumerable.ToList<string>(Enumerable.Distinct<string>(Enumerable.Select<fb_ProductionDates, string>((IEnumerable<fb_ProductionDates>) new ProductionDateService().GetAllProductionDatesByItemId(itemId, eventId), (Func<fb_ProductionDates, string>) (x => x.get_ProdcutionDate().ToString("MM/dd/yyyy")))));
      //  // ISSUE: reference to a compiler-generated field
      //  if (ItemController.\u003CShowProductionDates\u003Eo__SiteContainer5d.\u003C\u003Ep__Site5e == null)
      //  {
      //    // ISSUE: reference to a compiler-generated field
      //    ItemController.\u003CShowProductionDates\u003Eo__SiteContainer5d.\u003C\u003Ep__Site5e = CallSite<Func<CallSite, object, List<string>, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "ProductionDates", typeof (ItemController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
      //    {
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
      //      CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
      //    }));
      //  }
      //  // ISSUE: reference to a compiler-generated field
      //  // ISSUE: reference to a compiler-generated field
      //  object obj = ItemController.\u003CShowProductionDates\u003Eo__SiteContainer5d.\u003C\u003Ep__Site5e.Target((CallSite) ItemController.\u003CShowProductionDates\u003Eo__SiteContainer5d.\u003C\u003Ep__Site5e, this.ViewBag, list);
      //  return (ActionResult) this.View();
      //}
      //catch (Exception ex)
      //{
      //  this._loggerService.Error(ex);
        return (ActionResult) this.Json((object) new
        {
          result = "Fail"
        });
      //}
    }

    public ActionResult UnBatchItems(ItemModel itemModel)
    {
      //try
      //{
      //  using (BatchService batchService = new BatchService())
      //  {
      //    BatchModel batchModel = new BatchModel();
      //    foreach (CheckItem checkItem in Enumerable.Where<CheckItem>((IEnumerable<CheckItem>) itemModel.ItemList, (Func<CheckItem, bool>) (x => x.BatchID != 0)))
      //    {
      //      // ISSUE: object of a compiler-generated type is created
      //      // ISSUE: variable of a compiler-generated type
      //      ItemController.\u003C\u003Ec__DisplayClass63 cDisplayClass63 = new ItemController.\u003C\u003Ec__DisplayClass63();
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass63.item = checkItem;
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      // ISSUE: field reference
      //      // ISSUE: method reference
      //      fb_Batches fbBatches = Queryable.FirstOrDefault<fb_Batches>(Queryable.Where<fb_Batches>(((BusinessServiceBase<fb_Batches>) batchService).FindAll(), Expression.Lambda<Func<fb_Batches, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Batches.get_ID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass63), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass63.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_BatchID)))), new ParameterExpression[1]
      //      {
      //        parameterExpression
      //      })));
      //      if (fbBatches != null)
      //        ((BusinessServiceBase<fb_Batches>) batchService).Delete(fbBatches, true);
      //    }
      //    return (ActionResult) this.Json((object) new
      //    {
      //      result = "Success",
      //      ItemModelList = itemModel.ItemList
      //    });
      //  }
      //}
      //catch (Exception ex)
      //{
      //  this._loggerService.Error(ex);
      //  return (ActionResult) this.Json((object) new
      //  {
      //    result = "Fail"
      //  });
      //}

          return null;
    }

    public ActionResult UnBatchSubItems(ItemModel itemModel)
    {
      //try
      //{
      //  using (BatchService batchService = new BatchService())
      //  {
      //    BatchModel batchModel = new BatchModel();
      //    foreach (CheckItem checkItem in itemModel.ItemList)
      //    {
      //      // ISSUE: object of a compiler-generated type is created
      //      // ISSUE: variable of a compiler-generated type
      //      ItemController.\u003C\u003Ec__DisplayClass65 cDisplayClass65 = new ItemController.\u003C\u003Ec__DisplayClass65();
      //      // ISSUE: reference to a compiler-generated field
      //      cDisplayClass65.item = checkItem;
      //      ParameterExpression parameterExpression;
      //      // ISSUE: method reference
      //      // ISSUE: field reference
      //      // ISSUE: method reference
      //      fb_Batches fbBatches = Queryable.FirstOrDefault<fb_Batches>(Queryable.Where<fb_Batches>(((BusinessServiceBase<fb_Batches>) batchService).FindAll(), Expression.Lambda<Func<fb_Batches, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (fb_Batches.get_ID))), (Expression) Expression.Property((Expression) Expression.Field((Expression) Expression.Constant((object) cDisplayClass65), FieldInfo.GetFieldFromHandle(__fieldref (ItemController.\u003C\u003Ec__DisplayClass65.item))), (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (CheckItem.get_BatchID)))), new ParameterExpression[1]
      //      {
      //        parameterExpression
      //      })));
      //      if (fbBatches != null)
      //        ((BusinessServiceBase<fb_Batches>) batchService).Delete(fbBatches, true);
      //    }
      //    return (ActionResult) this.Json((object) new
      //    {
      //      result = "Success"
      //    });
      //  }
      //}
      //catch (Exception ex)
      //{
      //  this._loggerService.Error(ex);
        return (ActionResult)this.Json((object)new
        {
            result = "Fail"
        });
      //}
    }

    public ActionResult ShowNotes(int itemId, int eventId)
    {
      try
      {
        ItemsService itemsService = new ItemsService();
        ItemModel itemModel = new ItemModel();
        //return (ActionResult) this.View((object) MappedExtensions.ToModel(itemsService.GetNotesByEventItemBYId(itemId, eventId)));
        return null;
      }
      catch (Exception ex)
      {
        this._loggerService.Error(ex);
        return (ActionResult) this.Json((object) new
        {
          result = "Fail"
        });
      }
    }

    [HttpPost]
    public ActionResult SaveNotes(int Id, int ItemId, int EventId, string Notes)
    {
      try
      {
       // new ItemsService().UpdateNotes(ItemId, EventId, Notes);
        return (ActionResult) this.Json((object) new
        {
          result = "Success"
        });
      }
      catch (Exception ex)
      {
        this._loggerService.Error(ex);
        return (ActionResult) this.Json((object) new
        {
          result = "Fail"
        });
      }
    }
  }
}
