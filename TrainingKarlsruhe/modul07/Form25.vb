Public Class Form25
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim meinauto = New kfz3("BMW")
        Label1.Text = $"Herstellt{meinauto.Hersteller} mit der Nummer {meinauto.fahrgestellnummer}"
    End Sub
End Class