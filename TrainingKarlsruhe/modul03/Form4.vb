Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New Date
        d = Date.Today

        'Dim dd= Date.Today

        'Label1.Text = d.AddDays(-200).ToLongDateString

        Label1.Text = d.ToString("yyyy-MMM.-ddd")


    End Sub
End Class