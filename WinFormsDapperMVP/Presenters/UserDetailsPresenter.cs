using System.ComponentModel.DataAnnotations;
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
    var user = SetUserParameters();
    var valResult = ValidateModel(user);

    if (valResult.Any())
    {
      SetErrorToView(valResult);
      return;
    }

    this._view.ClearValidationErrors();

    if (this._userSource.DataSource != null)
    {
      this._repository.Edit(user);
      CloseAfterAction();
    }
    else
    {
      var created = this._repository.Create(user);
      if (created != null)
      {
        this._userSource.DataSource = created;
        this._view.BindDetailsData(_userSource);
      }
    }
  }

  private void SetErrorToView(List<ValidationResult> valResult)
  {
    if (valResult.Any())
    {
      foreach (var result in valResult)
      {
        foreach (var propName in result.MemberNames)
        {
          _view.ShowValidationErrors(propName, result.ErrorMessage);
        }
      }
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

  private List<ValidationResult> ValidateModel(User user)
  {
    var result = new List<ValidationResult>();
    var context = new ValidationContext(user);
    Validator.TryValidateObject(user, context, result, true);
    return result;
  }
}
