using System;

namespace FlightBoard.Web.Models
{
    public class sp_fb_Events_Result4
    {
        public int unitid { get; set; }

        public string unitname { get; set; }

        public string mealname { get; set; }

        public DateTime? eventdate { get; set; }

        public string note { get; set; }

        public int ItemEvent_intid { get; set; }

        public Decimal? Qty1 { get; set; }

        public DateTime? TLC { get; set; }

        public Decimal? Qty3 { get; set; }

        public string NoOfItems { get; set; }
    }
}