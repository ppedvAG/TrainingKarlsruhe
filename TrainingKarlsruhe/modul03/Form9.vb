Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(5) As Integer
        For index = 0 To 5
            a(index) = (CInt(Rnd() * 49))
        Next
        ListBox1.DataSource = a
    End Sub
End Class