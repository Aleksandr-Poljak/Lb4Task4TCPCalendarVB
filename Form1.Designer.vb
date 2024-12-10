<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.c_widget = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Tb_Day = New System.Windows.Forms.TextBox()
        Me.Tb_Month = New System.Windows.Forms.TextBox()
        Me.Tb_Year = New System.Windows.Forms.TextBox()
        Me.Bt_Change = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'c_widget
        '
        Me.c_widget.Location = New System.Drawing.Point(18, 18)
        Me.c_widget.Name = "c_widget"
        Me.c_widget.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "День:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Месяц:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(169, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Год:"
        '
        'Tb_Day
        '
        Me.Tb_Day.Location = New System.Drawing.Point(18, 309)
        Me.Tb_Day.Name = "Tb_Day"
        Me.Tb_Day.Size = New System.Drawing.Size(55, 22)
        Me.Tb_Day.TabIndex = 7
        Me.Tb_Day.Text = "1"
        '
        'Tb_Month
        '
        Me.Tb_Month.Location = New System.Drawing.Point(92, 309)
        Me.Tb_Month.Name = "Tb_Month"
        Me.Tb_Month.Size = New System.Drawing.Size(55, 22)
        Me.Tb_Month.TabIndex = 8
        Me.Tb_Month.Text = "1"
        '
        'Tb_Year
        '
        Me.Tb_Year.Location = New System.Drawing.Point(172, 309)
        Me.Tb_Year.Name = "Tb_Year"
        Me.Tb_Year.Size = New System.Drawing.Size(55, 22)
        Me.Tb_Year.TabIndex = 9
        Me.Tb_Year.Text = "2005"
        '
        'Bt_Change
        '
        Me.Bt_Change.Location = New System.Drawing.Point(274, 281)
        Me.Bt_Change.Name = "Bt_Change"
        Me.Bt_Change.Size = New System.Drawing.Size(111, 50)
        Me.Bt_Change.TabIndex = 10
        Me.Bt_Change.Text = "Изменить"
        Me.Bt_Change.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 353)
        Me.Controls.Add(Me.Bt_Change)
        Me.Controls.Add(Me.Tb_Year)
        Me.Controls.Add(Me.Tb_Month)
        Me.Controls.Add(Me.Tb_Day)
        Me.Controls.Add(Me.c_widget)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents c_widget As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Tb_Day As TextBox
    Friend WithEvents Tb_Month As TextBox
    Friend WithEvents Tb_Year As TextBox
    Friend WithEvents Bt_Change As Button
End Class
