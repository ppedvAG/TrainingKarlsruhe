Public Class Form13
    Sub MeinBeep(frequenz As Integer, dauer As Integer)
        'Beep()
        Console.Beep(frequenz, dauer * 1000)
    End Sub

    Sub MeinBeep(dauer As Integer)
        Console.Beep(3000, dauer * 1000)
    End Sub
    Sub meinBeep()
        MessageBox.Show("nix")
    End Sub
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MeinBeep(12000, 1)
        MeinBeep(1)
    End Sub

End Class