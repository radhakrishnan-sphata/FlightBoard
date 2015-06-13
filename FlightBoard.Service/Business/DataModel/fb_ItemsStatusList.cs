using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class fb_ItemsStatusList
    {
        public int ItemID { get; set; }

        public int? EventID { get; set; }

        public string ItemName { get; set; }

        public string Contract { get; set; }

        public int Status { get; set; }

        public Decimal? Quantity { get; set; }

        public string Vessel { get; set; }

        public int? TeamMemberID { get; set; }

        public int? TeamLeadID { get; set; }

        public string ShowButton { get; set; }
    }
}
