using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class fb_status
    {
        public int ID { get; set; }

        public string StatusName { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_ItemsStatus> fb_ItemsStatus { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_ProductionDates> fb_ProductionDates { get; set; }

        public fb_status()
        {
            this.fb_ItemsStatus = (ICollection<FlightBoard.Data.fb_ItemsStatus>)new HashSet<FlightBoard.Data.fb_ItemsStatus>();
            this.fb_ProductionDates = (ICollection<FlightBoard.Data.fb_ProductionDates>)new HashSet<FlightBoard.Data.fb_ProductionDates>();
        }
    }
}
