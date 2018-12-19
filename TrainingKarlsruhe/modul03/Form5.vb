Public Class Form5
    Const pi As Double = 3.1415926
    Public var1 As String 'sparsam verwenden wegen Speicherbedarf
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        var1 = "max" 'global von oben verändert
        Label1.Text = Addieren(CInt(TextBox1.Text), CInt(TextBox2.Text))


    End Sub
    Function Addieren(zahl1 As Integer, zahl2 As Integer) As String
        Dim var1 As String 'lokale Variable
        Return (zahl1 + zahl2).ToString
    End Function
End Class