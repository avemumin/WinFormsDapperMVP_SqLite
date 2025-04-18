using WinFormsDapperMVP.Models;
using WinFormsDapperMVP.Repositories;
using WinFormsDapperMVP.Views;

namespace WinFormsDapperMVP.Presenters;

public class UserDetailsPresenter
{
  private readonly IUserDetailsFormView _view;
  private readonly IUserRepository _repository;
  private BindingSource _userSource;
  public UserDetailsPresenter(IUserDetailsFormView view, IUserRepository repository, User? user = null)
  {
    _view = view;
    _repository = repository;
    _userSource = user == null ? new BindingSource() : new BindingSource() { DataSource = user };
    this._view.BindDetailsData(_userSource);
    RiseEvent();
  }

  private void RiseEvent()
  {
    this._view.SaveUserEvent += SaveUser;
    this._view.CancelEvent += Cancel;
  }

  private void Cancel(object? sender, EventArgs e)
  {
    CloseAfterAction();
  }

  private void SaveUser(object? sender, EventArgs e)
  {

    if (this._userSource.DataSource != null)
    {
      this._repository.Edit(SetUserParameters());
      CloseAfterAction();
    }
    else
    {
      var created = this._repository.Create(SetUserParameters());
      if (created != null)
      {
        this._userSource.DataSource = created;
      }
      this._view.BindDetailsData(_userSource);
    }
  }

  private User SetUserParameters()
  {
    return new User()
    {
      Id = this._userSource.DataSource != null ? int.Parse(this._view.Id) : default,
      Name = this._view.Name,
      LastName = this._view.LastName,
      Email = this._view.Email,
      BirthDay = this._view.BirthDay
    };
  }
  private void CloseAfterAction()
  {
    ((Form)_view).Close();
  }
}
