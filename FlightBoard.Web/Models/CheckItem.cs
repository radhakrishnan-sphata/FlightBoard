using System;

namespace FlightBoard.Web.Models
{
    public class CheckItem
    {
        public int Key { get; set; }

        public string Value { get; set; }

        public int EventId { get; set; }

        public string ContractId { get; set; }

        public bool IsPreviouslyAssigned { get; set; }

        public Decimal? Quantity { get; set; }

        public int BatchID { get; set; }

        public string BatchName { get; set; }

        public string BatchColor { get; set; }

        public bool IsChecked { get; set; }

        public bool IsEdit { get; set; }
    }
}
