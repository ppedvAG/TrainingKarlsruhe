Public Class Form15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = Anrede(TextBox1.Text)
    End Sub
    Function Anrede(Buchstabe As String) As String
        Select Case Buchstabe.ToUpper  'kleinbuchstabe -> Großbuchstabe
            Case "M"
                Return "Herr"
            Case "W"
                Return "Frau"

            Case Else
                Return "Hallo"
        End Select


    End Function
    Function Anrede(Buchstabe As Integer) As String

    End Function
End Class