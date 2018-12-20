Public Class Form19
    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TextBox1.BackColor = Color.AliceBlue
        'Dim farbe = TextBox1.BackColor
        'TextBox1.Text = "Wert"

        Dim t = (1, "Hannes", "Ach", #08/09/1968#)

        Dim satz = $"Hallo {t.Item2}, du bist hier nummer {t.Item1} und wohnst in {t.Item3} und 
bist geboren am {t.Item4:d}"


        Dim tt = (id:=1, Name:="Hannes", ort:="Ach", gebdatum:=#08/09/1968#)

        satz = $"Hallo {tt.id}, du bist hier nummer {tt.Name}und wohnst in {tt.ort} und 
bist geboren am {tt.gebdatum:d}"
        'antik
        'Dim satzanti = "hallo " + t.Item2 + "du bist hier nummer " + t.Item1.ToString

        TextBox1.Text = satz
    End Sub
















    Private Function suchePerson(v As Integer) As (ID As Integer, name As String, ort As String, gebdatum As Date)
        Return (1, "Hannes", "Ach", #08/09/1968#)



    End Function
End Class