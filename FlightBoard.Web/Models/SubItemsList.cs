// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.SubItemsList
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

namespace FlightBoard.Web.Models
{
    public class SubItemsList
    {
        public int BatchId { get; set; }

        public int EventId { get; set; }

        public int SubItemId { get; set; }

        public string SubItemName { get; set; }

        public int MainItemId { get; set; }

        public string MainItemName { get; set; }

        public string BatchName { get; set; }

        public string BatchColor { get; set; }

        public bool IsPreviouslyAssigned { get; set; }

        public bool IsEdit { get; set; }
    }
}
