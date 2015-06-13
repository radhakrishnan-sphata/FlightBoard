// Decompiled with JetBrains decompiler
// Type: FlightBoard.Data.vw_GetAllAssignedItemDetails
// Assembly: FlightBoard.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 434D1468-4C4B-4EB7-A6F9-D9D136C51224
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Data.dll

using System;

namespace FlightBoard.Data
{
    public class vw_GetAllAssignedItemDetails
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int EventId { get; set; }

        public DateTime ProdcutionDate { get; set; }

        public int StatusID { get; set; }

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

        public DateTime? EventDate { get; set; }

        public int? NoofItems { get; set; }

        public string UnitName { get; set; }

        public int? UnitId { get; set; }
    }
}
