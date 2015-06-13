using System;

namespace FlightBoard.Data
{
    public class fb_ProductionDates
    {
        public int ID { get; set; }

        public int AssignItemID { get; set; }

        public int ItemId { get; set; }

        public int EventID { get; set; }

        public DateTime ProdcutionDate { get; set; }

        public int? StatusID { get; set; }

        public string Notes { get; set; }

        public virtual AssignItem AssignItem { get; set; }

        public virtual fb_status fb_status { get; set; }
    }
}
