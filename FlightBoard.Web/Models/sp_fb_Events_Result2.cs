using System;

namespace FlightBoard.Web.Models
{
    public class sp_fb_Events_Result2
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