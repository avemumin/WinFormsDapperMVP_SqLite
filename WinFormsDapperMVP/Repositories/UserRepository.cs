using Dapper;
using System.Data.SQLite;
using WinFormsDapperMVP.Models;

namespace WinFormsDapperMVP.Repositories;

public class UserRepository : IUserRepository
{
  private readonly string _connection = string.Empty;

  public UserRepository(string connection)
  {
    _connection = connection;
  }
  public User? Create(User user)
  {
    string insertQquery = @"Insert into Users (Name, LastName, Email, BirthDay)  VALUES (@Name, @LastName, @Email, @BirthDay) RETURNING Id, Name, LastName, Email, BirthDay";
    using var conn = new SQLiteConnection(this._connection);
    conn.Open();
    var parameters =  Params(user);
    var result = conn.QuerySingle<User>(insertQquery, parameters);
    conn.Close();
    return result;
  }

  public void Delete(User user)
  {
    if (user is null) throw new Exception("Record is null");
    string deleteQuery = "Delete From Users where Id = @Id";
    using var conn = new SQLiteConnection(this._connection);
    conn.Open();
    conn.Execute(deleteQuery, new { Id = user.Id });
    conn.Close();
  }

  public void Edit(User user)
  {
    if (user is null) throw new Exception("User does not exists");
    string updateQuery = "Update Users SET Name = @Name, LastName = @LastName, Email=@Email, BirthDay=@BirthDay Where Id = @Id";
    using var conn = new SQLiteConnection(this._connection);
    conn.Open();
    var parameters = Params(user);
    conn.Execute(updateQuery, parameters);
    conn.Close();
  }

  public IEnumerable<User> GetAll()
  {
    var result = new List<User>();
    string sqlQuery = "Select * FROM Users";
    using var conn = new SQLiteConnection(this._connection);
    result = conn.Query<User>(sqlQuery).ToList();
    if (result is null)
    {
      throw new Exception("The list is empty");
    }
    return result;
  }

  public static object Params(User user)
  {
    return new
    {
      Id = user.Id,
      Name = user.Name,
      LastName = user.LastName,
      Email = user.Email,
      BirthDay = user.BirthDay
    };
  }
}
