using System.ComponentModel.DataAnnotations;

namespace FlightBoard.Web.Models
{
    public class ExternalLoginConfirmationViewModel2
    {
        [Display(Name = "User name")]
        [Required]
        public string UserName { get; set; }
    }
}