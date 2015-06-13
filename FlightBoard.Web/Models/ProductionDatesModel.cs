// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.ProductionDatesModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class ProductionDatesModel
    {
        [HiddenInput]
        public int ID { get; set; }

        [HiddenInput]
        public int ItemId { get; set; }

        [HiddenInput]
        public int EventId { get; set; }

        public DateTime ProdcutionDate { get; set; }

        public int AssignItemID { get; set; }

        public List<CheckItem> ItemList { get; set; }

        public List<SubItemsList1> SubItemsList { get; set; }
    }
}
