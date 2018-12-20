Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim wert As String = "Hallo"

        'Dim rückgabe = MyFunc("Servus")
        Dim rückgabe = MyFunc()
    End Sub

    Function MyFunc(Optional wert As String = "") As Integer
        wert = "pfiadi"
        Return 0
    End Function
End Class