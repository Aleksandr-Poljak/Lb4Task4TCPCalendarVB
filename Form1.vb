Public Class Form1

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim calendar As New MSACAL.Calendar
        Dim cur_date As New Date(calendar.Year, calendar.Month, calendar.Day)
        c_widget.TodayDate = cur_date
        c_widget.SetDate(cur_date)
        c_widget.Update()
    End Sub

    Private Sub Bt_Change_Click(sender As Object, e As EventArgs) Handles Bt_Change.Click


        Try
            Dim calendar As New MSACAL.Calendar
            calendar.Day = CInt(Tb_Day.Text)
            calendar.Month = CInt(Tb_Month.Text)
            calendar.Year = CInt(Tb_Year.Text)

            Dim cur_date As New Date(calendar.Year, calendar.Month, calendar.Day)
            c_widget.TodayDate = cur_date
            c_widget.SetDate(cur_date)
            c_widget.Update()

        Catch ex As Exception
            MessageBox.Show("Ошибка ввода.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

    End Sub
End Class
