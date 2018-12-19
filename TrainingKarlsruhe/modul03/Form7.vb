Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a(2) As String
        a(0) = "Firma"
        a(1) = "Frau"
        a(2) = "Mann"

        ComboBox1.DataSource = a


        Dim b() As String = {"Firma", "Frau", "Mann"}
    End Sub
End Class