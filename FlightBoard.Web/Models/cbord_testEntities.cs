// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.cbord_testEntities
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace FlightBoard.Web.Models
{
  public class cbord_testEntities : DbContext
  {
    public cbord_testEntities()
    {
      //this.\u002Ector("name=cbord_testEntities");
    }

    protected virtual void OnModelCreating(DbModelBuilder modelBuilder)
    {
      throw new UnintentionalCodeFirstException();
    }

    public virtual ObjectResult<Events_Result> Events()
    {
      //return (ObjectResult<Events_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<Events_Result>("Events", new ObjectParameter[0]);
      return null;
    }

    public virtual ObjectResult<MealList_Result> MealList()
    {
      //return (ObjectResult<MealList_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<MealList_Result>("MealList", new ObjectParameter[0]);
      return null;
    }

    public virtual ObjectResult<ServiceUnits_Result> ServiceUnits()
    {
      //return (ObjectResult<ServiceUnits_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<ServiceUnits_Result>("ServiceUnits", new ObjectParameter[0]);
      return null;
    }

    public virtual ObjectResult<Items2_Result1> Items2(int? unitid, string eventdate, string name)
    {
      //return (ObjectResult<Items2_Result1>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<Items2_Result1>("Items2", new ObjectParameter[3]
      //{
      //  unitid.HasValue ? new ObjectParameter("unitid", (object) unitid) : new ObjectParameter("unitid", typeof (int)),
      //  eventdate != null ? new ObjectParameter("eventdate", (object) eventdate) : new ObjectParameter("eventdate", typeof (string)),
      //  name != null ? new ObjectParameter("name", (object) name) : new ObjectParameter("name", typeof (string))
      //});
        return null;
    }

    public virtual ObjectResult<sp_fb_Events_Result5> sp_fb_Events(DateTime? refreshTime)
    {
      //return (ObjectResult<sp_fb_Events_Result5>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<sp_fb_Events_Result5>("sp_fb_Events", new ObjectParameter[1]
      //{
      //  refreshTime.HasValue ? new ObjectParameter("RefreshTime", (object) refreshTime) : new ObjectParameter("RefreshTime", typeof (DateTime))
      //});
        return null;
    }

    public virtual int IngredientsForItems(int? assemblage_item_intid)
    {
      //return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("IngredientsForItems", new ObjectParameter[1]
      //{
      //  assemblage_item_intid.HasValue ? new ObjectParameter("assemblage_item_intid", (object) assemblage_item_intid) : new ObjectParameter("assemblage_item_intid", typeof (int))
      //});
        return 0;
    }

    public virtual ObjectResult<sp_fb_GetItemImage_Result> sp_fb_GetItemImage(DateTime? refreshTime, int? itemID)
    {
      //return (ObjectResult<sp_fb_GetItemImage_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<sp_fb_GetItemImage_Result>("sp_fb_GetItemImage", new ObjectParameter[2]
      //{
      //  refreshTime.HasValue ? new ObjectParameter("RefreshTime", (object) refreshTime) : new ObjectParameter("RefreshTime", typeof (DateTime)),
      //  itemID.HasValue ? new ObjectParameter("ItemID", (object) itemID) : new ObjectParameter("ItemID", typeof (int))
      //});
        return null;
    }

    public virtual ObjectResult<sp_fb_Items_Result7> sp_fb_Items(int? eventlistID)
    {
      //return (ObjectResult<sp_fb_Items_Result7>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<sp_fb_Items_Result7>("sp_fb_Items", new ObjectParameter[1]
      //{
      //  eventlistID.HasValue ? new ObjectParameter("eventlistID", (object) eventlistID) : new ObjectParameter("eventlistID", typeof (int))
      //});
        return null;
    }

    public virtual ObjectResult<IngredientsForItems1_Result1> IngredientsForItems1(int? assemblage_item_intid)
    {
      //return (ObjectResult<IngredientsForItems1_Result1>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<IngredientsForItems1_Result1>("IngredientsForItems1", new ObjectParameter[1]
      //{
      //  assemblage_item_intid.HasValue ? new ObjectParameter("assemblage_item_intid", (object) assemblage_item_intid) : new ObjectParameter("assemblage_item_intid", typeof (int))
      //});
        return null;
    }
  }
}
