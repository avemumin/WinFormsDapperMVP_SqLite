namespace WinFormsDapperMVP.Views;

public interface IUserDetailsFormView
{

  public string Id { get; set; }
  public string Name { get; set; }
  public string  LastName { get; set; }
  public string Email { get; set; }
  public DateTime? BirthDay { get; set; }

  event EventHandler SaveUserEvent;
  event EventHandler CancelEvent;

  void BindDetailsData(BindingSource userSource);
}
