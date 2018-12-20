Public Class Form23
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim meinAuto = New KFZ
        meinAuto.fahrgestellnummer = 1234
        meinAuto.farbe = Color.Aqua
        meinAuto.hersteller = "BMW"
        meinAuto.tuev = CheckBox1.Checked
        Label1.Text = $"Fahrgestellnummer {meinAuto.fahrgestellnummer:D9}
meine Farbe {meinAuto.farbe}
kommt von {meinAuto.hersteller}
und hat  {(If(meinAuto.tuev, "", "keinen"))} TÜV"
    End Sub

End Class