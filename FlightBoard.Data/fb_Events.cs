// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.fb_Events
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using System;

namespace FlightBoard.Data
{
    public class fb_Events
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
    }
}
