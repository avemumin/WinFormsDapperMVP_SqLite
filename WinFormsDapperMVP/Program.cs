using System.Configuration;
using WinFormsDapperMVP.Models;
using WinFormsDapperMVP.Presenters;
using WinFormsDapperMVP.Repositories;
using WinFormsDapperMVP.Views;

namespace WinFormsDapperMVP
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      IUserFormView<User> view = new UsersForm();
      IUserRepository repo = new UserRepository(SetConn());
      new UserPresenter(view, repo);
      Application.Run((Form)view);
    }
    private static string SetConn() => ConfigurationManager.ConnectionStrings["SQLiteConnection"].ConnectionString;
  }
}