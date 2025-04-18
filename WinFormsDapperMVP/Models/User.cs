using System.ComponentModel.DataAnnotations;

namespace WinFormsDapperMVP.Models;

public class User
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public string? LastName { get; set; }

  [Required(ErrorMessage ="Email is required.")]
  [EmailAddress(ErrorMessage ="Wrong Email value.")]
  public string Email { get; set; }
  public DateTime? BirthDay { get; set; }

  
}
