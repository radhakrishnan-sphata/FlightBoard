// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.IngredientsForItems1_Result
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;

namespace FlightBoard.Web.Models
{
    public class IngredientsForItems1_Result
    {
        public string prd_name { get; set; }

        public Decimal qty { get; set; }

        public string description { get; set; }

        public int itemlist_intid { get; set; }

        public int? itemxa_intid { get; set; }

        public int assemblage_item_intid { get; set; }

        public int component_item_intid { get; set; }

        public float? sortorder1 { get; set; }

        public int? itemuofm_intid { get; set; }

        public short? itemgroup { get; set; }

        public short? groupseq { get; set; }

        public string explodeflag { get; set; }

        public string itemuofm_compoundtext { get; set; }

        public Decimal? costprice { get; set; }

        public Decimal? yield { get; set; }

        public string srv_uofm { get; set; }

        public string packsize_uofm { get; set; }

        public Decimal? packsize_uofmbasis { get; set; }

        public Decimal? srv_uofmbasis { get; set; }

        public int citemhasnoteflag { get; set; }

        public Decimal? costyield { get; set; }

        public string longname { get; set; }

        public short itemtypecode { get; set; }
    }
}
