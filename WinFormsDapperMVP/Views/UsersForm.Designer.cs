namespace WinFormsDapperMVP
{
  partial class UsersForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      label1 = new Label();
      txtSerach = new TextBox();
      btnSearch = new Button();
      btnAdd = new Button();
      btnEdit = new Button();
      btnDelete = new Button();
      dgView = new DataGridView();
      ((System.ComponentModel.ISupportInitialize)dgView).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 15F);
      label1.Location = new Point(9, 12);
      label1.Name = "label1";
      label1.Size = new Size(60, 28);
      label1.TabIndex = 0;
      label1.Text = "Filter:";
      // 
      // txtSerach
      // 
      txtSerach.Font = new Font("Segoe UI", 15F);
      txtSerach.Location = new Point(75, 12);
      txtSerach.Name = "txtSerach";
      txtSerach.Size = new Size(587, 34);
      txtSerach.TabIndex = 1;
      // 
      // btnSearch
      // 
      btnSearch.Font = new Font("Segoe UI", 15F);
      btnSearch.Location = new Point(668, 12);
      btnSearch.Name = "btnSearch";
      btnSearch.Size = new Size(120, 40);
      btnSearch.TabIndex = 2;
      btnSearch.Text = "Search";
      btnSearch.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      btnAdd.Font = new Font("Segoe UI", 15F);
      btnAdd.Location = new Point(668, 306);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(120, 40);
      btnAdd.TabIndex = 3;
      btnAdd.Text = "Add";
      btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnEdit
      // 
      btnEdit.Font = new Font("Segoe UI", 15F);
      btnEdit.Location = new Point(668, 352);
      btnEdit.Name = "btnEdit";
      btnEdit.Size = new Size(120, 40);
      btnEdit.TabIndex = 4;
      btnEdit.Text = "Edit";
      btnEdit.UseVisualStyleBackColor = true;
      // 
      // btnDelete
      // 
      btnDelete.Font = new Font("Segoe UI", 15F);
      btnDelete.Location = new Point(668, 398);
      btnDelete.Name = "btnDelete";
      btnDelete.Size = new Size(120, 40);
      btnDelete.TabIndex = 5;
      btnDelete.Text = "Delete";
      btnDelete.UseVisualStyleBackColor = true;
      // 
      // dgView
      // 
      dgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgView.Location = new Point(16, 68);
      dgView.Name = "dgView";
      dgView.Size = new Size(646, 370);
      dgView.TabIndex = 6;
      // 
      // UsersForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(804, 451);
      Controls.Add(dgView);
      Controls.Add(btnDelete);
      Controls.Add(btnEdit);
      Controls.Add(btnAdd);
      Controls.Add(btnSearch);
      Controls.Add(txtSerach);
      Controls.Add(label1);
      MinimumSize = new Size(820, 490);
      Name = "UsersForm";
      Text = "UsersForm";
      ((System.ComponentModel.ISupportInitialize)dgView).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox txtSerach;
    private Button btnSearch;
    private Button btnAdd;
    private Button btnEdit;
    private Button btnDelete;
    private DataGridView dgView;
  }
}