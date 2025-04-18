using WinFormsDapperMVP.Models;

namespace WinFormsDapperMVP.Repositories;

public interface IUserRepository
{
  User? Create(User user);
  void Edit(User user);
  void Delete(User user);
  IEnumerable<User> GetAll();


}
