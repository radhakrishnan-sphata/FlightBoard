
using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class fb_ProductionDates_Data
    {
        public int ItemId { get; set; }

        public int EventId { get; set; }

        public int ID { get; set; }

        public string ItemName { get; set; }

        public DateTime ProductionDate { get; set; }
    }
}