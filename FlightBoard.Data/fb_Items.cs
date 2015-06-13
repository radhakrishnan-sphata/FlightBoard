using System;

namespace FlightBoard.Data
{
    public class fb_Items
    {
        public int ID { get; set; }

        public int Item_intid { get; set; }

        public int ItemEvent_intid { get; set; }

        public Decimal? Quantity { get; set; }

        public string ItemName { get; set; }

        public bool IsSubItem { get; set; }

        public string UniQueItemIds { get; set; }

        public bool? HasSubItem { get; set; }

        public int? PrepAreaId { get; set; }

        public string PrepAreaName { get; set; }

        public string Notes { get; set; }

        public string ItemImageFileName { get; set; }
    }
}
