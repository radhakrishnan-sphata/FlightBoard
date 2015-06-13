using System;

namespace FlightBoard.Web.Models
{
    public class Events_Result
    {
        public int unitid { get; set; }

        public string unitname { get; set; }

        public string mealname { get; set; }

        public DateTime? eventdate { get; set; }

        public string NoOdItems { get; set; }
    }
}