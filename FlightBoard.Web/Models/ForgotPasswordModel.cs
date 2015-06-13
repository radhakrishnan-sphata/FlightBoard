using System.ComponentModel.DataAnnotations;

namespace FlightBoard.Web.Models
{
    public class ForgotPasswordModel
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User name is required.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "SSN is required")]
        [DataType(DataType.Password)]
        [Display(Name = "SSN")]
        public string SSN { get; set; }
    }
}
