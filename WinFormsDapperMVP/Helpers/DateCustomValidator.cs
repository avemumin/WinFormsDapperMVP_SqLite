using System.ComponentModel.DataAnnotations;

namespace WinFormsDapperMVP.Helpers;

public class DateCustomValidator
{
  public static ValidationResult ValidateDateIsFutureDate(DateTime? BirthDay, ValidationContext context)
  {
    if (!BirthDay.HasValue || BirthDay.Value > DateTime.Today)
    {
      return new ValidationResult("The date must be at most equal to today's", new[] { context.MemberName });
    }
    return ValidationResult.Success;
  }
}
