Public Class Form24
    Dim autoliste As Dictionary(Of String, kfz2) = New Dictionary(Of String, kfz2)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim meinauto = New kfz2
        meinauto.Hersteller = "BMW"
        meinauto.GeneriereFahrgestellnummer()
        If Not autoliste.ContainsKey(meinauto.fahrgestellnummer) Then
            autoliste.Add(meinauto.fahrgestellnummer, meinauto)
        End If

        Label1.Text = $"Herstellt{meinauto.Hersteller} mit der Nummer {meinauto.fahrgestellnummer}"
    End Sub
End Class