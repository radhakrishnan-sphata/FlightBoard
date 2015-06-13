// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.IngredientsModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;
using System.Collections.Generic;

namespace FlightBoard.Web.Models
{
    public class IngredientsModel
    {
        public string Prdname { get; set; }

        public Decimal Qty { get; set; }

        public string Description { get; set; }

        public string ItemuofmCompoundtext { get; set; }

        public int ComponentItemID { get; set; }

        public List<FlightBoard.Web.Models.SubItemsModel> SubItemsModel { get; set; }

        public IngredientsModel()
        {
            this.SubItemsModel = new List<FlightBoard.Web.Models.SubItemsModel>();
        }
    }
}
