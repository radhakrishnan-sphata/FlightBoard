
using System.Collections.Generic;

namespace FlightBoard.Data
{
    public class AssignItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public int EventId { get; set; }

        public string Notes { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_AssignedTeam> fb_AssignedTeam { get; set; }

        public virtual ICollection<FlightBoard.Data.fb_ProductionDates> fb_ProductionDates { get; set; }

        public AssignItem()
        {
            this.fb_AssignedTeam = (ICollection<FlightBoard.Data.fb_AssignedTeam>)new HashSet<FlightBoard.Data.fb_AssignedTeam>();
            this.fb_ProductionDates = (ICollection<FlightBoard.Data.fb_ProductionDates>)new HashSet<FlightBoard.Data.fb_ProductionDates>();
        }
    }
}