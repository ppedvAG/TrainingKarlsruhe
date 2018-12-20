Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'halber Weihnachtsbaum
        Dim a(9) As String
        Dim temp = "***********"
        For index = 0 To 9
            If index < 7 Then
                a(index) = temp.Substring(0, index)
            Else
                a(index) = "*"
            End If


        Next
        ListBox1.DataSource = a
    End Sub
End Class