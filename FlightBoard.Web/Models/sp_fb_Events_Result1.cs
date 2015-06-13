// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.sp_fb_Events_Result1
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;

namespace FlightBoard.Web.Models
{
    public class sp_fb_Events_Result1
    {
        public int unitid { get; set; }

        public string unitname { get; set; }

        public string mealname { get; set; }

        public DateTime? eventdate { get; set; }

        public string note { get; set; }

        public DateTime? TLC { get; set; }

        public string NoOfItems { get; set; }
    }
}
