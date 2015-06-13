// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.Items2_Result
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System;

namespace FlightBoard.Web.Models
{
    public class Items2_Result
    {
        public int unitid { get; set; }

        public string unitname { get; set; }

        public short timeperiod { get; set; }

        public string mealname { get; set; }

        public Decimal? custcount { get; set; }

        public Decimal? served_custcount { get; set; }

        public Decimal? sold_custcount { get; set; }

        public string srvcrsname { get; set; }

        public string itemname { get; set; }

        public string prtnsize { get; set; }

        public string served_prtnsize { get; set; }

        public string sold_prtnsize { get; set; }

        public int? itemuofm1_intid { get; set; }

        public Decimal? qty1 { get; set; }

        public int? itemuofm2_intid { get; set; }

        public Decimal? qty2 { get; set; }

        public int? itemuofm3_intid { get; set; }

        public Decimal? qty3 { get; set; }

        public Decimal? sell_price1 { get; set; }

        public Decimal? sell_price2 { get; set; }

        public Decimal? sell_price3 { get; set; }

        public DateTime? eventdate { get; set; }

        public int item_intid { get; set; }

        public int eventlist_intid { get; set; }

        public int itemxa_intid { get; set; }

        public int itemevent_intid { get; set; }

        public short? itemgroup { get; set; }

        public short? groupseq { get; set; }

        public string source { get; set; }

        public float? sortorder1 { get; set; }

        public int? servicecourse_intid { get; set; }

        public Decimal? costprice { get; set; }

        public Decimal? costprice2 { get; set; }

        public Decimal? costprice3 { get; set; }

        public Decimal? day_fcstcount { get; set; }

        public Decimal? total_fcstcount { get; set; }

        public Decimal? day_servedcount { get; set; }

        public Decimal? total_servedcount { get; set; }

        public Decimal? day_soldcount { get; set; }

        public Decimal? total_soldcount { get; set; }

        public string eventstatus { get; set; }

        public Decimal? price1 { get; set; }

        public Decimal? price2 { get; set; }

        public Decimal? price3 { get; set; }

        public short? approval_code { get; set; }

        public string keyname { get; set; }

        public float? codesort { get; set; }

        public short itemtypecode { get; set; }

        public Decimal? viewsellprice { get; set; }

        public DateTime? tlc { get; set; }
    }
}
