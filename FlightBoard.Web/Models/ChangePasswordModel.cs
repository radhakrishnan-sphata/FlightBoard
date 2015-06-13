
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FlightBoard.Web.Models
{
    public class ChangePasswordModel
    {
        [Display(Name = "Current Password")]
        [Required(ErrorMessage = "Current Password is required.")]
        public string CurrentPassword { get; set; }

        [Display(Name = "New Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

      //  [Compare("NewPassword")]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
