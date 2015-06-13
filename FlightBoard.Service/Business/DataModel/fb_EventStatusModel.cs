using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class fb_EventStatusModel
    {
        public int? EventId { get; set; }

        public string ContractID { get; set; }

        public int? TotalItemCount { get; set; }

        public int? TotalCompletedItemsCount { get; set; }

        public Decimal ProgressPercent { get; set; }
    }
}
