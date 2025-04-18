using WinFormsDapperMVP.Helpers;
using WinFormsDapperMVP.Models;
using WinFormsDapperMVP.Repositories;
using WinFormsDapperMVP.Views;

namespace WinFormsDapperMVP.Presenters;

public class UserPresenter
{
  private User SelectedGridItem { get => _view.SelectedRowValue; }
  private readonly IUserFormView<User> _view;
  private readonly IUserRepository _repository;
  private readonly BindingSource _bindingSource;
  private IEnumerable<User> _users;

  public UserPresenter(IUserFormView<User> view, IUserRepository repository)
  {
    this._bindingSource = new BindingSource();
    this._view = view;
    this._repository = repository;
    RisedEventSubscribtion();
    this._view.BindSource(_bindingSource);
    LoadAllUsers();
  }

  private void LoadAllUsers()
  {
    _users = this._repository.GetAll() ?? new List<User>();
    _bindingSource.DataSource = _users;
  }

  private void RisedEventSubscribtion()
  {
    this._view.AddEvent += AddUser;
    this._view.EditEvent += EditUser;
    this._view.DeleteEvent += DeleteUser;
    this._view.SearchEvent += SearchUser;

  }

  private void SearchUser(object? sender, EventArgs e)
  {
    string filter = this._view.Filter;
    if (!string.IsNullOrWhiteSpace(filter))
      _users = this._repository.GetAll()
        .FilterCollection(filter);
    else
      _users = this._repository.GetAll();
    _bindingSource.DataSource = _users;
  }

  private void DeleteUser(object? sender, EventArgs e)
  {

  }

  private void AddUser(object? sender, EventArgs e)
  {
    IUserDetailsFormView dview = new UserDetailsForm();
    new UserDetailsPresenter(dview, _repository);
    ((Form)dview).ShowDialog();
    LoadAllUsers();

  }
  private void EditUser(object? sender, EventArgs e)
  {
    if (SelectedGridItem != null)
    {
      var user = SetSelectedRowDataToUser(SelectedGridItem);
      IUserDetailsFormView dview = new UserDetailsForm();
      new UserDetailsPresenter(dview, _repository, user);
      ((Form)dview).ShowDialog();
      LoadAllUsers();
    }
  }
  private User SetSelectedRowDataToUser(User? user)
  {
    return new User()
    {
      Id = user.Id,
      Name = user.Name,
      LastName = user.LastName,
      Email = user.Email,
      BirthDay = user.BirthDay
    };
  }
}