using System.ComponentModel.DataAnnotations;
using WinFormsDapperMVP.Helpers;

namespace WinFormsDapperMVP.Models;

public class User
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? LastName { get; set; }

  [Required(ErrorMessage ="Email is required.")]
  [EmailAddress(ErrorMessage ="Wrong Email value.")]
  public string Email { get; set; }
  [CustomValidation(typeof(DateCustomValidator), nameof(DateCustomValidator.ValidateDateIsFutureDate))]
  public DateTime? BirthDay { get; set; }

  
}
