using WinFormsDapperMVP.Models;

namespace WinFormsDapperMVP.Helpers
{
  public static class UserExtension
  {
    public static IEnumerable<User>? FilterCollection(this IEnumerable<User> collection, string filter)
    {
      var result = collection.Where(x => x.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase)
      || x.LastName.Contains(filter, StringComparison.InvariantCultureIgnoreCase)
      || x.Email.Contains(filter, StringComparison.InvariantCultureIgnoreCase)
      );
      return result.Any() ? result : null;
    }
  }
}
