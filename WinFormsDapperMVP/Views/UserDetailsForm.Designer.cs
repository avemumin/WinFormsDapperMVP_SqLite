namespace WinFormsDapperMVP.Views
{
  partial class UserDetailsForm
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
      btnSave = new Button();
      btnCancel = new Button();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      label5 = new Label();
      txtId = new TextBox();
      txtNam = new TextBox();
      txtLastName = new TextBox();
      txtEmail = new TextBox();
      dtCalendar = new DateTimePicker();
      SuspendLayout();
      // 
      // btnSave
      // 
      btnSave.Location = new Point(73, 358);
      btnSave.Name = "btnSave";
      btnSave.Size = new Size(120, 40);
      btnSave.TabIndex = 0;
      btnSave.Text = "Save";
      btnSave.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      btnCancel.Location = new Point(309, 358);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(120, 40);
      btnCancel.TabIndex = 1;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 15F);
      label1.Location = new Point(37, 22);
      label1.Name = "label1";
      label1.Size = new Size(35, 28);
      label1.TabIndex = 2;
      label1.Text = "ID:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 15F);
      label2.Location = new Point(37, 88);
      label2.Name = "label2";
      label2.Size = new Size(68, 28);
      label2.TabIndex = 3;
      label2.Text = "Name:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Font = new Font("Segoe UI", 15F);
      label3.Location = new Point(37, 154);
      label3.Name = "label3";
      label3.Size = new Size(107, 28);
      label3.TabIndex = 4;
      label3.Text = "Last Name:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Font = new Font("Segoe UI", 15F);
      label4.Location = new Point(37, 220);
      label4.Name = "label4";
      label4.Size = new Size(63, 28);
      label4.TabIndex = 5;
      label4.Text = "Email:";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Font = new Font("Segoe UI", 15F);
      label5.Location = new Point(37, 286);
      label5.Name = "label5";
      label5.Size = new Size(96, 28);
      label5.TabIndex = 6;
      label5.Text = "Birth Day:";
      // 
      // txtId
      // 
      txtId.Font = new Font("Segoe UI", 15F);
      txtId.Location = new Point(147, 22);
      txtId.Name = "txtId";
      txtId.Size = new Size(100, 34);
      txtId.TabIndex = 7;
      // 
      // txtNam
      // 
      txtNam.Font = new Font("Segoe UI", 15F);
      txtNam.Location = new Point(147, 86);
      txtNam.Name = "txtNam";
      txtNam.Size = new Size(613, 34);
      txtNam.TabIndex = 8;
      // 
      // txtLastName
      // 
      txtLastName.Font = new Font("Segoe UI", 15F);
      txtLastName.Location = new Point(147, 158);
      txtLastName.Name = "txtLastName";
      txtLastName.Size = new Size(613, 34);
      txtLastName.TabIndex = 9;
      // 
      // txtEmail
      // 
      txtEmail.Font = new Font("Segoe UI", 15F);
      txtEmail.Location = new Point(147, 225);
      txtEmail.Name = "txtEmail";
      txtEmail.Size = new Size(613, 34);
      txtEmail.TabIndex = 10;
      // 
      // dtCalendar
      // 
      dtCalendar.Font = new Font("Segoe UI", 15F);
      dtCalendar.Location = new Point(147, 291);
      dtCalendar.Name = "dtCalendar";
      dtCalendar.Size = new Size(613, 34);
      dtCalendar.TabIndex = 11;
      // 
      // UserDetailsForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(804, 451);
      Controls.Add(dtCalendar);
      Controls.Add(txtEmail);
      Controls.Add(txtLastName);
      Controls.Add(txtNam);
      Controls.Add(txtId);
      Controls.Add(label5);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(btnCancel);
      Controls.Add(btnSave);
      MinimumSize = new Size(820, 490);
      Text = "UserDetailsForm";
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button btnSave;
    private Button btnCancel;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private TextBox txtId;
    private TextBox txtNam;
    private TextBox txtLastName;
    private TextBox txtEmail;
    private DateTimePicker dtCalendar;
  }
}