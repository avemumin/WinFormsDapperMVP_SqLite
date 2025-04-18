
using WinFormsDapperMVP.Models;

namespace WinFormsDapperMVP.Views;

public partial class UserDetailsForm : Form, IUserDetailsFormView
{
  public string Id { get => txtId.Text; set => txtId.Text = value; }
  public string LastName { get => txtLastName.Text; set => txtLastName.Text = value; }
  public string Name { get => txtNam.Text; set => txtNam.Text = value; }
  public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
  public DateTime? BirthDay { get => dtCalendar.Value; set => dtCalendar.Value = default; }

  public UserDetailsForm()
  {
    InitializeComponent();
    txtId.ReadOnly = true;
    UserDetailsRaiseEvents();
  }

  private void UserDetailsRaiseEvents()
  {
    btnSave.Click += (s, e) =>
    {
      SaveUserEvent?.Invoke(s, e);
    };
    btnCancel.Click += (s, e) =>
    {
      CancelEvent?.Invoke(s, e);
    };
  }

  public event EventHandler SaveUserEvent;
  public event EventHandler CancelEvent;

  public void BindDetailsData(BindingSource userSource)
  {
    if (userSource.Current is User current)
    {
      txtId.Text = current.Id.ToString();
      txtNam.Text = current.Name;
      txtLastName.Text = current.LastName;
      txtEmail.Text = current.Email;
      dtCalendar.Value = current.BirthDay.HasValue ? current.BirthDay.Value.Date : default;
    }
  }
}
