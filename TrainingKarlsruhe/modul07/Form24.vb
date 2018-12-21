Public Class Form24
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim meinauto = New kfz2
        meinauto.Hersteller = "BMW"
        meinauto.GeneriereFahrgestellnummer()

        Label1.Text = $"Herstellt{meinauto.Hersteller} mit der Nummer {meinauto.fahrgestellnummer}"
    End Sub
End Class