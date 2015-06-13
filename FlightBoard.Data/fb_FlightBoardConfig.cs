
using System;

namespace FlightBoard.Data
{
    public class fb_FlightBoardConfig
    {
        public int ID { get; set; }

        public int TemplateID { get; set; }

        public int? NoofDays { get; set; }

        public string TransitionTime { get; set; }

        public DateTime? EventStartDate { get; set; }

        public DateTime? EventEndDate { get; set; }

        public DateTime? ProductionFrom { get; set; }

        public DateTime? ProductionTo { get; set; }

        public int? EventID { get; set; }

        public int DeviceUnitID { get; set; }

        public int? PrepAreaId { get; set; }

        public virtual fb_DeviceUnits fb_DeviceUnits { get; set; }
    }
}
