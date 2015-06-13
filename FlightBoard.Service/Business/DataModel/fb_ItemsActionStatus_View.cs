// Decompiled with JetBrains decompiler
// Type: FlightBoard.Service.Business.DataModels.fb_ItemsActionStatus_View
// Assembly: FlightBoard.Service, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 865BA1F4-EA8F-4787-AA28-3D15C05E7A78
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Service.dll

using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class fb_ItemsActionStatus_View
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int EventId { get; set; }

        public DateTime ProdcutionDate { get; set; }

        public int? StatusID { get; set; }

        public string StatusName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int UserId { get; set; }

        public int? MemberID { get; set; }

        public int? LeadID { get; set; }

        public int? TeamID { get; set; }

        public string ItemName { get; set; }

        public Decimal? Quantity { get; set; }

        public string EventName { get; set; }

        public string Contract { get; set; }

        public Decimal? eventQuantity { get; set; }

        public string Notes { get; set; }

        public string AssignedNotes { get; set; }

        public bool IsBatch { get; set; }
    }
}
