// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.ItemByProductionDateModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;

namespace FlightBoard.Web.Models
{
    public class ItemByProductionDateModel
    {
        public int ID { get; set; }

        public int Item_intid { get; set; }

        public int ItemEvent_intid { get; set; }

        public Decimal? Quantity { get; set; }

        public string ItemName { get; set; }

        public bool IsSubItem { get; set; }

        public string UniQueItemIds { get; set; }

        public bool? HasSubItem { get; set; }

        public string ProductionDate { get; set; }

        public string ItemImageFileName { get; set; }
    }
}
