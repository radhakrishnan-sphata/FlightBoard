// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.EventModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;

namespace FlightBoard.Web.Models
{
    public class EventModel
    {
        public string Contract { get; set; }

        public string EventName { get; set; }

        public DateTime? EventDate { get; set; }

        public int? NoofItems { get; set; }

        public string TeamLead { get; set; }

        public string Description { get; set; }

        public string DateOfProduction { get; set; }

        public int? UnitId { get; set; }

        public string UnitName { get; set; }

        public string MealName { get; set; }

        public int EventId { get; set; }

        public int? FSSeventlist_intid { get; set; }

        public Decimal? Quantity { get; set; }

        public string ProductionDate { get; set; }
    }
}
