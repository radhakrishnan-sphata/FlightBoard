using System;

namespace FlightBoard.Service.Business.DataModels
{
    public class fb_Teams_Data
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        public int TeamLeadId { get; set; }

        public string TeamLeadName { get; set; }

        public string TeamMemberName { get; set; }

        public int TeamMemberId { get; set; }

        public DateTime TeamStartDate { get; set; }

        public DateTime TeamEndDate { get; set; }
    }
}
