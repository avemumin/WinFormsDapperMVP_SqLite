using WinFormsDapperMVP.Models;
using WinFormsDapperMVP.Views;

namespace WinFormsDapperMVP
{
  public partial class UsersForm : Form, IUserFormView<User>
  {
    public UsersForm()
    {
      InitializeComponent();
      GridStartParams();
      RiseEvents();
    }

    private void RiseEvents()
    {
      btnSearch.Click += (s, e) =>
      {
        SearchEvent?.Invoke(s, e);
      };
      txtSerach.KeyDown += (s, e) =>
      {
        if (e.KeyCode == Keys.Enter) { SearchEvent?.Invoke(s, e); }
      };
      btnAdd.Click += (s, e) =>
      {
        AddEvent?.Invoke(s, e);
      };
      btnEdit.Click += (s, e) =>
      {
        EditEvent?.Invoke(s, e);
      };
      btnDelete.Click += (s, e) =>
      {
        DeleteEvent?.Invoke(s, e);
      };
    }
    private void GridStartParams()
    {
      dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgView.ReadOnly = true;
      dgView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dgView.ClearSelection();
      dgView.CurrentCell = null;
      dgView.MultiSelect = false;
    }
    public string Filter { get => txtSerach.Text; set => txtSerach.Text = value; }

    public User SelectedRowValue
    {
      get
      {
        if (dgView.CurrentRow != null)
        {
          return dgView.CurrentRow.DataBoundItem as User;

        }
        return null;
      }
    }

   
    public event EventHandler SearchEvent;
    public event EventHandler AddEvent;
    public event EventHandler EditEvent;
    public event EventHandler DeleteEvent;



    public void BindSource(BindingSource source)
    {
      dgView.DataSource = source;
    }
  }
}
