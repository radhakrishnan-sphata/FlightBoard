
namespace FlightBoard.Data
{
    public class fb_TeamMembers
    {
        public int ID { get; set; }

        public int TeamId { get; set; }

        public int TeamMemberId { get; set; }

        public virtual fb_Teams fb_Teams { get; set; }

        public virtual fb_Users fb_Users { get; set; }
    }
}
