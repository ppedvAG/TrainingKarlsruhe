Public Class Form10

    Private Sub Form10_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        Select Case e.KeyCode.ToString()
            Case "L"
                Label1.Left -= 1
            Case "R"
                Label1.Left += 1

            Case "U"
                Label1.Top += 1
            Case "O"
                Label1.Top -= 1
            Case Else
                MessageBox.Show("nur L R U O Taste")
        End Select
    End Sub


End Class