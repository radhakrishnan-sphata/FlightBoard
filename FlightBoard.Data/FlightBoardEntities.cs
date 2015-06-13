// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.FlightBoardEntities
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace FlightBoard.Data
{
  public class FlightBoardEntities : DbContext
  {
    public virtual DbSet<AssignItem> AssignItems { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_AssignedTeam> fb_AssignedTeam { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_Batches> fb_Batches { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_BatchItems> fb_BatchItems { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_DeviceUnits> fb_DeviceUnits { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_Events> fb_Events { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_ItemsStatus> fb_ItemsStatus { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_ProductionDates> fb_ProductionDates { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_RefreshTime> fb_RefreshTime { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_Roles> fb_Roles { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_SchedulerTemplates> fb_SchedulerTemplates { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_status> fb_status { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_TeamMembers> fb_TeamMembers { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_Teams> fb_Teams { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_Users> fb_Users { get; set; }

    public virtual DbSet<FlightBoard.Data.vw_GetAllAssignedItemDetails> vw_GetAllAssignedItemDetails { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_Items> fb_Items { get; set; }

    public virtual DbSet<FlightBoard.Data.fb_FlightBoardConfig> fb_FlightBoardConfig { get; set; }

    public FlightBoardEntities()
    {
    //  this.\u002Ector("name=FlightBoardEntities");
    }

    protected virtual void OnModelCreating(DbModelBuilder modelBuilder)
    {
      throw new UnintentionalCodeFirstException();
    }

    //public virtual int sp_alterdiagram(string diagramname, int? owner_id, int? version, byte[] definition)
    //{
    //  return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("sp_alterdiagram", new ObjectParameter[4]
    //  {
    //    diagramname != null ? new ObjectParameter("diagramname", (object) diagramname) : new ObjectParameter("diagramname", typeof (string)),
    //    owner_id.HasValue ? new ObjectParameter("owner_id", (object) owner_id) : new ObjectParameter("owner_id", typeof (int)),
    //    version.HasValue ? new ObjectParameter("version", (object) version) : new ObjectParameter("version", typeof (int)),
    //    definition != null ? new ObjectParameter("definition", (object) definition) : new ObjectParameter("definition", typeof (byte[]))
    //  });
    //}

    //public virtual int sp_creatediagram(string diagramname, int? owner_id, int? version, byte[] definition)
    //{
    //  return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("sp_creatediagram", new ObjectParameter[4]
    //  {
    //    diagramname != null ? new ObjectParameter("diagramname", (object) diagramname) : new ObjectParameter("diagramname", typeof (string)),
    //    owner_id.HasValue ? new ObjectParameter("owner_id", (object) owner_id) : new ObjectParameter("owner_id", typeof (int)),
    //    version.HasValue ? new ObjectParameter("version", (object) version) : new ObjectParameter("version", typeof (int)),
    //    definition != null ? new ObjectParameter("definition", (object) definition) : new ObjectParameter("definition", typeof (byte[]))
    //  });
    //}

    //public virtual int sp_dropdiagram(string diagramname, int? owner_id)
    //{
    //  return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("sp_dropdiagram", new ObjectParameter[2]
    //  {
    //    diagramname != null ? new ObjectParameter("diagramname", (object) diagramname) : new ObjectParameter("diagramname", typeof (string)),
    //    owner_id.HasValue ? new ObjectParameter("owner_id", (object) owner_id) : new ObjectParameter("owner_id", typeof (int))
    //  });
    //}

    //public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, int? owner_id)
    //{
    //  return (ObjectResult<sp_helpdiagramdefinition_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", new ObjectParameter[2]
    //  {
    //    diagramname != null ? new ObjectParameter("diagramname", (object) diagramname) : new ObjectParameter("diagramname", typeof (string)),
    //    owner_id.HasValue ? new ObjectParameter("owner_id", (object) owner_id) : new ObjectParameter("owner_id", typeof (int))
    //  });
    //}

    //public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, int? owner_id)
    //{
    //  return (ObjectResult<sp_helpdiagrams_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", new ObjectParameter[2]
    //  {
    //    diagramname != null ? new ObjectParameter("diagramname", (object) diagramname) : new ObjectParameter("diagramname", typeof (string)),
    //    owner_id.HasValue ? new ObjectParameter("owner_id", (object) owner_id) : new ObjectParameter("owner_id", typeof (int))
    //  });
    //}

    //public virtual int sp_renamediagram(string diagramname, int? owner_id, string new_diagramname)
    //{
    //  return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("sp_renamediagram", new ObjectParameter[3]
    //  {
    //    diagramname != null ? new ObjectParameter("diagramname", (object) diagramname) : new ObjectParameter("diagramname", typeof (string)),
    //    owner_id.HasValue ? new ObjectParameter("owner_id", (object) owner_id) : new ObjectParameter("owner_id", typeof (int)),
    //    new_diagramname != null ? new ObjectParameter("new_diagramname", (object) new_diagramname) : new ObjectParameter("new_diagramname", typeof (string))
    //  });
    //}

    //public virtual int sp_upgraddiagrams()
    //{
    //  return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("sp_upgraddiagrams", new ObjectParameter[0]);
    //}

    //public virtual int ProcGetEventStatusByProductionDate(DateTime? productionDate)
    //{
    //  return ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction("ProcGetEventStatusByProductionDate", new ObjectParameter[1]
    //  {
    //    productionDate.HasValue ? new ObjectParameter("ProductionDate", (object) productionDate) : new ObjectParameter("ProductionDate", typeof (DateTime))
    //  });
    //}

    //public virtual ObjectResult<ProcGetEventStatusByProductionDate_Result> ProcGetEventStatusByProductionDate1(DateTime? productionDate)
    //{
    //  return (ObjectResult<ProcGetEventStatusByProductionDate_Result>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<ProcGetEventStatusByProductionDate_Result>("ProcGetEventStatusByProductionDate1", new ObjectParameter[1]
    //  {
    //    productionDate.HasValue ? new ObjectParameter("ProductionDate", (object) productionDate) : new ObjectParameter("ProductionDate", typeof (DateTime))
    //  });
    //}

    //public virtual ObjectResult<GetAllEventsByFirstTemplate_Result1> GetAllEventsByFirstTemplate(int? templateID, int? deviceUnitID)
    //{
    //  return (ObjectResult<GetAllEventsByFirstTemplate_Result1>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<GetAllEventsByFirstTemplate_Result1>("GetAllEventsByFirstTemplate", new ObjectParameter[2]
    //  {
    //    templateID.HasValue ? new ObjectParameter("TemplateID", (object) templateID) : new ObjectParameter("TemplateID", typeof (int)),
    //    deviceUnitID.HasValue ? new ObjectParameter("DeviceUnitID", (object) deviceUnitID) : new ObjectParameter("DeviceUnitID", typeof (int))
    //  });
    //}

    //public virtual ObjectResult<GETAllEventsByFirstTemplate1_Result1> GETAllEventsByFirstTemplate1(int? templateID, int? deviceUnitID)
    //{
    //  return (ObjectResult<GETAllEventsByFirstTemplate1_Result1>) ((IObjectContextAdapter) this).get_ObjectContext().ExecuteFunction<GETAllEventsByFirstTemplate1_Result1>("GETAllEventsByFirstTemplate1", new ObjectParameter[2]
    //  {
    //    templateID.HasValue ? new ObjectParameter("TemplateID", (object) templateID) : new ObjectParameter("TemplateID", typeof (int)),
    //    deviceUnitID.HasValue ? new ObjectParameter("DeviceUnitID", (object) deviceUnitID) : new ObjectParameter("DeviceUnitID", typeof (int))
    //  });
    //}
  }
}
