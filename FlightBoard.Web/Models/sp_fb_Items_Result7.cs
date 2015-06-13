// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.sp_fb_Items_Result7
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;

namespace FlightBoard.Web.Models
{
    public class sp_fb_Items_Result7
    {
        public int Eventlist_intid { get; set; }

        public int Itemxa_intid { get; set; }

        public int Item_intid { get; set; }

        public int ItemEvent_intid { get; set; }

        public Decimal? QTY1 { get; set; }

        public Decimal? QTY2 { get; set; }

        public Decimal? QTY3 { get; set; }

        public short Itemevent_type { get; set; }

        public string itemname { get; set; }

        public Decimal? itemeventQty1 { get; set; }

        public Decimal? itemeventQty2 { get; set; }

        public Decimal? itemeventQty3 { get; set; }

        public int? preparea_intid { get; set; }

        public string LOCID { get; set; }

        public string Prd_Image { get; set; }
    }
}
