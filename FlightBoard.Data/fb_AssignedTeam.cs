namespace FlightBoard.Data
{
    public class fb_AssignedTeam
    {
        public int ID { get; set; }

        public int AssignItemID { get; set; }

        public int? MemberID { get; set; }

        public int? LeadID { get; set; }

        public int? TeamID { get; set; }

        public virtual AssignItem AssignItem { get; set; }
    }
}