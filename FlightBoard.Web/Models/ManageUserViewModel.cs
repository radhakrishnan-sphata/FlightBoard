// Decompiled with JetBrains decompiler
// Type: FlightBoard.Web.Models.ManageUserViewModel
// Assembly: FlightBoard.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F41503E4-7D9D-4350-A76C-BE637BF763C9
// Assembly location: C:\Users\radhakrishnan\Desktop\FlightBoard.Web.dll

using System.ComponentModel.DataAnnotations;

namespace FlightBoard.Web.Models
{
  public class ManageUserViewModel
  {
    [Display(Name = "Current password")]
    [DataType(DataType.Password)]
    [Required]
    public string OldPassword { get; set; }

    [DataType(DataType.Password)]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
    [Required]
    [Display(Name = "New password")]
    public string NewPassword { get; set; }

    [DataType(DataType.Password)]
    [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
    [Display(Name = "Confirm new password")]
    public string ConfirmPassword { get; set; }
  }
}
