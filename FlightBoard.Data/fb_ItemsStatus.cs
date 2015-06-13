// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.fb_ItemsStatus
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using System;

namespace FlightBoard.Data
{
    public class fb_ItemsStatus
    {
        public int ID { get; set; }

        public int StatusId { get; set; }

        public int ItemId { get; set; }

        public int EventId { get; set; }

        public int TeamMemberID { get; set; }

        public int LeadID { get; set; }

        public int TeamID { get; set; }

        public DateTime ProductionDate { get; set; }

        public string Notes { get; set; }

        public virtual fb_Teams fb_Teams { get; set; }

        public virtual fb_status fb_status { get; set; }

        public virtual fb_Users fb_Users { get; set; }

        public virtual fb_Users fb_Users1 { get; set; }
    }
}
