Imports System.Text

Public Class Form22
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s = "string" + vbCrLf + "string"

        Dim sb = New StringBuilder
        sb.AppendLine("hallo,")

        sb.AppendLine("wir haben uns schon ")
        sb.AppendLine("lange nicht mehr gesehen ")
        sb.AppendLine("")
        sb.AppendLine("Mirt freundlichen Grüßen")
        sb.AppendLine("")
        sb.Append("und ps")


        Dim sb2 = sb     'zeiger
        sb2.AppendLine("SB2 Append line")
        methode(sb)
        Label1.Text = sb.ToString



    End Sub
    Public Sub methode(ByRef sb3 As StringBuilder)
        sb3.AppendLine("sb3 Methode")
    End Sub
End Class