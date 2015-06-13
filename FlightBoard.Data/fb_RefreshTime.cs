using System;

namespace FlightBoard.Data
{
    public class fb_RefreshTime
    {
        public int ID { get; set; }

        public DateTime RefreshTime { get; set; }

        public int? NoOfNewRecords { get; set; }
    }
}
