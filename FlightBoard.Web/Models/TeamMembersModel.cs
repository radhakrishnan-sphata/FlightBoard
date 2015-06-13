using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class TeamMembersModel
    {
        [HiddenInput]
        public int ID { get; set; }

        [Display(Name = "Team Id")]
        public int TeamId { get; set; }

        [Display(Name = "Team MemberID")]
        public int TeamMemberId { get; set; }
    }
}
