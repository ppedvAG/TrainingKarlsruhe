Public Class Form10

    Private Sub Form10_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Debug.WriteLine(e.KeyCode.ToString())

        Select Case e.KeyCode.ToString()
            Case "Left"
                Label1.Left -= 1
            Case "Right"
                Label1.Left += 1

            Case "Down"
                Label1.Top += 1
            Case "Up"
                Label1.Top -= 1
            Case Else
                MessageBox.Show("nur L R U O Taste")
        End Select
    End Sub


End Class