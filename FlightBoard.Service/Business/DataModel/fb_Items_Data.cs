// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.DataModels.fb_Items_Data
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class fb_Items_Data
    {
        public int ItemId { get; set; }

        public string ProductionFrom { get; set; }

        public string ItemName { get; set; }

        public string BatchName { get; set; }

        public string TeamLead { get; set; }

        public string TeamMember { get; set; }

        public string Recipe { get; set; }

        public string ContractID { get; set; }

        public bool IsSubItem { get; set; }

        public int EventID { get; set; }

        public string EventDate { get; set; }

        public Decimal? Quantity { get; set; }

        public int ID { get; set; }
    }
}
