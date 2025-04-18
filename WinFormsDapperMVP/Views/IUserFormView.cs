namespace WinFormsDapperMVP.Views;
public interface IUserFormView<T> where T : class
{
  //property
  public string Filter { get; set; }

  T SelectedRowValue { get; }



  //events
  event EventHandler SearchEvent;
  event EventHandler AddEvent;
  event EventHandler EditEvent;
  event EventHandler DeleteEvent;

  //source binding
  void BindSource(BindingSource source);
}
