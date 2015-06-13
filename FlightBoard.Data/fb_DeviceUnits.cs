
using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class fb_DeviceUnits
    {
        public int ID { get; set; }

        public string DeviceUnitName { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_FlightBoardConfig> fb_FlightBoardConfig { get; set; }

        public fb_DeviceUnits()
        {
            this.fb_FlightBoardConfig = (ICollection<FlightBoard.Data.fb_FlightBoardConfig>)new HashSet<FlightBoard.Data.fb_FlightBoardConfig>();
        }
    }
}